using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class jogoObstaculo : MonoBehaviour
{
    Vector3 move;
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
        //transform.Translate(move);
        name = "obstaculo";
        
        carro1.Move = move;
        carro1.Objeto = objeto;
        carro1.Name = name;

        carro2.Move = move;
        carro2.Objeto = objeto;
        carro2.Name = name;

        carro3.Move = move;
        carro3.Objeto = objeto;
        carro3.Name = name;

        carro4.Move = move;
        carro4.Objeto = objeto;
        carro4.Name = name;

        carro5.Move = move;
        carro5.Objeto = objeto;
        carro5.Name = name;

        carro6.Move = move;
        carro6.Objeto = objeto;
        carro6.Name = name;

        Encontrar();
    }

    // Update is called once per frame
    void Update()
    {
        move = carro1.MovimentObstacle1(move);
        transform.Translate(move);

        carro2.MovimentObstacle2(move);
        transform.Translate(move);

        carro3.MovimentObstacle2(move);
        transform.Translate(move);

        carro4.MovimentObstacle3(move);
        transform.Translate(move);

        carro5.MovimentObstacle4(move);
        transform.Translate(move);

        carro6.MovimentObstacle3(move);
        transform.Translate(move);
    }
    public GameObject Encontrar()
    {

        objeto = GameObject.FindGameObjectWithTag(name);
        return objeto.GetComponent<GameObject>();
    }

}
