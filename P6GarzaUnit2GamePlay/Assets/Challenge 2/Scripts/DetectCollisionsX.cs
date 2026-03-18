using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager =
GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            gameManager.AddScore(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
