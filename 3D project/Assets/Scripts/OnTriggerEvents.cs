using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnTriggerEvents : MonoBehaviour
{
    [SerializeField]private Collider target;
    public static OnTriggerEvents current;
    [SerializeField]public UnityEvent onTriggerExit,onTriggerEnter,onTriggerStay;

    
    void Awake()
    {
        current = this;
    }
    

    public void OnTriggerExit(Collider collider){
        if(collider.CompareTag(target.tag)){
            onTriggerExit.Invoke();
        }
    }
    public void OnTriggerEnter(Collider collider){
        if(collider.CompareTag(target.tag)){
            onTriggerEnter.Invoke();
        }
    }
    public void OnTriggerStay(Collider collider){
        if(collider.CompareTag(target.tag)){
            onTriggerStay.Invoke();
        }
    }
}
