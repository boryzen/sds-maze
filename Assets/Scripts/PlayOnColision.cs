using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnColision : MonoBehaviour
{

    [Header("Add the audio clip")]
    public AudioClip clip;

    private bool leftWallTester = true;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = clip;   
    }

    // Update is called once per frame
    private void OnTriggerEnter(UnityEngine.Collider collision) 
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (leftWallTester)
            {
                leftWallTester = false;
                if (!GetComponent<AudioSource>().isPlaying)
                {
                    GetComponent<AudioSource>().Play();
                }
            }
        }
    }
    private void OnTriggerExit(UnityEngine.Collider collision)
    {
        leftWallTester = true;
    }
}
