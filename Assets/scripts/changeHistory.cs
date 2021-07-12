using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Linq;

public class changeHistory : MonoBehaviour
{

    public Text history;
    string file;
    string fileDirectory;
    string fileRead;

    public void Start(){
        readText();
        history.text = fileRead;
    }

    public void readText(){
        if (PlayerPrefs.GetInt("historyText") == 0){
            file = "startHistory.txt";
        }

        if (PlayerPrefs.GetInt("historyText") == 3){
            file = "tubraegHistory.txt";
        }
        else if (PlayerPrefs.GetInt("historyText") == 2){
            file = "tehlarissaHistory.txt";
        }
        else if (PlayerPrefs.GetInt("historyText") == 1){
            file = "raimundHistory.txt";
        }
        else if (PlayerPrefs.GetInt("historyText") == 4){
            file = "finalHistoryfile.txt";
        }

        fileDirectory = Application.dataPath + "/text/" + file;

        List<string> filelines = File.ReadAllLines(fileDirectory).ToList();

        foreach (string line in filelines){
            fileRead += line + "\n";
        }
    }

}