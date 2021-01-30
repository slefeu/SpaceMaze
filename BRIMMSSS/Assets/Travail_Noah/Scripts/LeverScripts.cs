using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.tag!=null && other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
            //    LeverManager[0]=
            }
        }
    }
}
