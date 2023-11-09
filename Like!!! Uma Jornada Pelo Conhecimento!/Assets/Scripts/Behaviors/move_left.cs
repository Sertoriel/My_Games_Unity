using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class move_left : MonoBehaviour
{

    private float limit = -20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() // Controle de Tempo de Estadia dos Objts adicionados no game/ MOVIMENTO PARA ESQUERDA.
    {
        if(!GameControler.gameOver)
        {
            transform.Translate(Vector3.left * GameControler.speed * Time.deltaTime);
        }

        if(transform.position.x < limit && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }

        if(transform.position.x < limit && gameObject.CompareTag("Boss"))
        {
            Destroy(gameObject);
        }
        
        if(transform.position.x < limit && gameObject.CompareTag("Points"))
        {
            Destroy(gameObject);
        }

    }
}
