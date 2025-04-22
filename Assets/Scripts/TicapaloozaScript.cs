using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicapaloozaScript : MonoBehaviour
{
    public int entradasCampo;
    public int entradasPlateas;

    int valorCampo = 1200;
    int valorPlateas = 2000;
    int capacidadPredio = 36600;
    int totalRecaudacion;

    // Start is called before the first frame update
    void Start()
    {
        int totalEntradasVendidas = entradasCampo + entradasPlateas;

        totalRecaudacion = totalRecaudacion + entradasCampo * valorCampo;
        totalRecaudacion = totalRecaudacion + entradasPlateas * valorPlateas;

        if (totalEntradasVendidas == capacidadPredio) {
            Debug.Log("Sold out!");
        }
        if (totalEntradasVendidas >= capacidadPredio / 2) {
            Debug.Log("El festival fue un éxito!");
        } else {
            Debug.Log("Debemos mejorar la convocatoria");
        }
        if (entradasCampo <= 0 && entradasCampo > 20400)
        {
            Debug.Log("Error.");
            return;
        } else
        if (entradasPlateas <= 0 && entradasPlateas > 16200)
        {
            Debug.Log("Error.");
            return;
        }

        Debug.Log("La recaudacion total es de $" + totalRecaudacion);

     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
