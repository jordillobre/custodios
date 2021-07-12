using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class sites : MonoBehaviour
{
    string filePath;
    string jsonstring;

    private void Awake()
    {
        filePath = Application.dataPath + "/sites.json";
        jsonstring = File.ReadAllText(filePath);
        listSite listSites = JsonUtility.FromJson<listSite>(jsonstring);
    }
}

[System.Serializable]
public class site{

    public string name;
    public float longit;
    public float lati;
    public string descripcion;

}

[System.Serializable]
public class listSite{

    public List<site> sites;
}