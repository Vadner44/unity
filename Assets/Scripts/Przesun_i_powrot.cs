using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przesun_i_powrot : MonoBehaviour
{
    public float speed;

    private Rigidbody Rb;
    private Vector3[] target = new Vector3[2];
    private int actual = 0;


    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        target[0] = transform.position;
        target[1] = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position != target[actual])
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[actual], Time.deltaTime * speed);
            Rb.MovePosition(pos);
        }
        else
        {
            actual = (actual + 1) % target.Length;
        }
    }
}
