using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager =
GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
