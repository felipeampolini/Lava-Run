using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Carregou Script para botões do menu")   ;
    }

    public void fecharJogo(){
        Debug.Log ("Fechando o jogo");
        Application.Quit();
    }

    public void abrirJogo(){
        Debug.Log("Carregando cena sobre o jogo");
        SceneManager.LoadScene("Game");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }
    public void abrirSobre(){
        Debug.Log("Carregando cena sobre o jogo");
        SceneManager.LoadScene("Sobre");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

    public void abrirMenu(){
        Debug.Log("Carregando cena menu o jogo");
        SceneManager.LoadScene("MainMenu");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

}
