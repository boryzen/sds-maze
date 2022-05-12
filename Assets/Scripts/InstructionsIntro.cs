using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InstructionsIntro : MonoBehaviour
{



    public Text disvar = null;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public GameObject page6;




    private int pageCounter = 1;


    private int pageAmount = 6;



    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            pageCounter += pageCounter;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            pageCounter = pageCounter-1;
        }
        if (pageCounter < 1)
        {
            pageCounter = 1;
        }
        if (pageCounter > pageAmount)
        {
            pageCounter = pageAmount;
        }
        ChangeInstructionIntro();

        if (Input.GetKeyDown(KeyCode.N))
        {
            if (pageCounter == pageAmount)
            {
                Scene2();
            }
            
        }
        
    }

    private void ChangeInstructionIntro()
    {
        if (pageCounter == 1)
        {
            disvar.text = page1.GetComponent<Text>().text;
            
        }
        if (pageCounter == 2)
        {
            disvar.text = page2.GetComponent<Text>().text;
        }

        if (pageCounter == 3)
        {

            disvar.text = page3.GetComponent<Text>().text;
        }

        if (pageCounter == 4)
        {
            disvar.text = page4.GetComponent<Text>().text;
        }

        if (pageCounter == 5)
        {
            disvar.text = page5.GetComponent<Text>().text;
        }
        if (pageCounter == 6)
        {
            disvar.text = page6.GetComponent<Text>().text;
        }


    }

    private Func<List<GameObject>> onRequestNumberOfPages;
    public void SetOnRequestNumberOfPages(Func<List<GameObject>> returnEvent)
    {

        onRequestNumberOfPages = returnEvent;
    }

    public List<GameObject> RequestNumberOfPages()
    {
        if (onRequestNumberOfPages != null)
        {
            return onRequestNumberOfPages();
        }
            

        return null;
    }

    private static void Scene2()
    {
        SceneManager.LoadScene("The labirinth");
    }
}


