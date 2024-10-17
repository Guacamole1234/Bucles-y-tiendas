using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f, 1920f);
        guacamoleSaldo.text = saldo.ToString("000.00") + " €";
    }

    public void RestarSaldo(float precio)
    {
        if ( saldo > precio )
        {
            saldo -= precio;
            guacamoleSaldo.text = saldo.ToString("000.00") + " €";
        }
        else
        {
            noSaldo.SetActive(true);
        }
    }
}
