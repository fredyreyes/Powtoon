using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{
    public GameObject image;
    public Canvas canvas;
    private int order,counter;
    private TextMeshProUGUI text;
   
    void Start()
    {
        canvas = image.GetComponent<Canvas>();
        order = canvas.sortingOrder;
        text = GetComponent<TextMeshProUGUI>();
        counter = 0;
    }

    void Update()
    {
        canvas.sortingOrder = order + counter;
        text.text = "" + canvas.sortingOrder;
    }

    public void UpLayer()
    {
        if (counter < 30)
        {
          counter = counter + 1;
        }
        
    }
    public void DownLayer()
    {
        if (counter > -30)
        {
            counter = counter - 1;
        }          
    }
}
