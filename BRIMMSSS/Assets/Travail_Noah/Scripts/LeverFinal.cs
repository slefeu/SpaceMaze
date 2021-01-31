using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverFinal : MonoBehaviour
{
    public static LeverFinal lever_instance;
    public List<int> answer;
    public List<GameObject> levers;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        if (lever_instance == null)
        {
            lever_instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < levers.Count; i++)
        {
            if (answer[i] == 0)
            {
                return;
            }
        }
        if (answer[0] == 2 && answer[1] == 1 && answer[2] == 4 && answer[3] == 3)
        {
            GameManager._instance.Coroutine();
        }
        else
        {
            Player._instance.life--;
            for (int i = 0; i < answer.Count; i++)
            {
                answer[i] = 0;
                levers[i].GetComponent<MeshRenderer>().enabled = true;
                levers[i].GetComponent<LeverScripts>().feedback.SetActive(false);
            }
        }
            
    }
}
