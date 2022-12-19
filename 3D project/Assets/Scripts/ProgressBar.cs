using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    [SerializeField]private PlayerController playerController;

    private void Start(){
        slider = GetComponent<Slider>();
        slider.maxValue = 100;
        slider.minValue = 0;
        slider.value = playerController.Health; 

    }
    private void Update(){
        slider.value = playerController.Health;
    }

}
