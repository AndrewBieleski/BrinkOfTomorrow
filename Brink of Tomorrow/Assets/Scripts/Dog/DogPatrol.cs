    using UnityEngine;
    using UnityEngine.AI;
    using System.Collections;


    public class DogPatrol : MonoBehaviour
    {

    public DogWaypoint[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private DogWaypoint currentTarget;

    private Vector3 direction;
    public float dogSpeed;
    private bool alive = true;


    void FixedUpdate()
    {
        if (alive) {
            direction = Vector3.zero;
            //get the vector from your position to current waypoint
            direction = points[destPoint].transform.position - transform.position;
            //check our distance to the current waypoint, Are we near enough?
            if (direction.magnitude < 1) {
                alive = points[destPoint].arrived();
                if (points.Length == 0)
                    return;
                if (destPoint < points.Length - 1) //switch to the nex waypoint if exists
                {
                    if (alive) {
                        destPoint++;
                    }
                }
            }
            direction = direction.normalized;
            Vector3 dir = direction;

            GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x * dogSpeed, direction.y * dogSpeed);
        }
    }
}