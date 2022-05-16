using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instructions : MonoBehaviour
{
    public StopWatch StopWatch;

    private int goalCounter = 0;

    public Text disvar;

    public ChildCount ChildCount;
    private int myInt;

    // Start is called before the first frame update
    void Start()
    {
        disvar.text = ("Find the coins, but this time is the floating ear activated\n" +
           "The timer starts when you hit the beach ball\n" +
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

        
    if (Input.GetKey("escape"))
    {
        Application.Quit();
    }
        

    }

    private void ChangeInstruction()
    {
        goalCounter += 1;
        Debug.Log(goalCounter);
        if (goalCounter == 1)
        {
            StopWatch.StartTimer();
            
        }

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
            TimeSpan time = TimeSpan.FromSeconds(StopWatch.currentTime);
            disvar.text = ("GAME COMPLETED\n" +
            "Time:\n" +
            time.ToString(@"mm\:ss\:fff") +
            "\nThe game is now finished - Thanks for playing\n" +
            "Please note your times in the questionary\n\n"+
            "Press <esc> to exit the game");

          
            StopWatch.StopTimer();
            Debug.Log(StopWatch.currentTime);

            

        }


    }

}
