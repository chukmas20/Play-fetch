using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float slowrun = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && slowrun <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            slowrun = 1;
        }
        if (slowrun >= 0)
        {
            slowrun -= Time.deltaTime;
        }
    }
}
