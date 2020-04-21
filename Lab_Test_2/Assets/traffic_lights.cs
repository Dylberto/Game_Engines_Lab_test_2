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

        if(state == 1)
        {
            StartCoroutine(go());
        }

        if(state == 2)
        {

            StartCoroutine(wait());

        }

        if(state == 3)
        {
            StartCoroutine(stop());
        }
    }

    IEnumerator go()
    {
        
            ren.material.color = green;
            gameObject.tag = "Target";
            yield return new WaitForSeconds(Random.Range(5, 11));
            StartCoroutine(wait());

    }

    IEnumerator wait()
    {
       
        
            ren.material.color = yellow;
            gameObject.tag = "Untagged";
            yield return new WaitForSeconds(4);
            StartCoroutine(stop());

        
    }

    IEnumerator stop()
    {
      
        
            ren.material.color = red;
            gameObject.tag = "Untagged";
            yield return new WaitForSeconds(Random.Range(5, 11));
            StartCoroutine(go());

        
    }




}