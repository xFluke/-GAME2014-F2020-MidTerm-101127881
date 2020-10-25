/*
Source File: EnemyController.cs
Name: Miko Man
ID: 101127881
Date Last Modified: Oct 24 2020
Description: Controller Script for the Enemies.
Revision History:
    Oct 24: Modified script to work with landscape orientation
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float vertictalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= vertictalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -vertictalBoundary)
        {
            direction = 1.0f;
        }
    }
}
