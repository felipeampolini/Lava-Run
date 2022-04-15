using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//video referencia https://www.youtube.com/watch?v=eAycALcCBBI

public class CuspindoLava : MonoBehaviour
{
   // Start is called before the first frame update

    public float velocidade = 0.005f;
    public float minX = 1f;
    public float minY = 0.025f;
    public float minZ = 1f;

    public float atualX;
    public float atualY;
    public float atualZ;

    public float maxX = 160f;
    public float maxY = 2f;
    public float maxZ = 160f;

    public bool flag = true;
    public bool flagV = false;
    public bool flagH = false;
    
    void Start(){
        atualX = minX;
        atualY = minY;
        atualZ = minZ;
    }

    // Update is called once per frame
    void Update()
    {
        if(!flagV && atualY<=maxY){
            atualX += (1f * (velocidade/2))*(Time.deltaTime*300f);
            atualY += (0.025f * (velocidade/2))*(Time.deltaTime*300f);
            atualZ += (1f * (velocidade/2))*(Time.deltaTime*300f);
            transform.localScale = new Vector3(atualX, atualY, atualZ);
        }

        if(atualY > maxY)
            flagV = true; //significa que ja terminou o movimento de crescimento vertical da chama

        if(flagV && !flagH && atualX<=maxX && atualZ<=maxZ){
            atualX += (1f * (velocidade/2))*(Time.deltaTime*300f);
            atualZ += (1f * (velocidade/2))*(Time.deltaTime*300f);
            transform.localScale = new Vector3(atualX, atualY, atualZ);
        }

        if(atualX>=maxX && atualZ>=maxZ)
            flagH = true; //significa que ja terminou o movimento de crescimento horizontal da chama
        
        if(flagH){ //diminuir verticalmente chama
            atualX -= (1f * (velocidade/2))*(Time.deltaTime*300f);
            atualX -= (1f * (velocidade/2))*(Time.deltaTime*300f);
            atualY -= (0.025f * (velocidade/2))*(Time.deltaTime*300f);
            atualZ -= (1f * (velocidade/2))*(Time.deltaTime*300f);
            atualZ -= (1f * (velocidade/2))*(Time.deltaTime*300f);
            transform.localScale = new Vector3(atualX, atualY, atualZ);
        }
        if(minX>=atualX && minY>=atualY && minZ>=atualZ){ // resseto todas as flags
            flag = true;
            flagV = false;
            flagH = false;
        }
    }
}
