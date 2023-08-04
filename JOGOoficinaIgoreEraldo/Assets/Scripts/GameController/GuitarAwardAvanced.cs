using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuitarAwardAvanced : MonoBehaviour
{
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.gameObject.CompareTag("Guitar"))
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
