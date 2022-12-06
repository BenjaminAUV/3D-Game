using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMan : MonoBehaviour
{

    public TMP_Text tMP_Text;

    // Start is called before the first frame update
    void Start()
    {
        tMP_Text.text+=GameC.coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
