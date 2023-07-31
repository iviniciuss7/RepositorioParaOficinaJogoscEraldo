using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCam : MonoBehaviour
{
    private Transform player;
    public float suavidade;
    public float camlimitx1;
    public float camlimitx2;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        if (player.position.x >= camlimitx1 && player.position.x <= camlimitx2)
        {
            Vector3 seguindo = new Vector3(player.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, seguindo, suavidade * Time.deltaTime);
        }
        
    }
}
