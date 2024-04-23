using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{

    public Dialog dialog;

    Transform dialogo;
    private void Start()
    {
        dialogo = GameObject.Find("Canvas").transform.Find("Dialogo");
    }

    public void MostrarDialogo()
    {

        dialogo.GetComponent<Canvas>().enabled = true;
        dialogo.transform.Find("Foto").GetComponent<Image>().color = dialog.corFoto;
        dialogo.transform.Find("Nome").GetComponent<TextMeshProUGUI>().text = dialog.nomeNPC;
        dialogo.transform.Find("Texto").GetComponent<TextMeshProUGUI>().text = dialog.texto;
    }

    public void EsconderDialogo()
    {
        dialogo.GetComponent<Canvas>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MostrarDialogo();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        EsconderDialogo();
    }

}
