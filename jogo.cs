using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogo : MonoBehaviour
{
    Vector3 move;
    Vector3 girar;
    string nome;
    // Start is called before the first frame update
    void Start()
    {
        move.Set(0, 0, 0);
        girar.Set(0, 0, 0);
        nome = "jogador";

        player p = new player(move, nome);
        p.Mover = move;
        p.Name = nome;
        p.movimento(move);
        

        obstaculo carro1 = new obstaculo(move);
        carro1.Move = move;
        carro1.MovimentObstacle1(move);

        obstaculo carro2 = new obstaculo(move);
        carro2.Move = move;
        carro2.MovimentObstacle2(move);

        obstaculo carro3 = new obstaculo(move);
        carro3.Move = move;
        carro3.MovimentObstacle2(move);

        obstaculo carro4 = new obstaculo(move);
        carro4.Move = move;
        carro4.MovimentObstacle3(move);

        obstaculo carro5 = new obstaculo(move);
        carro5.Move = move;
        carro5.MovimentObstacle1(move);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            move.z = -0.1f;
            transform.Translate(move);
        }

        if (Input.GetKey(KeyCode.S))
        {
            move.z = 0.05f;
            transform.Translate(move);
        }

        if (Input.GetKey(KeyCode.A))
        {
            girar.y = -0.05f;
            transform.Rotate(girar);
        }

        if (Input.GetKey(KeyCode.D))
        {
            girar.y = 0.05F;
            transform.Rotate(girar);
        }
    }
}
