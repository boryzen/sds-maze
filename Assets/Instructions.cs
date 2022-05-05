using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instructions : MonoBehaviour
{

    private int goalCounter = 0;

    public Text disvar;
    // Start is called before the first frame update
    void Start()
    {
        disvar.text = ("Use your mouse to move head\n" +
            "U to move forward\n" +
            "S to move backward\n" +
            "A to move left\n" +
            "D to move right\n" +
            "\n" +
            "Move to the first goal object: The beach ball");
        GameEvents.instance.onCollisionChangeText += ChangeInstruction;
    }

    private void ChangeInstruction()
    {
        goalCounter += 1;
        Debug.Log(goalCounter);
        if (goalCounter == 1) { 
            disvar.text = ("The goal of this game is to find the coins \n" +
                "The coins works as a audio beacon, revealing a coin sound\n" +
                "Notice how the sound level increases as you get closer\n" +
                "Find the 1st coin around the corner "); }
        
    }
}
