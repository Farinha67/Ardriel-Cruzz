using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Vida m�xima do jogador
    private int currentHealth; // Vida atual do jogador

    void Start()
    {
        currentHealth = maxHealth; // Inicializa a vida atual
    }

    // Fun��o para aplicar dano ao jogador
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Subtrai o dano da vida atual
        Debug.Log("Dano recebido: " + damage + ". Vida atual: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die(); // Chama a fun��o de morte se a vida chegar a zero
        }
    }

    void Die()
    {
        Debug.Log("O jogador morreu!");
        // Aqui voc� pode adicionar l�gica para lidar com a morte do jogador (reiniciar o n�vel, mostrar uma tela de game over, etc.)
    }
}