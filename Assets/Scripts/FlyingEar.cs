using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEar : MonoBehaviour
{
    public float earSpeed;

    public float maxRadius;

    [Header("Camera position")]

    public Transform cameraTransform;

    [Header("Key binds")]
    //  public Input keyUp;

    // Input key binds for the "flying ear"
    public float up; 
    public float down;
    public float left;
    public float right;
    private float distance;


    // Start is called before the first frame update

    void Start()
    {
        resetPosition();
        
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
    // Resets theposition of the ear to the position of the camera
    void resetPosition()
    {
        transform.position = cameraTransform.position;
    }
}
