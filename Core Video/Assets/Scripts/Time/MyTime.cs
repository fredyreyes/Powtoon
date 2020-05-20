using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTime : MonoBehaviour
{
    private Scrollbar scTime;
        
    void Start()
    {           
        scTime = this.GetComponent<Scrollbar>();
    }
        
    void Update()
    {
        if (PlayButton.state)
        {                          
            scTime.value += Time.deltaTime / 100;
        }    
        TimeGeneral.time = scTime.value;     
    }
}
