using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    string playerName = NameTransfer.theName;
    public GameObject displayText;



    public void Start ()
    {
        displayText.GetComponent<Text>().text = "PLayer: " + playerName;
    }

    
}
