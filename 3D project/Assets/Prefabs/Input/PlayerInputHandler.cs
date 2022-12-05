using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerInputHandler : MonoBehaviour
{
    public Vector2 MoveInput{get; private set;}

    public bool Jump{get; private set;}

    public Vector2 MouseInput{get; private set;}

    void Update(){

    }
    public void OnMoveInput(InputAction.CallbackContext context){
        if(context.performed || context.canceled){
            MoveInput=context.ReadValue<Vector2>();

        }
    }
    public void OnJumpInput(InputAction.CallbackContext context){
        if(context.performed){
            Jump = true;
        }

    }
    public void UseJumpInput() => Jump = false;

    public void OnMouseInput(InputAction.CallbackContext context){
        Debug.Log(context.ReadValue<Vector2>());
        if(context.performed || context.canceled){
            MouseInput=context.ReadValue<Vector2>();
        }
    }

}
