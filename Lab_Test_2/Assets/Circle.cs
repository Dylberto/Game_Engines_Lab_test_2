using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public GameObject lights;
    public GameObject car;

    public int number_of_lights = 10;

    public float radius = 10f;


    void Start()
    {
        for (int i = 0; i < number_of_lights; i++)
        {
            float angle = i * Mathf.PI * 2 / number_of_lights;

            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;

            Vector3 pos = transform.position + new Vector3(x, 0, z);

            float angle_degrees = -angle * Mathf.Rad2Deg;

            Quaternion rotation = Quaternion.Euler(0, angle_degrees, 0);


            Instantiate(lights, pos, rotation);

           
        }

        Instantiate(car, transform.position, transform.rotation);
    }

}
