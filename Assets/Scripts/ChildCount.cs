using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCount : MonoBehaviour
{

    public StopWatch StopWatch;
    private bool gameOver = false;
    public int childCounter;

    // Update is called once per frame
    void Update()
    {
        childCounter = transform.childCount;

        if (!gameOver)
        {

            if (childCounter == 0)
            {
                StopWatch.StopTimer();
                Debug.Log("Game completed");
                Debug.Log(StopWatch.currentTime);
                gameOver = true;
            }
        }
    }
}
