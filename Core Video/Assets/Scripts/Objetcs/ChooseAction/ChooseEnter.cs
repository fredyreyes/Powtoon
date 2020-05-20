using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseEnter : MonoBehaviour
{
    private Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    public void None()
    {
        anima.SetInteger("Enter", 0);
    }
    public void Enter1()
    {
        anima.SetInteger("Enter", 1);
    }
    public void Enter2()
    {
        anima.SetInteger("Enter", 2);
    }
    public void Enter3()
    {
        anima.SetInteger("Enter", 3);
    }
    public void Enter4()
    {
        anima.SetInteger("Enter", 4);
    }
    public void Enter5()
    {
        anima.SetInteger("Enter", 5);
    }
    public void Enter6()
    {
        anima.SetInteger("Enter", 6);
    }
}
