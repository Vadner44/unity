using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor;
using UnityEngine;

public class Kwadrat : MonoBehaviour
{
    private Vector3[] target = new Vector3[4];
    public float speed;
    private int aktual = 0;
    private Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        target[0] = transform.position;
        target[1] = new Vector3(transform.position.x + 10f, transform.position.y, transform.position.z);
        target[2] = new Vector3(transform.position.x + 10f, transform.position.y, transform.position.z + 10f);
        target[3] = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10f);
    }

    void FixedUpdate()
    {
        if (transform.position != target[aktual])
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[aktual], Time.deltaTime * speed);
            Rb.MovePosition(pos);
        }
        else
        {
            transform.Rotate(0,transform.rotation.y+90f,0,Space.Self);
            aktual = (aktual+1) % target.Length;
        }
    }
}
