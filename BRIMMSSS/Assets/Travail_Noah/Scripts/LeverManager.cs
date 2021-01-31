using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public static LeverManager Lever_instance;
    //toutes les 5 listes :
    /*public List<int> firstPattern;
    public List<int> secondPattern;
    public List<int> thirdPattern;
    public List<int> fourthPattern;
    public List<int> fifthPattern;
    
    public List<int> leverID;
    */
    public bool end = false;
    public List<GameObject> levers;
    public List<int> answer;
    /*private List<int> save;
    public List<Material> image;
    public List<GameObject> feedback;
    private int rand;
    private int randID;
    */// Start is called before the first frame update
    void Awake()
    {
        if (Lever_instance == null)
        {
            Lever_instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(this.gameObject);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!end)
        {
            for (int i = 0; i < answer.Count; i++)
            {
                if (answer[i] == 0)
                {
                    return;
                }
            }
            if (answer[0] == 2 && answer[1] == 1 && answer[2] == 4 && answer[3] == 3)
            {
                GameManager._instance.Coroutine();
                end = true;
            }
            else
            {
                Player._instance.life--;
                for (int i = 0; i < answer.Count; i++)
                {
                    answer[i] = 0;
                    Debug.Log(answer[i]);
                    levers[i].GetComponent<MeshRenderer>().enabled = true;
                    levers[i].GetComponent<SingleLeverFinal>().feedback.SetActive(false);
                }
            }


        }

    }
}
