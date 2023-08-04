using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChegadaLoad : MonoBehaviour
{
    private bool canInteract = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Chegada"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Chegada"))
        {
            canInteract = false;
        }
    }

    private void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(3);
        }
    }
}
