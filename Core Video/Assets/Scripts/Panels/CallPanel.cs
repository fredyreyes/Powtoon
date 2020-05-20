using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallPanel : MonoBehaviour
{
    public bool select;
    public CheckSelect miObject;
    public GameObject panelTools;
    public GameObject panelAnimations;
    private string namePanelTools,namePanelAnimations;
    void Start()
    {
        select = false;
        namePanelTools = panelTools.name;
        namePanelAnimations = panelAnimations.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (select == true && miObject.check && PlayButton.state == false)
        {
            if(IdPanel.name == namePanelTools)
            {
                panelTools.SetActive(true);
            }
            else
            {
                panelTools.SetActive(false);
            }

            if(IdPanel.name == namePanelAnimations)
            {
                panelAnimations.SetActive(true);
            }
            else
            {
                panelAnimations.SetActive(false);
            }
        }

        else
        {
            select = false;
            panelAnimations.SetActive(false);
            panelTools.SetActive(false);
        }
    }

    public void OnTools()
    {         
        select = true;
        IdPanel.name = namePanelTools;
    }
    public void OnAminations()
    {
        select = true;
        IdPanel.name = namePanelAnimations;
    }

    public void HidePanel()
    {
        select = false;
    }
    public void ViewPanel()
    {
        select = true;
    }
    
}
