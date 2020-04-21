using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

    private float speed = 5;

    public GameObject[] targets;

    public Transform random_target;

    public Transform start_pos;
  
    private void Start()
    {
        start_pos = GameObject.FindGameObjectWithTag("Manager").transform;

        random_target = start_pos;
        
    }

    private void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");


        move();

        if(Vector3.Distance(transform.position, random_target.position) < 0.1f)
        {

            random_target = targets[Random.Range(0, targets.Length)].transform;
        }

    }

    void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, random_target.position, speed * Time.deltaTime);

        Vector3 direction = random_target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }


   
   
}
