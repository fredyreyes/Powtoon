using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeScrollBar : MonoBehaviour
{
    public GameObject container;
    private RectTransform rt;
    private Scrollbar sb;
    private float scale;
    void Start()
    {
        rt = container.GetComponent<RectTransform>();
        sb = this.GetComponent<Scrollbar>();
        scale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        scale = (sb.value * 5) + 1;
        rt.localScale = new Vector3(scale, scale, 0);
    }
}
