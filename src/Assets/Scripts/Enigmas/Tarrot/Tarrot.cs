using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tarrot : OnClickEvent
{
    public int i;
    public string text;
    public GUIStyle style;

    private Rect UIPosition = new Rect(-1000, -1000, -1, -1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        UIPosition = new Rect(0, Screen.height / 2 + 10, Screen.width, 20);
    }
    public void OnTriggerExit(Collider other)
    {
        UIPosition = new Rect(-1000, -1000, -1, -1);
    }
    // Update is called once per frame
    void Update()
    {
        UIPosition = new Rect(-1000, -1000, -1, -1);
    }
    public override void OnHover()
    {
        UIPosition = new Rect(0, Screen.height / 2 + 10, Screen.width, 20);
    }
    public override void OnClick()
    {
        gameObject.GetComponent<Animation>().Play();
        if (i == 0)
        {
            GameManager._instance.Coroutine();
        }
        else
        {
            PlayerHandler._instance.life--;
        }
    }
    void OnGUI()
    {
        GUI.Label(UIPosition, text, style);
    }
}
