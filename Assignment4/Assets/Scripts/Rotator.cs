﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rSpeed = 100f;

    public void AdjustSpeed(float newSpeed)
    {
        rSpeed = newSpeed;
    }

    void Update()
    {
        transform.Rotate(0f, 0f, rSpeed * Time.deltaTime);
    }
}
