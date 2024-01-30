using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField] private float BounceForce = 10f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Vector3 dir = collision.gameObject.transform.position - this.gameObject.transform.position;
            dir.Normalize();
            collision.gameObject.GetComponent<Rigidbody>().AddForce(dir * BounceForce);
        }
    }
}
