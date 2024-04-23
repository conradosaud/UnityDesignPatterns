using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{

    public bool velocityPoint = true;
    // Iniciar com action simples e depois com argumentos
    public static event Action<bool> OnCoinCollected;
    public static int moedas = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.CompareTag("Player"))
        {
            // Demonstrar erros possíveis e como usar o ?
            //OnCoinCollected(velocityPoint);
            moedas++;
            OnCoinCollected?.Invoke(velocityPoint);
        }

        Destroy(gameObject);
    }


}
