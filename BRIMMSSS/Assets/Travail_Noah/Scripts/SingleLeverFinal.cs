using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleLeverFinal : MonoBehaviour
{
    public int id;
    public GameObject feedback;
    // Start is called before the first frame update
    void Update()
    {

    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.tag != null && other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                if (LeverManager.Lever_instance.answer[0] == 0 || LeverManager.Lever_instance.answer[0] == this.id)
                {
                    LeverManager.Lever_instance.answer[0] = this.id;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);

                }
                else if (LeverManager.Lever_instance.answer[1] == 0 || LeverManager.Lever_instance.answer[1] == this.id)
                {
                    LeverManager.Lever_instance.answer[1] = this.id;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
                else if (LeverManager.Lever_instance.answer[2] == 0 || LeverManager.Lever_instance.answer[2] == this.id)
                {
                    LeverManager.Lever_instance.answer[2] = this.id;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
                else if (LeverManager.Lever_instance.answer[3] == 0 || LeverManager.Lever_instance.answer[3] == this.id)
                {
                    LeverManager.Lever_instance.answer[3] = this.id;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
                else if (LeverManager.Lever_instance.answer[4] == 0 || LeverManager.Lever_instance.answer[4] == this.id)
                {
                    LeverManager.Lever_instance.answer[4] = this.id;
                    this.GetComponent<MeshRenderer>().enabled = false;
                    feedback.SetActive(true);
                }
            }
        }
    }
}
