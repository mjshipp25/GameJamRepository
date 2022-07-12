// Written by Max Shipp following How to make a 2d platformer in Unity Ep. 5 by Brackeys

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour
{
    public int rotationOffset = 90;

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;      // Subtracting the position of the player from the mouse position.
        difference.Normalize();     //Normalize the vector. This meaning thaat all the sum of the vector will be equal to 1.

        float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; // find the angle in degrees 
        transform.rotation = Quaternion.Euler(0f, 0f, rotz + rotationOffset);
    }
}
