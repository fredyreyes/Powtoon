using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSelect : MonoBehaviour
{
    public SelectObject image;
    public bool check;
    void Start()
    {
        check = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (image.select)
        {
            check = true;
        }
        else
        {
            check = false;
        }
    }
}
