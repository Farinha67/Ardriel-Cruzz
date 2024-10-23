using UnityEngine;

public class Espinhos : MonoBehaviour
{
    public int dano = 10;  // Define o quanto de dano o espinho causa

    // Detecta a colisão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto que colidiu é o player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Acessa o script de vida do player (assumindo que você tenha um script de vida)
            PlayerVida playerVida = collision.gameObject.GetComponent<PlayerVida>();

            if (playerVida != null)
            {
                playerVida.TomarDano(dano);  // Aplica o dano
            }
        }
    }
}