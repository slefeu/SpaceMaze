using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScripts : MonoBehaviour
{
    public int id;
    public int value;
    public GameObject feedback;
    public GameObject sign;
    // Start is called before the first frame update
    void Update()
    {
        sign.GetComponent<MeshRenderer>().material = LeverManager.Lever_instance.image[this.value-1];
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.tag!=null && other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                if (LeverManager.Lever_instance.answer[0] == 0 || LeverManager.Lever_instance.answer[0] == this.value)
                {
                    LeverManager.Lever_instance.answer[0] = this.value;
                    this.GetComponent<MeshRenderer>().enabled=false;
                    feedback.SetActive(true);

                }
                else if (LeverManager.Lever_instance.answer[1] == 0 || LeverManager.Lever_instance.answer[1] == this.value)
                {
                    LeverManager.Lever_instance.answer[1] = this.value;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
                else if (LeverManager.Lever_instance.answer[2] == 0 || LeverManager.Lever_instance.answer[2] == this.value)
                {
                    LeverManager.Lever_instance.answer[2] = this.value;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
                else if (LeverManager.Lever_instance.answer[3] == 0 || LeverManager.Lever_instance.answer[3] == this.value)
                {
                    LeverManager.Lever_instance.answer[3] = this.value;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
                else if (LeverManager.Lever_instance.answer[4] == 0 || LeverManager.Lever_instance.answer[4] == this.value)
                {
                    LeverManager.Lever_instance.answer[4] = this.value;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
            }
        }
    }
}
