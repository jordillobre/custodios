using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectHeroe : MonoBehaviour{

    public void human(){
        PlayerPrefs.SetInt("charSel", 0);
        Debug.Log(PlayerPrefs.GetInt("charSel"));
        PlayerPrefs.SetInt("historyText", 1);
        SceneManager.LoadScene("history");
        PlayerPrefs.SetInt("humanSite", 0);
        PlayerPrefs.SetString("seeCharacters", "Inventory");
    }

    public void elf(){
        PlayerPrefs.SetInt("charSel", 1);
        Debug.Log(PlayerPrefs.GetInt("charSel"));
        PlayerPrefs.SetInt("historyText", 2);
        SceneManager.LoadScene("history");
        PlayerPrefs.SetInt("elfSite", 0);
        PlayerPrefs.SetString("seeCharacters", "Inventory");
    }

    public void dwarf(){
        PlayerPrefs.SetInt("dwarfnSite", 0);
        PlayerPrefs.SetInt("charSel", 2);
        Debug.Log(PlayerPrefs.GetInt("charSel"));
        PlayerPrefs.SetInt("historyText", 3);
        SceneManager.LoadScene("history");
        PlayerPrefs.SetString("seeCharacters", "Inventory");
    }
}
