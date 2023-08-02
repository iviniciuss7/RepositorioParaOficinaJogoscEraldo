using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPower : MonoBehaviour
{
    [SerializeField]float maximo;
    [SerializeField]float atual;
    [SerializeField] UnityEngine.UI.Image fill;

    void Update()
    {
        fill.fillAmount = atual / maximo;


    }
}
