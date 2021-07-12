using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchController : MonoBehaviour{

    public GameObject [] objectsSite;

    string objectSelected;

    // Start is called before the first frame update
    void Start(){
        switch (PlayerPrefs.GetInt("charSel")){
            case 0:
                objectsSite[0].SetActive(true);
                objectsSite[1].SetActive(false);
                objectsSite[2].SetActive(false);
                break;
            case 1:
                objectsSite[0].SetActive(false);
                objectsSite[1].SetActive(true);
                objectsSite[2].SetActive(false);
                break;
            case 2:
                objectsSite[0].SetActive(false);
                objectsSite[1].SetActive(false);
                objectsSite[2].SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update(){
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit)){
                objectSelected = Hit.transform.name;
                switch (objectSelected){
                    case "volund":
                        PlayerPrefs.SetString("object", "Weapon");
                        goTest();
                        break;
                    case "espadaElfa":
                        PlayerPrefs.SetString("object", "Weapon");
                        goTest();
                        break;
                    case "zirael":
                        PlayerPrefs.SetString("object", "Weapon");
                        goTest();
                        break;

                    case "cascoHumano":
                        PlayerPrefs.SetString("object", "Helmet");
                        goTest();
                        break;
                    case "cascoElfa":
                        PlayerPrefs.SetString("object", "Helmet");
                        goTest();
                        break;
                    case "cascoEnano":
                        PlayerPrefs.SetString("object", "Helmet");
                        goTest();
                        break;

                    case "escudoHumano":
                        PlayerPrefs.SetString("object", "Shield");
                        goTest();
                        break;
                    case "escudoElfa":
                        PlayerPrefs.SetString("object", "Shield");
                        goTest();
                        break;
                    case "escudoEnano":
                        PlayerPrefs.SetString("object", "Shield");
                        goTest();
                        break;

                    case "grebasElfa":
                        PlayerPrefs.SetString("object", "Greba");
                        goTest();
                        break;
                    case "grebasEnano":
                        PlayerPrefs.SetString("object", "Greba");
                        goTest();
                        break;
                    case "grebasHumano":
                        PlayerPrefs.SetString("object", "Greba");
                        goTest();
                        break;

                    case "mallarHumano":
                        PlayerPrefs.SetString("object", "Faldar");
                        goTest();
                        break;
                    case "mallarEnano":
                        PlayerPrefs.SetString("object", "Faldar");
                        goTest();
                        break;

                    case "pecheraHumano":
                        PlayerPrefs.SetString("object", "Cruise");
                        goTest();
                        break;
                    case "pecheraElfa":
                        PlayerPrefs.SetString("object", "Cruise");
                        goTest();
                        break;
                    case "pecheraEnano":
                        PlayerPrefs.SetString("object", "Cruise");
                        goTest();
                        break;

                    case "hombreraHumano":
                        PlayerPrefs.SetString("object", "Hombreras");
                        goTest();
                        break;
                    case "hombreraElfa":
                        PlayerPrefs.SetString("object", "Hombreras");
                        goTest();
                        break;
                    case "hombreraEnano":
                        PlayerPrefs.SetString("object", "Hombreras");
                        goTest();
                        break;

                    case "avambrazoEnano":
                        PlayerPrefs.SetString("object", "Avambrazo");
                        goTest();
                        break;
                    case "avambrazoHumano":
                        PlayerPrefs.SetString("object", "Avambrazo");
                        goTest();
                        break;
                    case "avambrazoElfa":
                        PlayerPrefs.SetString("object", "Avambrazo");
                        goTest();
                        break;

                    case "estandarteHumano":
                        goTest();
                        break;
                    case "estandarteElfa":
                        goTest();
                        break;
                    case "estandarteEnano":
                        goTest();
                        break;

                    default:
                        break;
                }

            }
        }
    }

    void goTest(){
        SceneManager.LoadScene("test");
    }
}
