using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sterowanie : MonoBehaviour
{
    public float speed;
    private Rigidbody Rb;
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(mH,0,mV);
        move = move.normalized * speed * Time.deltaTime;
        Rb.MovePosition(transform.position+move);
    }
}
