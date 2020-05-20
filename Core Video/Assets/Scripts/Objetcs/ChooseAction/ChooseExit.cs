using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseExit : MonoBehaviour
{
    private Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    public void None()
    {
        anima.SetInteger("Exit", 0);
    }
    public void Exit1()
    {
        anima.SetInteger("Exit", 1);
    }
    public void Exit2()
    {
        anima.SetInteger("Exit", 2);
    }
    public void Exit3()
    {
        anima.SetInteger("Exit",3);
    }
    public void Exit4()
    {
        anima.SetInteger("Exit", 4);
    }
    public void Exit5()
    {
        anima.SetInteger("Exit", 5);
    }
    public void Exit6()
    {
        anima.SetInteger("Exit", 6);
    }
}
