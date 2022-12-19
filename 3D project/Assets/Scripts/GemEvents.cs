using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemEvents : MonoBehaviour
{
    [SerializeField]private GameObject target;
    [SerializeField]private PlayerController playerController;

    [SerializeField]private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeActivate(){
        audioSource.Play(0);
        playerController.AddGem();
        target.SetActive(false);
    }
}
