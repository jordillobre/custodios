using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class statusEquipment : MonoBehaviour
{
    public TextAsset raimundEquipment;
    public TextAsset tubraegEquipment;
    public TextAsset tehlarissaEquipment;


    [System.Serializable]
    public class status{
        public string part;
        public bool adquired;

    }

    [System.Serializable]
    public class listStatus{
        public status[] statusEquipmentElf;
    }

    public listStatus statusEquip = new listStatus();
    private void Start()
    {
        statusEquip = JsonUtility.FromJson<listStatus>(raimundEquipment.text);
    }

    /*public bool returnPart(string part){
        bool cosa;
        foreach (price in statusEquipment)
         {
             if (statusEquipment[0].part == part)
             {
                 cosa = statusEquipment.
             }
         }
         
        return statusEquipment[0];
    }*/
}