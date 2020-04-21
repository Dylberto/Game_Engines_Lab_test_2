using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traffic_lights : MonoBehaviour
{
    private Renderer ren;

    public int state;
    public int new_state;

    private Color green = new Color(0, 255, 0);
    private Color yellow = new Color(255, 255, 0);
    private Color red = new Color(255, 0, 0);



    void Start()
    {
        ren = gameObject.GetComponent<Renderer>();

        state = Random.Range(1, 4);

    }

    void Update()
    {
        go();

        wait();

        stop();

    }

    void go()
    {
        if (state == 1)
        {
            ren.material.color = green;

            gameObject.tag = "Target";
        }

    }

    void wait()
    {
        if (state == 2)
        {
            ren.material.color = yellow;
            gameObject.tag = "Untagged"; 


        }


    }

    void stop()
    {
        if (state == 3)
        {
            ren.material.color = red;
            gameObject.tag = "Untagged";
        }


    }


 

}