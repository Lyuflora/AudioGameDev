using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TurnTheGameOn.Timer;

public class PlayerControlls : MonoBehaviour
{

    private Rigidbody rb;

    private KeyControls kc;
    private PlayerInput playerInput;
    [SerializeField]
    private GameObject bound;

    Vector2 screenBounds;
    Vector2 customBounds;

    public bool useScreenBounds;

    // Global Timer
    public TurnTheGameOn.Timer.Timer timer;

    [SerializeField]
    private string currentActionMap;

    private RaycastEvents raycastEvents;

    public DeviceOrientation currentOrientation;
    public DeviceOrientation previousOrientation;
    public bool isFacingUp;

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

        // disable timer at the beginner
        timer.timerState = TimerState.Disabled;
    }
    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        customBounds = new Vector2(Math.Abs(bound.transform.position.x), Math.Abs(bound.transform.position.y));

        previousOrientation = currentOrientation = Input.deviceOrientation;
    }

    private void FixedUpdate()
    {
        // Move {Keyboard} with input
        kc.Player.Move.ReadValue<Vector2>();
        Vector2 inputVector = kc.Player.Move.ReadValue<Vector2>();
        //rb.velocity = inputVector * speed;

    }

    private void LateUpdate()
    {
        // Boundaries
        ClampView();

        // Screen Orientation
        // after game starts
        if(currentActionMap != playerInput.currentActionMap.name)
        {
            return;
        }
        previousOrientation = currentOrientation;
        currentOrientation = Input.deviceOrientation;
        isFacingUp = (currentOrientation == DeviceOrientation.FaceUp);
        if (previousOrientation != currentOrientation)
        {
            if(currentOrientation == DeviceOrientation.FaceDown|| currentOrientation == DeviceOrientation.FaceUp)
            {
                ARDebugManager.Instance.LogInfo("Flip Screen");
                //QTESystem.m_Instance.TriggerChildByCurrentIndex();
                BeatManager.m_Instance.CheckHitBeat();
                BarbecueManager.m_instance.ChangeBackgroundColor(currentOrientation);
            }
        }
        
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
        if (context.started)
        {
            
        }
        if (context.performed)    
        {
            //bool res = ShootBullet();
            //ARDebugManager.Instance.LogInfo($"Shoot + {transform.position}");

            if (BeatManager.m_Instance.beatState == BeatState.Beating)
            {
                //QTESystem.m_Instance.TriggerChildByCurrentIndex();

                BarbecueManager.m_instance.ChangeBackgroundColor(isFacingUp);
                BeatManager.m_Instance.CheckHitBeat();

            }else if (BeatManager.m_Instance.beatState == BeatState.Disabled)
            {
                // Skip 
            }


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

    // Start game
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

            // Play start sound
            UIManager.m_Instance.SwitchStartUI();
            BeatManager.m_Instance.PlayStartSound();
            StartCoroutine(GameStartWithDelay(BeatManager.m_Instance.startDelay));
        }

    }

    IEnumerator GameStartWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        BeatManager.m_Instance.StartBeating();
        timer.timerState = TimerState.Counting;
    }
}
