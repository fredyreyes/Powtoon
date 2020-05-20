using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 //NO USE!!!!
public class HideTools : MonoBehaviour
{
    public SelectObject imageObject;
    public GameObject tools;
    private bool onTools;

    private void Start()
    {
        onTools = false;
    }

    private void Update()
    {
       
        if (imageObject.select == true && onTools == true)
        {
            tools.SetActive(true);
        }
        else
        {
            tools.SetActive(false);
            onTools = false;
        }
    }

    public void Menu()       //Call for the button
    {
        onTools = true;
    }
}
