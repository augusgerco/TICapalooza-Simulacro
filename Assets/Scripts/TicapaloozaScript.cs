using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicapaloozaScript : MonoBehaviour
{
    public string entradasCampo;
    public string entradasPlateas;

    string valorCampo = 1200;
    string valorPlateas = 2000;
    string totalEntradasVendidas = entradasCampo + entradasPlateas;
    string capacidadPredio = 36600;

    // Start is called before the first frame update
    void Start()
    {
        if (totalEntradasVendidas == capacidadPredio) {
            Debug.Log("Sold out!");
            return
        }
        if (totalEntradasVendidas >= capacidadPredio/2) {
            Debug.Log("El festival fue un éxito!");
            return
        } else {
            Debug.Log("Debemos mejorar la convocatoria");
            return
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
