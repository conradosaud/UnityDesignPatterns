using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private void Awake()
    {
        PlayerController.OnLifeChanged += HandleLifeChanged;
    }

    void HandleLifeChanged(int life)
    {
        if( life <= 0)
        {
            transform.GetComponent<Image>().enabled = true;
            transform.Find("Texto").GetComponent<TextMeshProUGUI>().enabled = true;
            GameObject.FindWithTag("Player").SetActive(false);
        }
    }

}
