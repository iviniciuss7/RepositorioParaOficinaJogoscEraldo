using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPower : MonoBehaviour
{
    [SerializeField] float maximo;
    [SerializeField] float atual;
    [SerializeField] UnityEngine.UI.Image fill;

    private bool poderEspecialAtivado = false;

    void Update()
    {
        if (poderEspecialAtivado)
        {
            // Exemplo: Código que será executado quando o poder especial estiver ativado.
            // Por exemplo, você pode fazer o personagem ficar mais forte ou realizar uma animação especial.
            // Exemplo: personagem.AtivarPoderEspecial();
            // Exemplo: animacaoAtivarPoder.Play();
            // Exemplo: ReiniciarBarra();
        }
        else
        {
            fill.fillAmount = atual / maximo;

            if (fill.fillAmount >= 1.0f)
            {
                AtivarPoderEspecial();
            }
        }
    }

    private void AtivarPoderEspecial()
    {
        // Exemplo: Código que será executado quando o poder especial for ativado.
        // Por exemplo, você pode fazer o personagem ficar mais forte ou realizar uma animação especial.
        // Exemplo: personagem.FicarMaisForte();
        // Exemplo: animacaoAtivarPoder.Play();
        // Exemplo: ReiniciarBarra();

        // Reinicia a barra para permitir a recarga do poder especial.
        ReiniciarBarra();
    }

    private void ReiniciarBarra()
    {
        // Reinicia a barra de poder.
        atual = 0f;
        fill.fillAmount = 0f;
    }
}
