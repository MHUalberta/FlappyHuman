// 2023-11-19 AI-Tag 
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float speed = 0.5f; // Adjust the speed as needed
    public float squareSize = 10f; // Adjust the size of the square as needed

    private Vector3[] waypoints;
    private int currentWaypointIndex;
    
    void Start()
    {
        // Define waypoints around the perimeter of the square
        waypoints = new Vector3[]
        {
            transform.position + new Vector3(0f, squareSize / 2f, squareSize / 2f),
            transform.position + new Vector3(0f, squareSize / 2f, -squareSize / 2f),
            transform.position + new Vector3(0f, -squareSize / 2f, -squareSize / 2f),
            transform.position + new Vector3(0f, -squareSize / 2f, squareSize / 2f)
        };

        // Start at the waypoint closest to the current position
        float shortestDistance = Mathf.Infinity;
        for (int i = 0; i < waypoints.Length; i++)
        {
            float distance = Vector3.Distance(transform.position, waypoints[i]);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                currentWaypointIndex = i;
            }
        }
    }

    void Update()
    {
        // Move towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex], speed * Time.deltaTime);

        // Check if the wall has reached the current waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex]) < 0.01f)
        {
            // Move to the next waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
