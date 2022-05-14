using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instructions : MonoBehaviour
{
    StopWatch stopWatch;

    private int goalCounter = 0;

    public Text disvar;

    public ChildCount ChildCount;
    private int myInt;

    // Start is called before the first frame update
    void Start()
    {
        disvar.text = ("Find the the coins \n" +
           "Coins left: " + myInt + "\n" +
           "Ear control: \n" +
           "2 - forward \n" +
           "x - back \n" +
           "f - freeze/unfreeze \n " +
           "space - reset     ");

        GameEvents.instance.onCollisionChangeText += ChangeInstruction;
    }

    private void Update()
    {
        myInt = (ChildCount.childCounter) - 1;



    }

    private void ChangeInstruction()
    {
        goalCounter += 1;

        if (goalCounter != 7)
        {
            disvar.text = ("Find the the coins \n" +
            "Coins left: "+ myInt + "\n" +
            "Ear control: \n" +
            "2 - forward \n" +
            "x - back \n" +
            "f - freeze/unfreeze \n "+
            "space - reset     "); }
    
        if (goalCounter == 7) {
            TimeSpan time = TimeSpan.FromSeconds(stopWatch.currentTime);
            disvar.text = ("GAME COMPLETED\n" +
            "Time:\n" +
            time.ToString(@"mm\:ss\:fff"));


        }
    }
}
