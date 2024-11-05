using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TituloMovimento : MonoBehaviour
{
    public float amplitude = 2f;      // Define a distância do movimento
    public float velocidade = 2f;     // Define a velocidade do movimento

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;  // Guarda a posição inicial do título
    }

    void Update()
    {
        // Calcula o novo movimento de vai-e-vem
        float deslocamento = Mathf.Sin(Time.time * velocidade) * amplitude;
        transform.position = posicaoInicial + new Vector3(deslocamento, 0, 0);
    }
}
