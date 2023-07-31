using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFall : MonoBehaviour
{
    public Rigidbody2D rig;
    public float fallDelay = 2f;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(0.2f);
        rig.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, fallDelay);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("Fall");
        }
    }
}
