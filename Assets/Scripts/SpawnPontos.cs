using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPontos : MonoBehaviour
{

    public static SpawnPontos singleton;

    public List<Transform> pontos = new List<Transform>();
    public Transform areaSpawn;

    public void Awake()
    {
        singleton = this;
    }

    public void Spawnar( int indice )
    {
        Transform ponto = pontos[indice];
        Transform instanciado = Instantiate(ponto, transform);
        instanciado.position = new Vector2(Random.Range(-(areaSpawn.localScale.x / 2), areaSpawn.localScale.x / 2) + areaSpawn.position.x, 0);
    }

}
