using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo 
{
    public Vector3 Move { get; set; }

    public obstaculo()
    {
        Move.Set(0, 0, 0);
    }

    public obstaculo(Vector3 move)
    {
        this.Move = move;
    }

    public void MovimentObstacle1(Vector3 move)
    {
        move.z += 1;
    }

    public void MovimentObstacle2(Vector3 move)
    {
        move.z -= 1;
    }

    public void MovimentObstacle3(Vector3 move)
    {
        move.x += 1;
    }
}
