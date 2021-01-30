using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public static LeverManager _instance;
    //toutes les 5 listes :
    public List<int> firstPattern;
    public List<int> secondPattern;
    public List<int> thirdPattern;
    public List<int> fourthPattern;
    public List<int> fifthPattern;
    public List<int> leverID;
    public List<GameObject> levers;
    public List<int> answer;
    private int rand;
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance = null)
        {
            _instance = this;
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
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < leverID.Count; i++)
        {
            if (answer[i]==0) 
            {
                return;
            }
        }
        if (answer == leverID)
            GameManager._instance.Coroutine();
        else
            Player._instance.life--;
    }
}
