using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HideScrollbar : MonoBehaviour
{
   
    public GameObject slidingArea;
    public CheckSelect miObject;
    private bool onScrollbar;

    private void Start()
    {
        onScrollbar = true;
    }

    private void Update()
    {
        if(miObject.check == true && onScrollbar == true)
        {
            slidingArea.SetActive(true);
        }
        else
        {
            slidingArea.SetActive(false); // preferible hacer imagen invisible
        }
    }
      
    // Call for button
    public void Activate()
    {
        onScrollbar = true;
    }
    public void EnableObject()
    {
        this.gameObject.SetActive(true);
    }

}
      
