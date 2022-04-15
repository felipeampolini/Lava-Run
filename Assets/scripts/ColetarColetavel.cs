using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetarColetavel : MonoBehaviour
{

    public Text pontuacao;
    private int pontos;
    private int multiplicador=1;

    private bool abrirPortal;

    public GameObject portal;

    private Vector3 scaleChange;
    private float velocidadeAbrirPortal;
    private float tamMax;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        pontuacao.text = "Pontuação: " + pontos;

        tamMax = 20;
        abrirPortal = true;
        velocidadeAbrirPortal = 2f;
        scaleChange = new Vector3(+0.01f*velocidadeAbrirPortal, +0.01f*velocidadeAbrirPortal, +0.01f*velocidadeAbrirPortal);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.deltaTime!=0){
            if(pontos >= 10 && abrirPortal){
                abrirPortalFunction(portal);
            }
        }
    }

    void abrirPortalFunction(GameObject portal){
        portal.gameObject.SetActive(true);
        if(portal.transform.localScale.x <=tamMax){
            portal.transform.localScale += scaleChange;
            //para de girar
        }else
            abrirPortal = false;
    }

    void OnTriggerEnter (Collider coletavel){
        if(coletavel.tag == "coletavel"){
            coletavel.gameObject.SetActive(false);
            pontos = pontos+(multiplicador*1);
            pontuacao.text = "Pontuação: " + pontos;
        }
    }
}
