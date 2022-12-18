using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class PlayerController : MonoBehaviour
{
    [SerializeField]private Transform spwanPoint;
    private Vector3 spwanPointPos;
    public byte Health{get; private set;}
    public byte Lifes{get; private set;}

    CharacterController characterController;
    PlayerInputHandler playerInputHandler;
    public float velocidad_caminar=6.0f;

    public float velocidad_correr=10.0f;

    public float velocidad_salto=18.0f;
 
   public float gravedad =70.0f;

    private Vector3 movimiento = Vector3.zero;
    public float lookSpeed;
    // private Camera cameraRef = Camera.main;
    // private Vector3 foward;
    // private Vector3 right;

    public TMP_Text text;

    [SerializeField]private Transform modelRef;
    [SerializeField]private Vector3 testVector = Vector3.zero;


    float look;



    // Start is called before the first frame update

    void Start()

    {

        this.Health=100;
        this.Lifes= 3;
        characterController = GetComponent<CharacterController>();
        playerInputHandler = GetComponent<PlayerInputHandler>();
        spwanPointPos = spwanPoint.position;
    }



    // Update is called once per frame

    void Update()

    {

        text.text=@$"   
                        Health{this.Health}
                        Lifes{this.Lifes}
                        Position{this.transform.position}
                        SpanwPoint{this.spwanPointPos}
        ";
        if(characterController.enabled == true){

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

        RotatePlayer();

        }
        
        
        
        
    }

    void RotatePlayer(){
        Vector3 rotation = Vector3.zero;
        look += playerInputHandler.NormalizedMouseInputX*lookSpeed;
        rotation.y= look;
        Quaternion quaternion = Quaternion.Euler(rotation);
        transform.rotation=quaternion;
    }
    public void GetHurt(){
        if(Health>0 & Lifes!=0){
            this.Health-=1;
            
        }
        if(Health<1 & Lifes!=0){
            Die();
        }else{}
    }
    private void Die(){
        
        if(Lifes>0){
            
            Lifes-=1;
            Respawn();

        }
        if(Lifes==0){
            Debug.Log("GAME OVER");
        }
    }
    private void Respawn(){
        StartCoroutine("Teleport");   
    }
    IEnumerator Teleport(){
        Debug.Log("Call Teleport");
        characterController.enabled = false;
        yield return new WaitForSeconds(0.1f);
        gameObject.transform.position = spwanPointPos;
        yield return new WaitForSeconds(0.1f);
        characterController.enabled = true;
        this.Health=100;

    }


    public void SetSpawnPoint(Vector3 newSpawnPoint){
        spwanPointPos = newSpawnPoint;
    }


}
