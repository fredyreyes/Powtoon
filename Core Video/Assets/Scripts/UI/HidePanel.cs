using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanel : MonoBehaviour
{
    
    public GameObject panelEnter;
    public GameObject panelAnimation;
    public GameObject panelExit;
    public CheckSelect image;
    private bool state1, state2, state3;
    public bool state;

    private void Start()
    {
        state1 = false;
        state2 = false;
        state3 = false;
        state = false;
    }


    private void Update()
    {
        if(!PlayButton.state && image.check && state==true)
        {
            if (state1)
            {
                panelEnter.SetActive(true);
            }
            if (state2)
            {
                panelAnimation.SetActive(true);
            }
            if (state3)
            {
                panelExit.SetActive(true);
            }
        }
        else
        {
            state = false;
            panelEnter.SetActive(false);
            panelAnimation.SetActive(false);
            panelExit.SetActive(false);
        }
    }

    public void onEnter()
    {
        state = true;
        state1 = true;
        state2 = false;
        state3 = false;
    }

    public void onAnimation()
    {
        state = true;
        state1 = false;
        state2 = true;
        state3 = false;
    }
    public void onExit()
    {
        state = true;
        state1 = false;
        state2 = false;
        state3 = true;
    }

    public void DisablePanel()
    {
        
        state = false;      
    }

}
