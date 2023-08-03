using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPower : MonoBehaviour
{
    [SerializeField] float maximo;
    [SerializeField] float atual;
    [SerializeField] UnityEngine.UI.Image fill;

    public bool poderEspecialAtivado = false;

    public void UsarPoderEspecial()
    {
        DefinirValorDaBarra(0);
        poderEspecialAtivado=false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Energia"))
        {
            DefinirValorDaBarra(atual + 2);
            Destroy(collision.gameObject);
            if (atual >= maximo)
            {
                poderEspecialAtivado=true;
            }
        }
    }
    private void DefinirValorDaBarra(float novoValor)
    {
        atual = novoValor;
        AtualizarBarra();
    }
    void AtualizarBarra()
    {
        fill.fillAmount = atual / maximo;
    }
}
