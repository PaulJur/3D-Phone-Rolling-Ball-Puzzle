using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private WaypointPathing _waypoint;

    [SerializeField]
    private float _speed;

    private int _targetWaypointIndex;

    private Transform _lastWaypoint;
    private Transform _targetWaypoint;

    private float _timeTowardsWaypoint;
    private float _elapsedTime;
#endregion

    // Start is called before the first frame update
    void Start()
    {
        NextWaypoint();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _elapsedTime+=Time.deltaTime;

        //calculates how much of the path is moved

        float elapsedPercnt = _elapsedTime / _timeTowardsWaypoint;
        //slows down at the start and end of the waypoints for player to jump on platform
        elapsedPercnt = Mathf.SmoothStep(0, 1, elapsedPercnt);
        //Moves from first waypoint index to the next waypoint index
        transform.position = Vector3.Lerp(_lastWaypoint.position, _targetWaypoint.position, elapsedPercnt);

        //Elapsed time: 0= at first waypoint if Elapsed time 0.5=half way towards next waypoint and 1=at waypoint

        if (elapsedPercnt >= 1)
        {
            NextWaypoint();
        }
    }

    private void NextWaypoint()
    {
        //Previous waypoint becomes first then target waypoint becomes the next path.

        //Gets the position of the last waypoint(1)
        _lastWaypoint = _waypoint.getWaypoint(_targetWaypointIndex);
        //Holds the index towards the next platform
        _targetWaypointIndex=_waypoint.getNextWaypoint(_targetWaypointIndex);
        //Gets the position of the next waypoint(2)
        _targetWaypoint = _waypoint.getWaypoint(_targetWaypointIndex);

        _elapsedTime = 0;

        float distanteToWaypoint = Vector3.Distance(_lastWaypoint.position, _targetWaypoint.position);
        _timeTowardsWaypoint = distanteToWaypoint / _speed;
    }

}
