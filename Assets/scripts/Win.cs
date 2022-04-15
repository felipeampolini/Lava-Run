using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text texto; //declarando uma variavel publica no Script, ela passa a aparecer no Inspector

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
        
    }

    //identificar quando o jogador encostar do cubo
    void OnTriggerEnter(Collider jogador){
        if(jogador.tag == "Player"){
            if(jogador.name == "jogador"){
                //mostra a msg na tela
                texto.gameObject.SetActive(true);
                //esperar um tempo e reiniciar a cena
                StartCoroutine(pausarPorUmTempo()); //chama a coroutine (a Thread)
            }
        }

    }
    
    //IEnumerator - é como se fosse uma thread
    IEnumerator pausarPorUmTempo(){
    //laço inifinito que encerra o processo após N segundos
        while(true){
            Debug.Log("Ganhou! Reiniciando!");
            yield return new WaitForSeconds(3); //f para indicar valores float
            this.reiniciarCena();
        }
    }

    //reiniciar a cena (ou ir para outra cena)
    void reiniciarCena(){
        Scene cena = SceneManager.GetActiveScene();
        texto.gameObject.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}
