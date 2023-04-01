using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPathing : MonoBehaviour
{
    public Transform getWaypoint(int index)
    {
        //Returns child positions
        return transform.GetChild(index);
    }

    public int getNextWaypoint(int currentIndex)
    {

        int nextWaypoint = currentIndex + 1;

        //if the target index reaches the childcount, it resets
        if (nextWaypoint == transform.childCount)
        {
            nextWaypoint = 0;
        }
        return nextWaypoint;
    }

}
