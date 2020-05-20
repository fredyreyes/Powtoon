using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAnimation : MonoBehaviour
{
    private Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
    }
    
    public void None()
    {
        anima.SetInteger("Anima", 0);
    }
    public void Anima1()
    {
        anima.SetInteger("Anima", 1);
    }
    public void Anima2()
    {
        anima.SetInteger("Anima", 2);
    }
    public void Anima3()
    {
        anima.SetInteger("Anima", 3);
    }
    public void Anima4()
    {
        anima.SetInteger("Anima", 4);
    }
    public void Anima5()
    {
        anima.SetInteger("Anima", 5);
    }
    public void Anima6()
    {
        anima.SetInteger("Anima", 6);
    }
}
