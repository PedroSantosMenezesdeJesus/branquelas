using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisao : MonoBehaviour
{
    public string sceneName;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("jogador"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
