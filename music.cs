using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public AudioSource musicaDeFundo;
    public AudioClip[] musicas;
    // Start is called before the first frame update
    void Start()
    {
        AudioClip musicaDafase = musicas[0];
        musicaDeFundo.clip = musicaDafase;
        musicaDeFundo.loop = true;
        musicaDeFundo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
