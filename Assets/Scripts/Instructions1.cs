using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Instructions1 : MonoBehaviour
{
    public StopWatch StopWatch;

    private int goalCounter = 0;

    public Text disvar;

    public ChildCount ChildCount;
    private int myInt;

    // Start is called before the first frame update
    void Start()
    {
        disvar.text = ("For the first maze, the floating ear is deactivated\n" +
           "The timer starts when you hit the beach ball\n" +
           "Please note your time in the questionare when completed\n"+
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

        if (Input.GetKeyDown(KeyCode.N))
        {
            if (goalCounter == 7)
            {
                Scene3();
            }

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
            "Coins left: "+ myInt); }
    
        if (goalCounter == 7) {
            TimeSpan time = TimeSpan.FromSeconds(StopWatch.currentTime);
            disvar.text = ("LEVEL COMPLETED\n" +
            "Time:\n" +
            time.ToString(@"mm\:ss\:fff") +
            "\nThe level is now finished\n" +
            "Please note your time in the questionary\n"+
            "Press <N> for the next level");

          
            StopWatch.StopTimer();
            Debug.Log(StopWatch.currentTime);

            

        }
    }
    private static void Scene3()
    {
        SceneManager.LoadScene("The labirinth");
    }
}
