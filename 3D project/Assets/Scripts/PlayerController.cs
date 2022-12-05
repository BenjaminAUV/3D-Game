using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    CharacterController characterController;
    PlayerInputHandler playerInputHandler;
    public float velocidad_caminar=6.0f;

    public float velocidad_correr=10.0f;

    public float velocidad_salto=18.0f;
 
   public float gravedad =70.0f;

    private Vector3 movimiento = Vector3.zero;

    // Start is called before the first frame update

    void Start()

    {

        characterController = GetComponent<CharacterController>();
        playerInputHandler = GetComponent<PlayerInputHandler>();
    }



    // Update is called once per frame

    void Update()

    {

        if(characterController.isGrounded){

            movimiento= new Vector3(playerInputHandler.MoveInput.x, 0.0f, playerInputHandler.MoveInput.y);

            if(Input.GetKey(KeyCode.LeftShift)){

                movimiento = transform.TransformDirection(movimiento)* velocidad_correr; 

            }

            else{

                movimiento = transform.TransformDirection(movimiento)* velocidad_caminar;

            }

            if(playerInputHandler.Jump){
                playerInputHandler.UseJumpInput();
                movimiento.y = velocidad_salto;

            }

            

        }

        movimiento.y -= gravedad * Time.deltaTime;

        characterController.Move(movimiento*Time.deltaTime);
        

    }
}
