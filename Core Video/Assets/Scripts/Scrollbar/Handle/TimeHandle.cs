using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandle : MonoBehaviour
{
    private Scrollbar scrollbar;
    public float timeStart;
    public float timeFinish;
    public float myTime;       //Reloj Principal
    private float size;
    void Start()
    {
        timeStart = 0f;
        timeFinish = 0f;      
        scrollbar = this.gameObject.GetComponent<Scrollbar>();
        scrollbar.value = 0f;
        scrollbar.size = 0.01f;
        size = scrollbar.size/2;
    }

    // Update is called once per frame
    void Update()
    {
        size = scrollbar.size / 2;
        TimeStart();
        TimeFinish();
        Desface();
    }

    private void TimeStart()
    {

        timeStart = myTime-size ;  
    }

    private void TimeFinish()
    {
       timeFinish = myTime+size ;
    }

    private void Desface()
    {
        myTime = (scrollbar.value*(1-scrollbar.size)) + size;  //Formula   
    }
}
