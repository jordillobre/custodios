using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testController : MonoBehaviour {
    private int test;
    private int character;

    public GameObject tubraegBackgroud;
    public GameObject raimundBackgroud;
    public GameObject tehlarissaBackgroud;

    public Text titleTest;
    public Text descriptionTest;
    public Text hintTest;

    private string[] principiosVida = {
            "Vivir en la verdad para conquistar mi libertad",
            "Defender la justicia y luchar por un mundo nuevo",
            "Ser comprensivo con los demás y exigente conmigo mismo",
            "Fortalecer mi espíritu, para estar dispuesto a servir a Jesús y a mis hermanos"
        };

    private string poema;
    private string [,] adivinanzas;

    public RawImage jeroImage;
    public Texture[] jerogrificos;
    private string[] jeroSolucion = {"pepita", "casaca", "holanda", "me dio la tabarra", "te cagas" };

    public AudioClip[] cancionAdivinar;
    public string[] solucionesCancAdivinar = {"Ley Junior", "Oracion Junior", "Panyoletes i Crismons", "Quiero" };
    public AudioClip[] cancionCantar;
    public AudioSource audoSource;

    public bool playSong;


    private int numberSite;
    
    private string[,] gameTests = { {"Carrera de cangrejos", "Carrera de una punta a la otra de la plaza. Los miembros del equipo iran compitiendo por parejas hasta que solo quede 1 ganador. Como los cangrejos los jugadores deberan de correr de lado." },
                                     {"Poesia","Recita la poesia de Caminante no hay cmaino de Antonio Machado" },
                                     {"Adivina la cancion","Adivina el nombre de la siguiente cancion que esta sonando" },
                                     {"Canta","Canta libremente al compas de la musica que esta sonando" },
                                     {"Jerogglificos","Adivna el significado de los siguientes jeroglificos" },
                                     {"Mimica","Adivinar mediante mimica la siguiente frase:" },
                                     {"Nombres","Teneis que decir nombres de personas con cada letra del abecederia, cada nombre en menos de 10 segundo y en orden inverso del abecedario." },
                                     {"Adivinanzas y preguntas"," Tienes que adivinar las siguientes preguntas." },
                                     {"Oración junior","Tienes que recitar la oración junior pero unicamente usando una vocal." }};

    public string[] oracionJunior = 
            {"An al camaanza da ma javantad vay hacaa ta, Jasas. Qaaara marchar dacadada par al camana qaa ta ma marqaas, para qaa ma vada saa la qaa ta asparas da alla." +
            "Ta aras ma majar amaga; jantas marcharamas an aqaapa para qaa campartas canmaga al pan da la amastad y ma ansañas a darla ganarasamanta a mas hamanas. " +
            "Fartalaca ma valantad para vancar mas pasaanas, camplar saampra can ma dabar y sagaarta san cansarma can laaltad y alagraa.",

            "En el cemeenze de me jevented vey hecee te, Jeses. Qeeere mercher decedede per el cemene qee te me merqees, pere qee me vede see le qee te esperes de elle." +
            "Te eres me mejer emege; jentes mercheremes en eqeepe pere qee cempertes cenmege el pen de le emested y me enseñes e derle generesemente e mes hemenes. " +
            "Fertelece me velented pere vencer mes peseenes, cempler seempre cen me deber y segeerte sen censerme cen leelted y elegree.",

            "In il cimiinzi di mi jivintid viy hicii ti, Jisis. Qiiiri mirchir dicididi pir il cimini qii ti mi mirqiis, piri qii mi vidi sii li qii ti ispiris di illi." +
            "Ti iris mi mijir imigi; jintis mirchirimis in iqiipi piri qii cimpirtis cinmigi il pin di li imistid y mi insiñis i dirli ginirisiminti i mis himinis." +
            "Firtilici mi vilintid piri vincir mis pisiinis, cimplir siimpri cin mi dibir  y sigiirti sin cinsirmi cin liiltid y iligrii.",

            "On ol comoonzo do mo jovontod voy hocoo to, Josos. Qoooro morchor docododo por ol comono qoo to mo morqoos, poro qoo mo vodo soo lo qoo to osporos do ollo." +
            "To oros mo mojor omogo; jontos morchoromos on oqoopo poro qoo comportos conmogo ol pon do lo omostod y mo onsoños o dorlo gonorosomonto o mos homonos." +
            "Fortoloco mo volontod poro voncor mos posoonos, complor soompro con mo dobor y sogoorto son consormo con looltod y ologroo.",

            "Un ul cumuunzu du mu juvuntud vuy hucuu tu, Jusus. Quuuru murchur ducududu pur ul cumunu quu tu mu murquus, puru quu mu vudu suu lu quu tu uspurus du ullu." +
            "Tu urus mu mujur umugu; juntus murchurumus un uquupu puru quu cumpurtus cunmugu ul pun du lu umustud y mu unsuñus u durlu gunurusumuntu u mus humunus." +
            "Furtulucu mu vuluntud puru vuncur mus pusuunus, cumplur suumpru cun mu dubur y suguurtu sun cunsurmu cun luultud y ulugruu." };

    public int[] elfTest = { 3, 5, 7, 8, 2, 1, 0, 4, 6 };
    public int[] dwarfTest = { 3, 6, 4, 8, 7, 1, 2, 5, 0 };
    public int[] humanTest = { 5, 0, 6, 8, 4, 2, 1, 7, 3 };

    // Start is called before the first frame update
    void Start(){

        switch (PlayerPrefs.GetInt("charSel")){
            case 0:
                numberSite = PlayerPrefs.GetInt("humanSite");
                tubraegBackgroud.SetActive(false);
                tehlarissaBackgroud.SetActive(false);
                raimundBackgroud.SetActive(true);
                test = humanTest[numberSite];
                break;
            case 1:
                numberSite = PlayerPrefs.GetInt("elfSite");
                tubraegBackgroud.SetActive(false);
                tehlarissaBackgroud.SetActive(true);
                raimundBackgroud.SetActive(false);
                test = elfTest[numberSite];
                break;
            case 2:
                numberSite = PlayerPrefs.GetInt("dwarfnSite");
                tubraegBackgroud.SetActive(true);
                tehlarissaBackgroud.SetActive(false);
                raimundBackgroud.SetActive(false);
                test = dwarfTest[numberSite];
                break;
        }

        jeroImage.gameObject.SetActive(false);


        titleTest.text = gameTests[test, 0];
        descriptionTest.text = gameTests[test, 1];

        poema = "Caminante, son tus\n " +
            "huellas el camino y nada más;\n" +
            "Caminante, no hay camino,\n" +
            "se hace camino al andar.\n" +
            "Al andar se hace el camino,\n" +
            "y al volver la vista atrás\n" +
            "se ve la senda que nunca\n" +
            "se ha de volver a pisar.\n" +
            "Caminante no hay camino\n" +
            "sino estelas en la mar.";

        adivinanzas = new string[,] { { "Cuando comes soy baja, cuando meriendas soy alta y de ti me separo solo cuando saltas.", "La sombra"},
                                        { "¿Que hace una vaca cuando sale el sol?", "Sombra"},
                                        { "Redondo como la luna y blanco como la cal, me hacen con leche pura y ya no te digo mas", "Queso"},
                                        { "Un árbol con doce ramas, cada una con cuatro nidos, cada nido siete pájaros y cada cual su apellido.", "Año, meses, semanas y días"},
                                        { "Me llegan las cartas y no se leer, y aunque me las trago las se devolver", "Buzon"},
                                        { "Por el aire se cruzan un helicóptero y un avión. ¿Cómo se llaman los pilotos?", "Por radio"},
                                        { "Cuál es el animal que camina con las patas en la cabeza?", "El piojo"},
                                        { "Tengo ocho patas cargadas de ventosas y paseo por las rocas meciéndome en las olas. ¿Quién soy? ", "El pulpo"},
                                        { "De celda en celda voy pero presa no estoy.", "La abeja"},                                      
                                        { "Una vieja con un diente que llama a toda la gente.", "La campana"},                           
                                        { "¿Quién fue aquél genial marino que de pie mantuvo un huevo y descubrió un mundo nuevo por acortar un camino?", "Cristóbal Colón"},
                                        { "Lo dibuja el japones, lo hace el ladron y la tienes por duplicado en tu camisa y pantalon", "Manga"} };

        switch (test) {
            case 0:
                

                break;
            case 1:
                hintTest.text = poema;
                break;
            case 2:
                int song = Random.Range(0, 4);
                StartCoroutine(waitToPlayMusic());
                playSound(cancionAdivinar[song]);
                hintTest.text = solucionesCancAdivinar[song];
                break;
            case 3:
                int sing = Random.Range(0, 7);
                StartCoroutine(waitToPlayMusic());
                playSound(cancionCantar[sing]);
                break;
            case 4:
                jeroImage.gameObject.SetActive(true);
                int nJeroglific = Random.Range(0, 5);
                hintTest.text = jeroSolucion[nJeroglific];
                jeroImage.texture = jerogrificos[nJeroglific];
                break;
            case 5:
                int pVida = Random.Range(0,4);
                hintTest.text = principiosVida[pVida];

                break;
            case 6:
                break;
            case 7:
                int adivina = Random.Range(0, adivinanzas.Length);
                hintTest.text = adivinanzas[adivina, 0] + "\n" + adivinanzas[adivina, 1];
                break;
            case 8:
                int oracionLetra = Random.Range(0, 5);
                hintTest.text = oracionJunior[oracionLetra];
                break;

        }
    }

    void playSound(AudioClip clip){
        audoSource.loop = true;
        audoSource.clip = clip;
        audoSource.Play();
    }

    // Update is called once per frame
    private void Update(){
        
    }

    public void goToNextSite(){
        int numTest;
        Debug.Log("Aqui pasa algo");
        switch (PlayerPrefs.GetInt("charSel")){
            case 0:
                numTest = PlayerPrefs.GetInt("humanSite") + 1;
                PlayerPrefs.SetInt("humanSite", numTest);
                break;
            case 1:
                numTest = PlayerPrefs.GetInt("elfSite") + 1;
                PlayerPrefs.SetInt("elfSite", numTest);
                break;
            case 2:
                numTest = PlayerPrefs.GetInt("dwarfnSite") + 1;
                PlayerPrefs.SetInt("dwarfnSite", numTest);
                break;
        }
        if (numberSite == 8){
            //cargar historia final player.prefs

            PlayerPrefs.SetInt("historyText", 4);
            SceneManager.LoadScene("history");
        }
        else{
            SceneManager.LoadScene("nextSite");
        }
        
    }

    IEnumerator waitToPlayMusic(){
        yield return new WaitForSeconds(5);
    }
}
