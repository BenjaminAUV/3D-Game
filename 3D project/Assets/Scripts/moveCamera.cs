using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public PlayerInputHandler playerInputHandler;
    


    public Transform targetTransform;
    public Transform cameraPivot;
    private Vector3 cameraFollowVelocity = Vector3.zero;
    public float cameraFollowSpeed= 0.2f;

    [SerializeField]private float cameraLookSpeed = 1f;
    private float cameraPivotSpeed = 1f;
    [SerializeField]private Vector3 cameraPosition = Vector3.zero;
    [SerializeField]private Vector3 cameraRotation = Vector3.zero;

    private float lookAngle;
    private float pivotAngle;

    void Start(){

    }

    void Update(){

        Cursor.lockState = CursorLockMode.Locked;
        //transform.LookAt(targetTransform);
        
    }
    void LateUpdate(){

        //transform.Translate((new Vector3(0f,playerInputHandler.NormalizedMouseInputY,0f)* Time.deltaTime)*cameraLookSpeed);

    }


    public void RotateCamera(){
        lookAngle += (playerInputHandler.MouseInput.x * cameraLookSpeed);
        pivotAngle = pivotAngle + (playerInputHandler.MouseInput.y * cameraPivotSpeed);
        //transform.Translate(new Vector3(lookAngle,0f,0f)*Time.deltaTime);

        Vector3 rotation = Vector3.zero;
        rotation.x = cameraRotation.x;
        rotation.y = lookAngle;
        Quaternion targetR = Quaternion.Euler(rotation);
        transform.rotation = targetR;
    }

}
