using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPricipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject PainelMenuInicial;
    [SerializeField] private GameObject PainelOpcoes;
    public void jogar() 
    { 
    SceneManager.LoadScene(nomeDoLevelDeJogo);
    } 
    public void AbrirOpcoes() 
    {
        PainelMenuInicial.SetActive(false);
        PainelOpcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        PainelOpcoes.SetActive(false);
        PainelOpcoes.SetActive(true) ; 

    }
    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("sair do jogo");

    }


}
