using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPanel : MonoBehaviour
{
    public SelectObject check;
    public GameObject[] panels;    
    private bool state;
    private int idPanel;
    void Start()
    {
       state = false;       
    }

    private void Update()
    {
        if (state && !PlayButton.state && check.select)
        {
            //Any action
        }
        else
        {
            state = false;
            PanelDesactivate();
        }
    }

    // Update is called once per frame
    public void MyUpdate()
    {
         if(state && !PlayButton.state && check.select)
        {
            PanelActivate(idPanel);
        }
        else
        {
            state = false;
            PanelDesactivate();
        }
    }

    private void PanelActivate(int id)
    {
         for(int j =0; j< panels.Length; j++)
        {
            panels[j].SetActive(false);
        }
        panels[id].SetActive(true);
    }

    private void PanelDesactivate()
    {
        for (int j = 0; j < panels.Length; j++)
        {
            panels[j].SetActive(false);
        }
    }   

    //CALL FOR THE BUTTON
    public void Panel0()
    {
        idPanel = 0;
        state = true;
    }

    public void Panel1()
    {
        idPanel = 1;
        state = true;
    }

    public void Panel2()
    {
        idPanel = 2;
        state = true;
    }

    public void Panel3()
    {
        idPanel = 3;
        state = true;
    }

    public void Panel4()
    {
        idPanel = 4;
        state = true;
    }

    public void Panel5()
    {
        idPanel = 5;
        state = true;
    }

    public void Panel6()
    {
        idPanel = 6;
        state = true;
    }

    public void Panel7()
    {
        idPanel = 7;
        state = true;
    }

    public void Panel8()
    {
        idPanel = 8;
        state = true;
    }

    public void Panel9()
    {
        idPanel = 9;
        state = true;
    }

    public void Panel10()
    {
        idPanel = 10;
        state = true;
    }
    public void Panel11()
    {
        idPanel = 11;
        state = true;
    }
}
