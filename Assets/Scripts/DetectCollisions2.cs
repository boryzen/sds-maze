using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions2 : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip audioClip = null;
    public AudioClip audioClipBall = null;
    public AudioSource source;
    void Start()
    {
        source.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            source.clip = audioClip;
            source.Play();
        }
        else if(other.gameObject.tag == "Ball")
        {
            source.clip = audioClipBall;
            source.Play();
        }
            
    }


}
