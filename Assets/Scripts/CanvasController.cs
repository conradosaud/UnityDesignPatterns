using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        Moeda.OnCoinCollected += HandleCoinCollected;
        PlayerController.OnLifeChanged += HandleLifeChanged;
    }

    void HandleCoinCollected(bool velocityPoint)
    {
        GameObject.Find("TextCoins").GetComponent<TextMeshProUGUI>().text = "Moedas: " + Moeda.moedas;
        // Comentar do exemplo de mostrar vari�veis aqui, como velocidade e pulo, n�o s�o sincronizadas em eventos
    }

    void HandleLifeChanged(int life)
    {
        GameObject.Find("TextLife").GetComponent<TextMeshProUGUI>().text = "Vidas: " + life.ToString();
    }

}
