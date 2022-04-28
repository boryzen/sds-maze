using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCount : MonoBehaviour
{

    public StopWatch StopWatch;
    private bool gameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {

            if (transform.childCount == 0)
            {
                StopWatch.StopTimer();
                Debug.Log("Game completed");
                gameOver = true;
            }
        }
    }
}
