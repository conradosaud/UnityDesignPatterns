using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogos/Novo Dialogo", order = 1)]
public class Dialog : ScriptableObject
{
    public Color corFoto;
    public string nomeNPC;
    public string texto;
}
