using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orbtext : MonoBehaviour
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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
