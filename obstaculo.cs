using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo 
{
    public Vector3 Move { get; set; }
    public GameObject Objeto { get; set; }
    public string Name { get; set; }

    public obstaculo()
    {
        Move.Set(0, 0, 0);

    }

    public obstaculo(Vector3 move, GameObject objeto, string name)
    {
        this.Move = move;
        Objeto = objeto;
        Name = name;
    }

    public Vector3 MovimentObstacle1(Vector3 move)
    {
        move.z = 0.01f;
        return move;
    }

    public Vector3 MovimentObstacle2(Vector3 move)
    {
        move.z = -0.0001f;
        return move;
    }

    public Vector3 MovimentObstacle3(Vector3 move)
    {
        move.x = 0.0000000001f;
        return move;
    }

    public Vector3 MovimentObstacle4(Vector3 move)
    {
        move.z = 0.00000000001f;
        return move;
    }
}
