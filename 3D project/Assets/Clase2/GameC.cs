using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameC : MonoBehaviour
{

    public static short coins;

    void Awake(){
        DontDestroyOnLoad(gameObject);
    }

}
