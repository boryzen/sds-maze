using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCount : MonoBehaviour
{

    //public StopWatch StopWatch;
    // private bool gameOver = false;
    public int childCounter;

    // Update is called once per frame
    void Update()
    {
        childCounter = transform.childCount;

  
    }
}
