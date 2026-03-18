using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float calmDelay = 1.0f;

    private bool canSpawn = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(SpawnCooldown());
        }

        IEnumerator SpawnCooldown()
        {
            canSpawn = false;
            yield return new WaitForSeconds(calmDelay);
            canSpawn = true;
        }
    }
}
