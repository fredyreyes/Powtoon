using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CallObject : MonoBehaviour
{
    public GameObject callObject;
    private string name;
    private int repeat;
    void Start()
    {
        if(callObject != null)
        {
            name = callObject.name;
        }
        repeat = 0;
        
    }

    public void Generate()
    {
        repeat = repeat + 1;
        if (callObject != null)
        {
           
            Instantiate(callObject, transform.position, transform.rotation);
            callObject.name =""+repeat;
        }
        else
        {
            Debug.Log("Object Null");
        }
        
    }   
}
