using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float slowdown = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && slowdown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            slowdown = 1;
        }
        if (slowdown >= 0)
        {
            slowdown -= Time.deltaTime;
        }
    }
}
