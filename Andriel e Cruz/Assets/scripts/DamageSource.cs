using UnityEngine;

public class DamageSource : MonoBehaviour
{
    public int damageAmount = 20; // Quantidade de dano que o objeto causa

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Verifica se o objeto colidido tem a tag "Player"
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>(); // Obtém o script de saúde do jogador
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount); // Aplica dano ao jogador
            }
        }
    }
}