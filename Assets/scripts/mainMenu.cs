using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public int characterView;
    public int characterSelected;
    public int historyText;

    public void Start(){
        characterView = PlayerPrefs.GetInt("charView");
        characterSelected = PlayerPrefs.GetInt("charSel");
        historyText = PlayerPrefs.GetInt("charView");
        PlayerPrefs.SetInt("historyText", 0);
    }

    public void playGame(){
        SceneManager.LoadScene("history");
    }

    public void goGallery(){
        PlayerPrefs.SetString("seeCharacters", "Gallery");
        SceneManager.LoadScene("gallery");
    }

    public void quitGame(){
        Application.Quit();
    }
}
