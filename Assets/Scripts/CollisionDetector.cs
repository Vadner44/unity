using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision przeszkoda)
    {
        if (przeszkoda.gameObject.tag == "obstacle")
        {
            Debug.Log("Wykryto kolizje z przeszkodą");
        }
    }
}
