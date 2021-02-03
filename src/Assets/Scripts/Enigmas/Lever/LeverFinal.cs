using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverFinal : MonoBehaviour
{
    public static LeverFinal lever_instance;
    public List<int> answer;
    public List<GameObject> button;

    private bool Done;
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
        for (int i = 0; i < button.Count; i++)
        {
            if (answer[i] == 0)
            {
                return;
            }
        }

        if (Done)
            return;

        if (answer[0] == 2 && answer[1] == 1 && answer[2] == 4 && answer[3] == 3)
        {
            Done = true;
            GameManager._instance.Coroutine();
        }
        else
        {
            Done = true;
            PlayerHandler._instance.life--;
            for (int i = 0; i < answer.Count; i++)
            {
                answer[i] = 0;
            }
        }
            
    }
}
