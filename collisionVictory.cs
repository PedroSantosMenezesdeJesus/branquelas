using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionVictory : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("jogador"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
