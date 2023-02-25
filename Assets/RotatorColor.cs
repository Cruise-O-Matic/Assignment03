using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorColor : MonoBehaviour
{
    public static Dropdown RotateColor;

    public Text ColorText;
    public GameObject Rotator;

    // Start is called before the first frame update
    void Start()
    {
        Rotator.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (RotateColor.value)
        {
            case 1:
                ColorText.text = RotateColor.options[1].text;
                Rotator.GetComponent<Renderer>().material.color = Color.red;
                break;
           case 2:
                ColorText.text = RotateColor.options[3].text;
                Rotator.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                ColorText.text = RotateColor.options[0].text;
                Rotator.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
}
