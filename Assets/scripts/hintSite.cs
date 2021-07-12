using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
using System.Linq;

public class hintSite : MonoBehaviour{
    public GameObject tubraeg;
    public GameObject tehlarissa;
    public GameObject raimund;

    public Text site;

    private int numberSite;

    public int[] humanSites = { 5, 4, 7, 8, 10, 9, 12, 11, 0 };
    public int[] elfSites = { 13, 15, 17, 9, 10, 4, 7, 1, 0 };
    public int[] dwarfSites = { 1, 2, 6, 9, 15, 18, 14, 16, 0 };

    public string[] sitesToGo = { "Lugar donde normalmente realizamos las sesiones",
                                "Su construccion fue por orden de Mosen Melchor Hierro",
                                "Lugar donde algunas veces hemos hecho las juegos populares",
                                "Sitio donde se suele lavar la ropa",
                                "Lugar donde se realiza fiesta el segundo domingo de mayo",
                                "Lugar de una fortaleza donde se realiza vigilancia",
                                "Fuente discreta que se confunde con una hornacina santoral",
                                "Lugar desde donde podemos contemplar una de las entradas del pueblo",
                                "Calle en honor a una antiguo cargo del pueblo", 
                                "Lugar donde Sant Blai fue hecho patron",
                                "Una de las calles donde más cerca se encuentran una casa de la otra",
                                "Plaza que tiene el nombre de una pieza arqueologica encontrada en los terrenos del pueblo",
                                "Lugar donde puedes aparcar cuando vas a la iglesia",
                                "Antigua puerta de acceso al barrio Medieval",
                                "Parque donde podemos encontrar información sobre la ruta de Jaume I",
                                "Lugar donde se encuentra una fuente que era sitio de descanso antes de acceder a la iglesia",
                                "Parque donde hay un antiguo depósito medieval",
                                "Una ermita la cual fue construida después de la reconquista de Jaume I",
                                "Sitio por donde se podía acceder al pueblo",
                                "Lugar desde donde podemos ver les covetes del moros",
                                "Esta hecha en honor de Nuestra Señora de la Asuncion",
                                "Lugar de acceso al pueblo mas antiguo"};

    // Start is called before the first frame update
    void Start(){
        switch (PlayerPrefs.GetInt("charSel")){
            case 0:
                tubraeg.SetActive(false);
                tehlarissa.SetActive(false);
                raimund.SetActive(true);
                break;
            case 1:
                tubraeg.SetActive(false);
                tehlarissa.SetActive(true);
                raimund.SetActive(false);
                break;
            case 2:
                tubraeg.SetActive(true);
                tehlarissa.SetActive(false);
                raimund.SetActive(false);
                break;
        }

    }

    // Update is called once per frame
    void Update(){
        switch (PlayerPrefs.GetInt("charSel")){
            case 0:
                numberSite = humanSites[PlayerPrefs.GetInt("humanSite")];
                site.text = sitesToGo[numberSite];
                break;
            case 1:
                numberSite = elfSites[PlayerPrefs.GetInt("elfSite")];
                site.text = sitesToGo[numberSite];
                break;
            case 2:
                numberSite = dwarfSites[PlayerPrefs.GetInt("dwarfnSite")];
                site.text = sitesToGo[numberSite];
                break;
        }
    }

    public void continueGame(){
        SceneManager.LoadScene("camera");
    }
}
