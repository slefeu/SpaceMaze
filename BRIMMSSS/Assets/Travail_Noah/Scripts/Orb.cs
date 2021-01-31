using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orb : MonoBehaviour
{
    public Text text;

    void OnTriggerStay(Collider other)
    {
        text.text = "NO ONE  IS  AS  DEAF  AS  \n THOSE  WHO  DO  NOT  LISTEN";
    }

    void OnTriggerExit(Collider other)
    {
        text.text = "";
    }
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player" && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
