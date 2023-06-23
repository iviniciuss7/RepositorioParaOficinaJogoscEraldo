using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public float velocity;
    [SerializeField] Transform target;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, velocity * Time.deltaTime);
    }
}
