using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameLabel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMPro.TMP_Text>().text=PersistentData.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
