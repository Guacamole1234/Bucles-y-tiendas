using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Wallet : MonoBehaviour
{
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI guacamoleSaldo;
    [SerializeField]
    GameObject confirmarCompra;
    [SerializeField]
    GameObject noSaldo;
    [SerializeField]
    TextMeshProUGUI guacamoleConfirma;
    float precioObjetoQueCompro;

    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f, 1920f);
        guacamoleSaldo.text = saldo.ToString("000.00") + " €";
    }

    public void InformarSaldo(string nameITem, float precio)
    {
        if ( saldo > precio )
        {
            guacamoleConfirma.text = "¿Quieres comprar " + nameITem + "por " + precio + " €";
            confirmarCompra.SetActive(true);
            precioObjetoQueCompro = precio;
        }
        else
        {
            noSaldo.SetActive(true);
        }   
    }

    public void ConfirmarCompra ()
    {
        if (saldo > precioObjetoQueCompro)
        {
            saldo = saldo - precioObjetoQueCompro;
            guacamoleSaldo.text = saldo.ToString("000.00") + " €";
            confirmarCompra.SetActive(false);
        }
        else
        {
            confirmarCompra.SetActive(false);
            noSaldo.SetActive(true);
        }
    }
}
