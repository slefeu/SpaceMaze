using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            timer += Time.deltaTime;
            if (timer >= 3)
            {
                Application.Quit();
            }
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
