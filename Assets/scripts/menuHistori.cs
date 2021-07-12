using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuHistori : MonoBehaviour{
    string scene;
    public void Start(){
        if (PlayerPrefs.GetInt("historyText") == 0){
            scene = "select";
        }
        else if (PlayerPrefs.GetInt("historyText") == 4){
            scene = "mainMenu";
        }
        else{
            scene = "nextSite";
        }
    }

    public void pressContinue(){
        SceneManager.LoadScene(scene);
    }
}
