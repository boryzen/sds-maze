using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    bool timerActive = false;
    public float currentTime = 0;
    //public Text disvar;

    // Start is called before the first frame update
    void Start()
    {

        

       //StartTimer();

    }

    // Update is called once per frame
    void Update()
    {



        if (timerActive == true)
        {
            currentTime += Time.deltaTime;
            
        }

      //  TimeSpan time = TimeSpan.FromSeconds(currentTime);
  //      disvar.text = time.ToString(@"mm\:ss\:fff");


    }

    public void StartTimer()
    {
        timerActive = true;
        Debug.Log("StartTimer");
    }
    public void StopTimer()
    {
        timerActive &= false;
        Debug.Log("StopTimer");
    }

}
