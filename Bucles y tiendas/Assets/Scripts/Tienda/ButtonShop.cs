using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class ButtonShop : MonoBehaviour
{
    [SerializeField]
    Wallet myWallet;
    //[SerializeField] (No hará falta al hacerlo por código en @
    TextMeshProUGUI textButton;
    [SerializeField]
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;
    [SerializeField]
    string[] posiblesNombres;
    // Start is called before the first frame update
    void Start()
    {
        nameItem = posiblesNombres[Random.Range(0, posiblesNombres.Length)];
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>(); /* @ */
        priceItem = Random.Range(25f, 350f);
        textButton.text = nameItem + "\n" + priceItem.ToString() + " €";
    }

    public void ClickEnBotonDeTienda ()
    {
        myWallet.InformarSaldo(nameItem, priceItem);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
