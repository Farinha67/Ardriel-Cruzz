using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaNele : MonoBehaviour
{
    [SerializeField] private string NomeDoLevelDeJogo;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Lanele()
    {
        SceneManager.LoadScene(NomeDoLevelDeJogo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
