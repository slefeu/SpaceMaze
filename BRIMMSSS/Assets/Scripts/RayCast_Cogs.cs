using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast_Cogs : MonoBehaviour
{

    private bool BigCog = false;
    private bool MediumCog = false;
    private bool SmallCog = false;
    private bool IsCarrying = false;

    public Rect position;
    public Texture2D SmallCrosshair;
    public Texture2D crosshair;
    public GUIStyle UIStyle;
    public Rect CogUI = new Rect(10, 10, 100, 20);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void CheckClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null && hit.distance < 2)
                {
                    if (hit.transform.gameObject.tag == "bigcog" && !IsCarrying)
                    {
                        BigCog = true;
                        IsCarrying = true;
                        hit.transform.gameObject.active = false;

                    }
                    if (hit.transform.gameObject.tag == "mediumcog" && !IsCarrying)
                    {
                        MediumCog = true;
                        IsCarrying = true;
                        hit.transform.gameObject.active = false;

                    }
                    if (hit.transform.gameObject.tag == "smallcog" && !IsCarrying)
                    {
                        SmallCog = true;
                        IsCarrying = true;
                        hit.transform.gameObject.active = false;
                    }
                    if (hit.transform.gameObject.tag == "cogpointbig" && IsCarrying)
                    {
                        if (BigCog)
                        {
                            BigCog = false;
                            IsCarrying = false;
                            hit.transform.GetChild(0).gameObject.active = true;
                        }
                        else
                        {
                            Player._instance.life--;
                        }
                    }
                    if (hit.transform.gameObject.tag == "cogpointsmall" && IsCarrying)
                    {
                        if (SmallCog)
                        {
                            SmallCog = false;
                            IsCarrying = false;
                            hit.transform.GetChild(0).gameObject.active = true;
                        }
                        else
                        {
                            Player._instance.life--;
                        }
                    }
                    if (hit.transform.gameObject.tag == "cogpointmedium" && IsCarrying)
                    {
                        if (MediumCog)
                        {
                            MediumCog = false;
                            IsCarrying = false;
                            hit.transform.GetChild(0).gameObject.active = true;
                        } else
                        {
                            Player._instance.life--;
                        }
                    }
                }
            }
        }
    }

    void CheckHover()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) {
            if (hit.transform != null && hit.distance < 2)
            {
                if (hit.transform.gameObject.tag == "bigcog" && IsCarrying == false)
                {
                    position = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
                }
                else if (hit.transform.gameObject.tag == "mediumcog" && IsCarrying == false)
                {
                    position = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
                }
                else if (hit.transform.gameObject.tag == "smallcog" && IsCarrying == false)
                {
                    position = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
                }
                else if (hit.transform.gameObject.tag.StartsWith("cogpoint"))
                {
                    position = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
                }
            }
        }
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect((Screen.width - SmallCrosshair.width) / 2, (Screen.height - SmallCrosshair.height) / 2, SmallCrosshair.width, SmallCrosshair.height), SmallCrosshair);
        GUI.DrawTexture(position, crosshair);
        if (IsCarrying)
        {
            string text = "Currently holding : ";
            if (BigCog)
                text += "Big Cog";
            if (SmallCog)
                text += "Small Cog";
            if (MediumCog)
                text += "Medium Cog";
            GUI.Label(CogUI, text);

        }

    }

    // Update is called once per frame
    void Update()
    {
        position = new Rect(-1, -1, -1, -1);
        CheckClick();
        CheckHover();
    }
}
