using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonPrincipal : MonoBehaviour
{
    public SelectObject check;
    public GameObject button;
    public GameObject panelCategory;  
    private string namePanelCategory;
    private bool select;
    void Start()
    {
        select = false;
        IdScrollbar.idName = "Panel";     //Start Button active
        namePanelCategory = panelCategory.name;         
    }  

    // Update is called once per frame
    void Update()
    {
        if(check.select && !PlayButton.state)
        {
            if(!panelCategory.activeSelf)
            {
                button.SetActive(true);
            }
            else
            {
                button.SetActive(false);
            }
        }
        else
        {
            button.SetActive(false);
        }

        if (select == true && check.select && PlayButton.state == false)
        {
            if (IdPanel.name == namePanelCategory)
            {
                panelCategory.SetActive(true);
            }
            else
            {
                panelCategory.SetActive(false);
            }               
        }

        else
        {
            select = false;            
            panelCategory.SetActive(false);
        }
    }

    public void OnCategory()
    {
        select = true;
        IdPanel.name = namePanelCategory;
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
