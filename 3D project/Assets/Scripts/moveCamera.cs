using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public PlayerInputHandler playerInputHandler;
    
    private float cameraLookSpeed = 1f;
    private float cameraPivotSpeed = 1f;

    public Transform targetTransform;
    public Transform cameraPivot;
    public Vector3 cameraFollowVelocity = Vector3.zero;
    public float cameraFollowSpeed= 0.2f;

    public float positionX = 0f;
    public float positionY = 2.5f;
    public float positionZ = -2f;

    public float lookAngle;
    public float pivotAngle;

    void Start(){

    }

    void Update(){

    }
    void LateUpdate(){
        
        RotateCamera();
        FollowTarget();
    }
    public void FollowTarget(){
        Vector3 targetTP = new Vector3(targetTransform.position.x+positionX,targetTransform.position.y+positionY,targetTransform.position.z+positionZ);
        Vector3 targetP = Vector3.SmoothDamp(transform.position, targetTP,ref cameraFollowVelocity,cameraFollowSpeed);
        transform.position =targetP;
    }

    public void RotateCamera(){
        lookAngle = lookAngle + (playerInputHandler.MouseInput.x * cameraLookSpeed);
        pivotAngle = pivotAngle + (playerInputHandler.MouseInput.y * cameraPivotSpeed);


        Vector3 rotation = Vector3.zero;
        rotation.x = 20f;
        rotation.y = lookAngle;
        Quaternion targetR = Quaternion.Euler(rotation);
        transform.rotation = targetR;
    }

}
