using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnColision : MonoBehaviour
{

    [Header("Add the audio clip")]
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = clip;   
    }

    // Update is called once per frame
    private void OnTriggerStay(UnityEngine.Collider collision) 
    {   
        Debug.Log("Triggered");
        if(!GetComponent<AudioSource>().isPlaying)
            GetComponent<AudioSource>().Play();
    }
        
}
