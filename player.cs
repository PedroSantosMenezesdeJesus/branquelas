using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player 
{
    public Vector3 Mover { get; set; }
    public string Name { get; set; }

    public player() 
    {
        Mover.Set(0, 0, 0);
    }


    public player(Vector3 move, string name)
    {
        this.Mover = move;
       
        this.Name = name;
    }

    public Vector3 movimento(Vector3 move)
    {
        move.Set(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            move.z = -0.1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            move.z = 0.05f;

        }
        return move;
    }

}
