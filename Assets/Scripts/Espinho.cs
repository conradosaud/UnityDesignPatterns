using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            playerController.TakeDamage();
        }
    }
}
