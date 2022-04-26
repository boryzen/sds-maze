using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEar : MonoBehaviour
{
    public float earSpeed;

    public float maxRadius;

    [Header("Camera position")]

    public Transform cameraTransform;
   
    // [Header("Key binds")]
    // //  public Input keyUp;

    // // Input key binds for the "flying ear"
    // public float up; 
    // public float down;
    // public float left;
    // public float right;
    
    private float maxRadiusSq;

    // Start is called before the first frame update

    void Start()
    {
        resetPosition();
        maxRadiusSq = maxRadius*maxRadius;
        
    }

    // Update is called once per frame
    void Update()
    {   
        float step = Time.deltaTime * earSpeed;
        
        // Forward movement
        if (Input.GetKey(KeyCode.Alpha2))
        {
            // Debug.Log("2 key was pressed.");
            if(checkBounds())
                transform.Translate(Vector3.forward * step);

            // Back movement
        }

        if (Input.GetKey(KeyCode.X))
        {
            // Debug.Log("X key was pressed.");
            if(checkBounds())
                transform.Translate(Vector3.back * step);
        }


        // Left movement
        if (Input.GetKey(KeyCode.Alpha1))
        {
            // Debug.Log("Q key was pressed.");
             if(checkBounds())
                transform.Translate(Vector3.left * step);
        }

        // Right movement
        if (Input.GetKey(KeyCode.Alpha3))
        {
            // Debug.Log("E key was pressed.");
            if(checkBounds())
                transform.Translate(Vector3.right * step);

        }

        // Up movement
        if (Input.GetKey(KeyCode.E))
        {
            // Debug.Log("X key was pressed.");
            if(checkBounds())
                transform.Translate(Vector3.up * step);
        }

        // Down movement
        if (Input.GetKey(KeyCode.Q))
        {
            // Debug.Log("X key was pressed.");
            if(checkBounds())
                transform.Translate(Vector3.down * step);
        }


        // Reset position
        if (Input.GetKey(KeyCode.Space))
        {
            resetPosition();
            // Debug.Log("The Ear Reset");
        }
        
            transform.rotation = cameraTransform.rotation;

    }  
    // Resets theposition of the ear to the position of the camera
    void resetPosition()
    {
        transform.position = cameraTransform.position;
    }

    //chacking if the the radius is out of bounds
    bool checkBounds()
    {   
        float radiusSq = transform.localPosition.x*transform.localPosition.x + transform.localPosition.z*transform.localPosition.z;
        if(radiusSq <= maxRadiusSq)
            return true;
        else 
        {
            Debug.Log("Ear out of bounds");
            return false;
        }
    }
}
