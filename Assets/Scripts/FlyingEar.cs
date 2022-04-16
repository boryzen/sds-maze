using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEar : MonoBehaviour
{

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Alpha1 key was pressed.");

            distance = 0;

            transform.Translate(0, 0, distance);

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Alpha2 key was pressed.");

            distance = 5;

            transform.Translate(0, 0, distance);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Alpha3 key was pressed.");

            distance = 10;

            transform.Translate(0, 0, distance);

        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Alpha4 key was pressed.");

            distance = 15;

            transform.Translate(0, 0, distance);
        }

    }
}