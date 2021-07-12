using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manageTests : MonoBehaviour
{
    public GameObject tehlarissa;
    public GameObject tubraeg;
    public GameObject raimund;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("charSel") == 0)
        {
            tubraeg.SetActive(false);
            tehlarissa.SetActive(false);
            raimund.SetActive(true);
        }

        else if (PlayerPrefs.GetInt("charSel") == 1)
        {
            tubraeg.SetActive(false);
            tehlarissa.SetActive(true);
            raimund.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("charSel") == 2)
        {
            tubraeg.SetActive(true);
            tehlarissa.SetActive(false);
            raimund.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void passedTest()
    {
        SceneManager.LoadScene("nextSite");
    }
}
