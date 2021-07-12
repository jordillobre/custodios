using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using LitJson;


public class changeHero : MonoBehaviour {
    private JsonData elfData;
    private JsonData dwarfData;
    private JsonData humanData;

    public Text nameHeroe;
    public GameObject tubraeg;
    public GameObject [] tubraegObject;

    public GameObject tehlarissa;
    public GameObject[] tehlarissaObject;

    public GameObject raimund;
    public GameObject[] raimundObject;

    private string elfEquipJson;
    private string humanEquipJson;
    private string dwarfEquipJson;

    public GameObject changeHeroMenu;

    public void nextHero() {
        PlayerPrefs.SetInt("charView", PlayerPrefs.GetInt("charView") + 1);
        if (PlayerPrefs.GetInt("charView") > 2)
        {
            PlayerPrefs.SetInt("charView", 0);
        }
    }

    public void prevHero(){
        PlayerPrefs.SetInt("charView", PlayerPrefs.GetInt("charView") - 1);
        if (PlayerPrefs.GetInt("charView") < 0){
            PlayerPrefs.SetInt("charView", 2);
        }
    }

    private void Start(){
        elfEquipJson = File.ReadAllText(Application.dataPath + "/scripts/equipmentElf.json");
        humanEquipJson = File.ReadAllText(Application.dataPath + "/scripts/equipmentHuman.json");
        dwarfEquipJson = File.ReadAllText(Application.dataPath + "/scripts/equipmentDwarf.json");

        elfData = JsonMapper.ToObject(elfEquipJson);
        dwarfData = JsonMapper.ToObject(dwarfEquipJson);
        humanData = JsonMapper.ToObject(humanEquipJson);


        if (PlayerPrefs.GetString("seeCharacters") == "Gallery"){

        }
        else if (PlayerPrefs.GetString("seeCharacters") == "Inventory"){
            changeHeroMenu.SetActive(false);
            switch (PlayerPrefs.GetInt("charSel")){
                case 0:
                    showHuman();
                    break;
                case 1:
                    showElf();
                    break;
                case 2:
                    showDwarf();
                    break;
                default:
                    break;
            }
        }

    }

    private void Update(){
        if (PlayerPrefs.GetString("seeCharacters") == "Gallery"){
            switch (PlayerPrefs.GetInt("charSel")){
                case 0:
                    showHuman();
                    break;
                case 1:
                    showElf();
                    break;
                case 2:
                    showDwarf();
                    break;
                default:
                    break;
            }
        }
    }

    public void returnHome(){
        if (PlayerPrefs.GetString("seeCharacters") == "Gallery"){
            SceneManager.LoadScene("mainMenu");
        }
        else if (PlayerPrefs.GetString("seeCharacters") == "Inventory") {
            SceneManager.LoadScene("map");
        }


    }

    private void showDwarf(){
        nameHeroe.text = "Tubraeg";
        tehlarissa.SetActive(false);
        raimund.SetActive(false);
        tubraeg.SetActive(true);
        for (int i = 0; i < 8; i++){
            showPart(tubraegObject[i], 2, i);
        }
    }

    private void showHuman(){
        nameHeroe.text = "Raimund";
        tehlarissa.SetActive(false);
        raimund.SetActive(true);
        tubraeg.SetActive(false);
        for (int i = 0; i < 8; i++){
            showPart(raimundObject[i], 0, i);
        }
    }

    private void showElf(){
        nameHeroe.text = "Tehlarissa";
        tehlarissa.SetActive(true);
        raimund.SetActive(false);
        tubraeg.SetActive(false);
        for(int i = 0; i <8; i++){
            showPart(tehlarissaObject[i], 1, i);
        }
    }


    private void showPart(GameObject objectShow, int character, int index){
        bool status;
         switch (character){
            case 0:
                status = (bool)humanData["statusEquipment"][index]["adquired"];
                Debug.Log(index + "" + (bool)humanData["statusEquipment"][index]["adquired"]);
                objectShow.SetActive(status);
                 break;
             case 1:
                 status = (bool)elfData["statusEquipment"][index]["adquired"];
                Debug.Log(index + "" + (bool)elfData["statusEquipment"][index]["adquired"]);
                objectShow.SetActive(status);
                 break;
             case 2:
                status = (bool)dwarfData["statusEquipment"][index]["adquired"];
                Debug.Log(index + "" + (bool)dwarfData["statusEquipment"][index]["adquired"]);
                objectShow.SetActive(status);
                 break;
            default:
                break;
         }

    }
}
