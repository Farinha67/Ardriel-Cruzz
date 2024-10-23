using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerVida : MonoBehaviour
{
    public int vidaMaxima = 100;
    private int vidaAtual;
    public GameManangerScript gameMananger;

    void Start()
    {
        vidaAtual = vidaMaxima;  // Inicia com a vida cheia
    }

    // Função que aplica dano ao player
    public void TomarDano(int dano)
    {
        vidaAtual -= dano;
        Debug.Log("Player tomou dano! Vida restante: " + vidaAtual);

        if (vidaAtual <= 0)
        {
            Morrer();  // Chama a função de morte se a vida chegar a zero
        }
    }

    void Morrer()
    {
        Debug.Log("Player morreu!");
        gameMananger.GameOver();
        Destroy(gameObject);
    }
}
