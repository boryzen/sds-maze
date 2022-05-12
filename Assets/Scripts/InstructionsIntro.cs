using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstructionsIntro : MonoBehaviour
{

    private int goalCounter = 0;

    public Text disvar;

    private int myInt;

    // Start is called before the first frame update
    void Start()
    {
        disvar.text = ("Use your mouse to move head\n" +
            "U to move forward\n" +
            "S to move backward\n" +
            "A to move left\n" +
            "D to move right\n" +
            "Ear control: \n" +
            "2 - forward \n" +
            "x - back \n" +
            "f - freeze/unfreeze \n " +
            "space - reset ear"
                            );
        
    }

    private void Update()
    {
        
    }

    private void ChangeInstruction()
    {

    }
}
