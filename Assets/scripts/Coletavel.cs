using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidade = 0.2f;
    public float velocidadeUpDown = 0.002f;
    public Vector3 direcao;
    public Vector3 posicaoInicial;
    void Start(){
        posicaoInicial = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if(!Pause.GameIsPaused){ 
               transform.Rotate(direcao * velocidade);        
            transform.Translate(0, velocidadeUpDown, 0);
            if(transform.position.y>=posicaoInicial.y+0.5f)
                velocidadeUpDown = velocidadeUpDown*-1;
            if(transform.position.y<=posicaoInicial.y)
                velocidadeUpDown = velocidadeUpDown*-1;
        }
    }
}
