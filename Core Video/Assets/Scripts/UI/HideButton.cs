using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HideButton : MonoBehaviour
{
    public SelectObject imageObject;
    public GameObject buttonTools;
    public GameObject buttonAnimations;

    public void Update()
    {
        if (imageObject.select && !PlayButton.state)
        {
            buttonTools.SetActive(true);
            buttonAnimations.SetActive(true);
        }
        else
        {
            buttonTools.SetActive(false);
            buttonAnimations.SetActive(false);
        }
    }

}
