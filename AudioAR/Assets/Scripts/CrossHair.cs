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
    private string currentActionMap;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        kc = new KeyControls();
        kc.UI.Enable();
        kc.Player.Disable();
        currentActionMap = playerInput.currentActionMap.name;
        // Fire
        // kc.Player.Fire.performed += ShootBullet;
    }

    private void FixedUpdate()
    {
        // Move {Keyboard}
        kc.Player.Move.ReadValue<Vector2>();
        Vector2 inputVector = kc.Player.Move.ReadValue<Vector2>();
        rb.AddForce(new Vector3(inputVector.x, inputVector.y, 0) * speed, ForceMode.Force);
    }


    public void ShootBullet(InputAction.CallbackContext context)
    {
        if (context.performed)    
        {
            Debug.Log($"Shoot + {transform.position}");
        }
        
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
