using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class jogoObstaculo : MonoBehaviour
{
    Vector3 move;
    Vector3 move2;
    Vector3 move3;
    Vector3 move4;
    GameObject objeto;
    string nome;

    obstaculo carro1 = new obstaculo();
    obstaculo carro2 = new obstaculo();
    obstaculo carro3 = new obstaculo();
    obstaculo carro4 = new obstaculo();
    obstaculo carro5 = new obstaculo();
    obstaculo carro6 = new obstaculo();

    // Start is called before the first frame update
    void Start()
    {
        move.Set(0, 0, 0);
        move2.Set(0, 0, 0);
        move3.Set(0, 0, 0);
        move4.Set(0, 0, 0);
        //transform.Translate(move);
        nome = "obstaculo";
        
        carro1.Move = move;
        carro1.Objeto = objeto;
        carro1.Name = nome;

        carro2.Move = move2;
        carro2.Objeto = objeto;
        carro2.Name = nome;

        carro3.Move = move2;
        carro3.Objeto = objeto;
        carro3.Name = nome;

        carro4.Move = move3;
        carro4.Objeto = objeto;
        carro4.Name = nome;

        carro5.Move = move4;
        carro5.Objeto = objeto;
        carro5.Name = nome;

        carro6.Move = move3;
        carro6.Objeto = objeto;
        carro6.Name = nome;

        Encontrar();
    }

    // Update is called once per frame
    void Update()
    {
        move = carro1.MovimentObstacle1(move);
        transform.Translate(move);

        move2 = carro2.MovimentObstacle2(move);
        transform.Translate(move);

        move2 = carro3.MovimentObstacle2(move);
        transform.Translate(move);

        move3 = carro4.MovimentObstacle3(move);
        transform.Translate(move);

        move4 = carro5.MovimentObstacle4(move);
        transform.Translate(move);

        move3 = carro6.MovimentObstacle3(move);
        transform.Translate(move);
    }
    public GameObject Encontrar()
    {

        objeto = GameObject.FindGameObjectWithTag(nome);
        return objeto.GetComponent<GameObject>();
    }

}
