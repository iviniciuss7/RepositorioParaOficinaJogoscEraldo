using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] float damage;
    [SerializeField] Transform gfx;
    [SerializeField] float rotateSpeed;
    [SerializeField] private int dano;

    void Start()
    {
        Destroy(gameObject, 2.5f);
    }

    void Update()
    {
        transform.Translate(Vector3.right * velocity * Time.deltaTime);
        gfx.Rotate(rotateSpeed * Time.deltaTime * Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().takeDamage(dano);
            Destroy(gameObject);
        }
    }
}
