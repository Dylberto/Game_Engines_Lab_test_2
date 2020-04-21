using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traffic_lights : MonoBehaviour
{
    private Renderer ren;

    private int start_color;


    void Start()
    {
        ren = gameObject.GetComponent<Renderer>();

        start_color = Random.Range(1 ,4);
    }

    void Update()
    {
        if(start_color == 1f)
        {
            ren.material.color = new Color(0, 255, 0);
        }

        if(start_color == 2f)
        {
            ren.material.color = new Color(255, 255, 0);
        }

        if (start_color == 3f)
        {
            ren.material.color = new Color(255, 0, 0);
        }

    }

}
