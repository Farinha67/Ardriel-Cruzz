using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Vida máxima do jogador
    private int currentHealth; // Vida atual do jogador

    void Start()
    {
        currentHealth = maxHealth; // Inicializa a vida atual
    }

    // Função para aplicar dano ao jogador
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Subtrai o dano da vida atual
        Debug.Log("Dano recebido: " + damage + ". Vida atual: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die(); // Chama a função de morte se a vida chegar a zero
        }
    }

    void Die()
    {
        Debug.Log("O jogador morreu!");
        // Aqui você pode adicionar lógica para lidar com a morte do jogador (reiniciar o nível, mostrar uma tela de game over, etc.)
    }
}