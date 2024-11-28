using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class jogo : MonoBehaviour
{
    Vector3 move;
    Vector3 girar;
    GameObject objeto;
    string nome;

    player p = new player();

    // Start is called before the first frame update
    void Start()
    {
        move.Set(0, 0, 0);
        transform.Translate(move);
        girar.Set(0, 0, 0);
        transform.Rotate(girar);
        nome = "jogador";

       

        p.Mover = move;
        p.Girar = girar;
        p.Name = nome;
        p.Objeto = objeto;
        Encontrar();
        

    }

    // Update is called once per frame
    void Update()
    {
        move = p.movimento(move);
        transform.Translate(move);
        girar = p.rotacao(girar);
        transform.Rotate(girar);
    }

    public GameObject Encontrar()
    {
        objeto = GameObject.FindGameObjectWithTag(nome);
      //return objeto;
        return objeto.GetComponent<GameObject>();
    }

}
