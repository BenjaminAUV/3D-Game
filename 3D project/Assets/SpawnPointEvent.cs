using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointEvent : MonoBehaviour
{
    [SerializeField]private PlayerController target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPlayerSpawn(){
        target.SetSpawnPoint(this.transform.position);
        Debug.Log(this.transform.position);
    }
}
