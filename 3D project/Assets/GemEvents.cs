using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemEvents : MonoBehaviour
{
    [SerializeField]private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeActivate(){
        target.SetActive(false);
    }
}