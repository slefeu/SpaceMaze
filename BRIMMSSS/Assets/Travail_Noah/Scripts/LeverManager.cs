using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public static LeverManager Lever_instance;
    //toutes les 5 listes :
    public List<int> firstPattern;
    public List<int> secondPattern;
    public List<int> thirdPattern;
    public List<int> fourthPattern;
    public List<int> fifthPattern;

    public List<int> leverID;
    public List<GameObject> levers;
    public List<int> answer;
    private List<int> save;
    public List<Material> image;
    public List<GameObject> feedback;
    private int rand;
    private int randID;
    // Start is called before the first frame update
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
        rand = Random.Range(1, 5);
        switch (rand)
        {
            case 1:
                leverID = firstPattern;
                break;
            case 2:
                leverID = secondPattern;
                break;
            case 3:
                leverID = thirdPattern;
                break;
            case 4:
                leverID = fourthPattern;
                break;
            case 5:
                leverID = fifthPattern;
                break;
        }
        
        save = leverID;
        Debug.Log(save);
        for (int i = 0; i <= leverID.Count+1; i++)
        {
            randID = Random.Range(1, save.Count) - 1;
            levers[i].GetComponent<LeverScripts>().value = save[randID];
            Debug.Log(save[randID]);
            save.RemoveAt(randID);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < answer.Count; i++)
        {
            if (answer[i] == 0)
            {
                return;
            }
        }
        if (answer[0] < answer[1] && answer[1] < answer[2] && answer[2] < answer[3] && answer[3] < answer[4])
        {    GameManager._instance.Coroutine();
        Debug.Log("a"); }
        else
        {
            Player._instance.life--;
            for (int i = 0; i < answer.Count; i++)
            {
                answer[i] = 0;
                levers[i].GetComponent<MeshRenderer>().enabled=true;
                levers[i].GetComponent<LeverScripts>().feedback.SetActive(false);
            }
            Debug.Log("e");
        }
            

    }
}
