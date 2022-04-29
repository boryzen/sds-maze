using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlyingEar : MonoBehaviour
{
    public float earSpeed;

    public float maxRadius;

    [Header("Parent")]

    public Transform parent;
   
    // [Header("Key binds")]
    // //  public Input keyUp;
    
    private float maxRadiusSq;

    // Start is called before the first frame update

    private bool canMoveFlag = true;
    
    void Start()
    {
        // updateTransform(orientationTransform);
        // resetPosition();
        maxRadiusSq = maxRadius*maxRadius;
        transform.parent = parent;
        
        
    }

    // Update is called once per frame
    void Update()
    {   

        
        float step = Time.deltaTime * earSpeed;
        
        // Forward movement
        if (Input.GetKey(KeyCode.Alpha2) && canMoveFlag)
        {
            // Debug.Log("2 key was pressed.");
            if(checkBounds())
                transform.Translate(Vector3.forward * step);

            // Back movement
        }

        if (Input.GetKey(KeyCode.X) && canMoveFlag)
        {
            // Debug.Log("X key was pressed.");
            if(checkBounds())
                transform.Translate(Vector3.back * step);
        }

        // Reset position
        if (Input.GetKey(KeyCode.Space))
        {
            resetPosition();
            // Debug.Log("The Ear Reset");
        }
        
            // transform.rotation = cameraTransform.rotation;
        if (Input.GetKeyDown(KeyCode.F))
        {   
            if(transform.parent != null)
            {   transform.parent = null;
                canMoveFlag = false;
            }
            else
            {
                transform.parent = parent;
                resetPosition();
                canMoveFlag = true;
            }

        }
        if(transform.parent == null)
            transform.rotation = parent.rotation;

    }  
    // Resets theposition of the ear to the position of the camera
    void resetPosition()
    {
        transform.position = parent.position;
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

    void updateTransform(Transform tran)
    {
        transform.position = tran.position;
        transform.rotation = tran.rotation;
    
    }
}
