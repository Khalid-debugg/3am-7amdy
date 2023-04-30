using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillatingBehaviour : MonoBehaviour
{
    
    [SerializeField] GameObject[] waypoints;
    int currentWayPoint = 0;

    [SerializeField] float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWayPoint].transform.position) < .2f) 
        {
            currentWayPoint = (currentWayPoint+1) % waypoints.Length ; 
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPoint].transform.position, speed * Time.deltaTime);
    }
}
