using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    //donne un id aux jukebox qui va déterminer l'ordre ainsi que le mot
    public int id;
    public string word;
    public Text display;
    public GameObject children;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        display.text = word;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (this.GetComponentInParent<JukeboxPuzzle>().positions[0] == 0 || this.GetComponentInParent<JukeboxPuzzle>().positions[0] == id)
            {
                this.GetComponentInParent<JukeboxPuzzle>().positions[0] = id;
                children.GetComponent<MeshRenderer>().material = this.GetComponentInParent<JukeboxPuzzle>().mat[1];

            }

            else if (this.GetComponentInParent<JukeboxPuzzle>().positions[1] == 0 || this.GetComponentInParent<JukeboxPuzzle>().positions[1] == id)
            {
                this.GetComponentInParent<JukeboxPuzzle>().positions[1] = id;
                children.GetComponent<MeshRenderer>().material = this.GetComponentInParent<JukeboxPuzzle>().mat[1];
            }

            else if (this.GetComponentInParent<JukeboxPuzzle>().positions[2] == 0 || this.GetComponentInParent<JukeboxPuzzle>().positions[2] == id)
            {
                this.GetComponentInParent<JukeboxPuzzle>().positions[2] = id;
                children.GetComponent<MeshRenderer>().material = this.GetComponentInParent<JukeboxPuzzle>().mat[1];
            }

            else if (this.GetComponentInParent<JukeboxPuzzle>().positions[3] == 0 || this.GetComponentInParent<JukeboxPuzzle>().positions[3] == id)
            {
                this.GetComponentInParent<JukeboxPuzzle>().positions[3] = id;
                children.GetComponent<MeshRenderer>().material = this.GetComponentInParent<JukeboxPuzzle>().mat[1];
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        display.text = "";
    }
}

