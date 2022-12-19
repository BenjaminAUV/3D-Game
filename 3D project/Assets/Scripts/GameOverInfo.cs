using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOverInfo : MonoBehaviour
{
    private TMP_Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        
        
        text.text = $"Nombre:{PersistentData.playerName}\nGems:{PersistentData.gemsCollected}";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
