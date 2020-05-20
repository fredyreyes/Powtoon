using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    private int toogle;
    void Start()
    {
        toogle = 0;
    }

    private void Update()
    {
        ToogleButton();
    }

    public void ToogleButton()
    {
        if(toogle == 1)
        {
            PlayButton.state = true;
        }
        else
        {
            PlayButton.state = false;
        }
    }

    public void Increment()
    {
        toogle = toogle + 1;

        if (toogle > 1)
        {
            toogle = 0;
        }
    }
    
}
