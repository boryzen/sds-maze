using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    bool timerActive = false;
    float currentTime;
    public Text disvar;

    // Start is called before the first frame update
    void Start()
    {

        currentTime = 0;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            StartTimer();
        }

        if (Input.GetKeyUp(KeyCode.N))
        {
            StopTimer();
        }


        if (timerActive == true)
        {
            currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        disvar.text = time.ToString(@"mm\:ss\:fff");


    }

    public void StartTimer()
    {
        timerActive = true;
    }
    public void StopTimer()
    {
        timerActive &= false;   
    }

}
