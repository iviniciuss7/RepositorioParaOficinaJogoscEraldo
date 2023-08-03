using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] Transform gfx;
    [SerializeField] float rotateSpeed;
    [SerializeField] private int dano;
    private SpecialPower specialPower;
    [SerializeField] Vector3 tamanhoDoPoderEspecial;
    [SerializeField] float velocidadeDoPoderEspecial;
    private float velocidadeAtual;
    [SerializeField] int danoSuper;
    private int danoAtual;

    private void Awake()
    {
        specialPower = GameObject.FindGameObjectWithTag("Player").GetComponent<SpecialPower>();
    }
    void Start()
    {
        if (specialPower.poderEspecialAtivado)
        {
            velocidadeAtual = velocidadeDoPoderEspecial;
            transform.localScale = tamanhoDoPoderEspecial;
            danoAtual = danoSuper;
            specialPower.UsarPoderEspecial();
        }
        else
        {
            danoAtual= dano;
            velocidadeAtual = velocity;
        }
        Destroy(gameObject, 2.5f);
    }

    void Update()
    {
        transform.Translate(Vector3.right * velocidadeAtual * Time.deltaTime);
        gfx.Rotate(rotateSpeed * Time.deltaTime * Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().takeDamage(danoAtual);
            Destroy(gameObject, 0.2f);
        }
    }
}
