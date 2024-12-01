using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class player
{
    public Vector3 Mover { get; set; }
    public Vector3 Girar { get; set; }
    public GameObject Objeto { get; set; }

    public string Name { get; set; }

    public player() 
    {
        Mover.Set(0, 0, 0);
        Girar.Set(0, 0, 0);
        
    }


    public player(Vector3 move, Vector3 girar, GameObject objeto ,string name)
    {
        Mover = move;
        Girar = girar;
        Objeto = objeto;
        Name = name;
    }

    public Vector3 movimento(Vector3 move)
    {
       move.Set(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            move.z = -0.12f;
            return move;
        }

        if (Input.GetKey(KeyCode.S))
        {
            move.z = 0.05f;
            return move;
        }
        return move;
    }

    public Vector3 rotacao(Vector3 girar)
    {
        girar.Set(0, 0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            girar.y = -0.1f;
            return girar;
        }

        if (Input.GetKey(KeyCode.D))
        {
            girar.y = 0.1F;
            return girar;
        }
        return girar;
    }
}
