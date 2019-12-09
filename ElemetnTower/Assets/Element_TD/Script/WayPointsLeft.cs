﻿using UnityEngine;

public class WayPointsLeft : MonoBehaviour
{

    public static Transform[] Leftpoints;

    void Awake()
    {
        Leftpoints = new Transform[transform.childCount];
        for (int i = 0; i < Leftpoints.Length; i++)
        {
            Leftpoints[i] = transform.GetChild(i);
        }
    }

}