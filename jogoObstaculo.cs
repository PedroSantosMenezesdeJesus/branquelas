using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogoObstaculo : MonoBehaviour
{
    Vector3 move;

    obstaculo carro1 = new obstaculo();
    obstaculo carro2 = new obstaculo();
    obstaculo carro3 = new obstaculo();
    obstaculo carro4 = new obstaculo();
    obstaculo carro5 = new obstaculo();

    // Start is called before the first frame update
    void Start()
    {
        move.Set(0, 0, 0);
        transform.Translate(move);
        
        carro1.Move = move;

        carro2.Move = move;
        
        carro3.Move = move;
       
        carro4.Move = move;
        
        carro5.Move = move;
        
    }

    // Update is called once per frame
    void Update()
    {
        carro1.MovimentObstacle1(move);

        carro2.MovimentObstacle2(move);

        carro3.MovimentObstacle2(move);

        carro4.MovimentObstacle3(move);

        carro5.MovimentObstacle1(move);

    }
}
