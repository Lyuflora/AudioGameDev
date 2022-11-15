using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CrossHair : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;

    private KeyControls kc;
    private PlayerInput playerInput;
    [SerializeField]
    private GameObject bound;

    Vector2 screenBounds;
    Vector2 customBounds;

    public bool useScreenBounds;
    [SerializeField]
    private string currentActionMap;

    private RaycastEvents raycastEvents;

  
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        raycastEvents = GetComponent<RaycastEvents>();

        kc = new KeyControls();
        kc.UI.Enable();
        kc.Player.Disable();
        currentActionMap = playerInput.currentActionMap.name;
        // Fire
        // kc.Player.Fire.performed += ShootBullet;
    }
    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        customBounds = new Vector2(Math.Abs(bound.transform.position.x), Math.Abs(bound.transform.position.y));
    }

    private void FixedUpdate()
    {
        // Move {Keyboard}
        kc.Player.Move.ReadValue<Vector2>();
        Vector2 inputVector = kc.Player.Move.ReadValue<Vector2>();
        rb.velocity = inputVector * speed;

    }

    private void LateUpdate()
    {
        // Boundaries
        ClampView();
    }

    public void ClampView()
    {
        Vector3 viewPos = transform.position;

        float xBound = useScreenBounds ? screenBounds.x : customBounds.x;
        float yBound = useScreenBounds ? screenBounds.y : customBounds.y;

        viewPos.x = Math.Clamp(viewPos.x, xBound * -1, xBound);
        viewPos.y = Math.Clamp(viewPos.y, yBound * -1, yBound);
        transform.position = viewPos;
    }

    public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed)    
        {
            Debug.Log($"Shoot + {transform.position}");


            bool res = ShootBullet();


        }
        
    }

    bool ShootBullet() {

        RaycastHit hit;
        float shootRange = 100f;
        Vector3 rayOrigin = gameObject.transform.position;
        if (Physics.Raycast(rayOrigin, Camera.main.transform.forward, out hit, shootRange))
        {
            if (hit.collider == null)
            {
                return false;
            }
            else
            {
                if (hit.transform.tag == "Interactable")
                {
                    Debug.Log("Shoot item");
                }
                else if (hit.transform.tag == "Target")
                {
                    Debug.Log("Shoot target");
                }
                return true;
            }
        }
        return false;
        
    }

    public void MissionStart(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log($"Mission Start + {context}");
            // Switch action map
            playerInput.SwitchCurrentActionMap("Player");
            kc.Player.Enable();
            kc.UI.Disable();

            currentActionMap = playerInput.currentActionMap.name;
        }

    }
}
