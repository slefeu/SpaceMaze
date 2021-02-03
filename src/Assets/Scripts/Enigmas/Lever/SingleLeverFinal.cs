using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleLeverFinal : OnClickEvent
{
    public int id;
    public GameObject feedback;
    // Start is called before the first frame update
    void Update()
    {

    }
    public override void OnHover()
    {
    }
    public override void OnClick()
    {
        gameObject.GetComponent<Animation>().Play();
        if (LeverFinal.lever_instance.answer[0] == 0 || LeverFinal.lever_instance.answer[0] == this.id)
        {
            LeverFinal.lever_instance.answer[0] = this.id;

        }
        else if (LeverFinal.lever_instance.answer[1] == 0 || LeverFinal.lever_instance.answer[1] == this.id)
        {
            LeverFinal.lever_instance.answer[1] = this.id;
        }
        else if (LeverFinal.lever_instance.answer[2] == 0 || LeverFinal.lever_instance.answer[2] == this.id)
        {
            LeverFinal.lever_instance.answer[2] = this.id;
        }
        else if (LeverFinal.lever_instance.answer[3] == 0 || LeverFinal.lever_instance.answer[3] == this.id)
        {
            LeverFinal.lever_instance.answer[3] = this.id;
        }
        else if (LeverFinal.lever_instance.answer[4] == 0 || LeverFinal.lever_instance.answer[4] == this.id)
        {
            LeverFinal.lever_instance.answer[4] = this.id;
        }
    }
}
