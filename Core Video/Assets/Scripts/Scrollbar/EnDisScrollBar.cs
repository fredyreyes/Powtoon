using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnDisScrollBar : MonoBehaviour
{
    public GameObject enter;     

    public void EnableEnter()
    {
        enter.SetActive(true);
    }
 
    public void DisableEnter()
    {
        enter.SetActive(false);
    }  
}
