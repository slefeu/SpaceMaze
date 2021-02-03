using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    public static PlayerHandler _instance;
    public List<GameObject> lifesDisplay;
    public GameObject door;
    public int life = 3;
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager._instance.end)
        {
            door.active = false;
        }
        if (life == 3)
        {
            for (int i = 0; i < life; i++)
            {
                lifesDisplay[i].SetActive(true);
            }
        }
        else if (life == 2)
        {
            lifesDisplay[2].SetActive(false);
        }
        else if (life == 1)
            lifesDisplay[1].SetActive(false);
        
        if (life<=0)
        {
            lifesDisplay[0].SetActive(false);
            Debug.Log("the end");
            SceneManager.LoadScene(3);
            Destroy(this.gameObject);
        }
    }
}
