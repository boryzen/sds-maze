using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions2 : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip audioClip = null;

    public AudioSource source;

    public AudioClip audioClip2;

    void Start()
    {
        source.clip = audioClip;

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = audioClip2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin" || other.gameObject.tag == "Ball")
            GetComponent<AudioSource>().Play();

    }


}
