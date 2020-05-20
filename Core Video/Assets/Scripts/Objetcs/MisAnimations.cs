using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MisAnimations : MonoBehaviour
{
    private Animator anima;
    private Image image;      
    public TimeHandle myScrollBar;
    private float timeAnimation,timeFinal;
    
    void Start()
    {
        anima = GetComponent<Animator>();
        image = GetComponent<Image>();
    }

    private void Update()
    {
        anima.SetBool("Play", PlayButton.state);
        timeAnimation = TimeGeneral.time-myScrollBar.timeStart;   //Time inicial animation  
        timeFinal = TimeGeneral.time - myScrollBar.timeFinish;
        anima.SetFloat("Ti", timeAnimation);                      // Conect with animation
        anima.SetFloat("Tf", timeFinal);

        StateImage();     // Before and After to animation
    }

    private void StateImage()
    {    
        //PAUSE ANIMATION
        if (PlayButton.state)
        {
            anima.speed = 1.0f;
        }
        else
        {
            anima.speed = 0.0f;                
        }        
        // BEFORE ANIMATION
        if(PlayButton.state && timeAnimation < 0)
        {
            image.enabled = false;
        }
        //INTO ANIMATION
        if(PlayButton.state && timeAnimation > 0.001f && timeFinal < 0)     //DelayTransation .001f
        {
            image.enabled = true;
        }
        //AFTER ANIMATION
        if(PlayButton.state && timeFinal > 0.01)                        //One seconds for disable object
        {
            image.enabled = false;
        }
        // STOP PLAY
        if (!PlayButton.state)
        {
            image.enabled = true;  
        }
        //START ANIMATION
        if(!PlayButton.state && timeAnimation < 0)
        {
            anima.Play("GO");
        }
    }
    public void ResetAnimation()
    {
        //Into animation
        if (!PlayButton.state && timeAnimation > 0.001f && timeFinal < 0)     //DelayTransation .001f
        {
          anima.SetTrigger("Reset");           
        }     
    }
}
