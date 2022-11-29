using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    private float rX = 0f;
    private float rY = 0f;

    public Transform target;

    private Vector3 vector3;
    [SerializeField]private float sen = 0.5f;

    void Start(){

    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        transform.LookAt(target);
        rX += Input.GetAxis("Mouse Y")*-1*sen;
        rY += Input.GetAxis("Mouse X")*sen;
        
        vector3.Set(rX,rY,0f);
    }
    void FixedUpdate(){

        transform.Translate(vector3*Time.deltaTime);

    }
}
