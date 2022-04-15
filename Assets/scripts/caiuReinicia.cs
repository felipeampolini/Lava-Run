using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class caiuReinicia : MonoBehaviour
{
    //public Text texto; //declarando uma variavel publica no Script, ela passa a aparecer no Inspector

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Script para verificar fim do jogo");
    }

    // Update is called once per frame
    void Update(){
        
    }

    //identificar quando o jogador encostar do cubo
    void OnTriggerEnter(Collider jogador){

        if(jogador.tag == "Player"){
            if(jogador.name == "jogador"){


                //mostra a msg na tela
                //texto.text = "Game Over!";


                //esperar um tempo e reiniciar a cena
                StartCoroutine(pausarPorUmTempo()); //chama a coroutine (a Thread)
            }
        }

    }
    
    //IEnumerator - é como se fosse uma thread
    IEnumerator pausarPorUmTempo(){
    //laço inifinito que encerra o processo após N segundos
        while(true){
            Debug.Log("Game Over! Reiniciando!");
            yield return new WaitForSeconds(0); //f para indicar valores float
            this.reiniciarCena();
        }
    }

    //reiniciar a cena (ou ir para outra cena)
    void reiniciarCena(){
        Scene cena = SceneManager.GetActiveScene();
        SceneManager.LoadScene(cena.name);
    }
}