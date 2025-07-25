using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

    public Transform[] waypoints;
    public float moveSpeed = 5f;
    public float rotSpeed = 2f;
    public float minDistance = 0.1f;
    public bool isLooping = true;

    private int currentWaypointIndex = 0;
    private float currentDistance;

    void Update () {
        if (waypoints.Length == 0) {
            return;
        }

        // Rotate towards current waypoint
        Vector3 direction = waypoints[currentWaypointIndex].position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotSpeed);

        // Move towards current waypoint
        currentDistance = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);
        if (currentDistance < minDistance) {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length) {
                if (isLooping) {
                    currentWaypointIndex = 0;
                } else {
                    enabled = false;
                }
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, Time.deltaTime * moveSpeed);
    }
}
