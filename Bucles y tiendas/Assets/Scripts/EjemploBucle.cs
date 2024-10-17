using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploBucle : MonoBehaviour
{
    public int[] arrayNumeros;
    void Start()
    {
        int sumaDeNotas = 0;
        int notaMaximo = 0;
        int notaMinimo = arrayNumeros[0];
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            sumaDeNotas += arrayNumeros[i];
            Debug.Log("Nota en el ejercicio " + i + " = " + arrayNumeros[i]);
            if (arrayNumeros[i] > notaMaximo)
            {
                notaMaximo = arrayNumeros[i];
            }
            if (arrayNumeros[i] < notaMinimo)
            {
                notaMinimo = arrayNumeros[i];
            }
        }
        int mediaNotas = sumaDeNotas / arrayNumeros.Length;
        Debug.Log("La nota media es " + mediaNotas + ". La nota más baja es: " + notaMinimo + ". La nota más alta es: " + notaMaximo);
    }
}
