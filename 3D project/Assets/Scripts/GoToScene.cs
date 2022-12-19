using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToScene : MonoBehaviour
{
    [SerializeField]private string targetScene;
    [SerializeField]private TMPro.TMP_InputField playerNameField,ageField;
    [SerializeField]private TMPro.TMP_Text messageText;

    private byte age;
    private string playerName;

    void Start()
    {

        messageText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void GoToTarget(){
        SceneManager.LoadScene(targetScene);
    }
    private void CheckAge(){
        if(age>=18){
            PersistentData.playerName = this.playerName;
            GoToTarget();
        }else{
            messageText.text = "Player must be 18 or older";
        }
    }
    public void GetPlayerData(){
        messageText.text = "";
        playerName = playerNameField.text;
        age = byte.Parse(ageField.text);
        CheckAge();
    }

}
