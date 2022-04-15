using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roda_roda_jequiti : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidade = 0.2f;
    public Vector3 direcao;

    // Update is called once per frame
    void Update()
    {
        if(Time.deltaTime!=0)
            transform.Rotate(direcao * velocidade);
    }
}
