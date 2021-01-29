using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    //il faut que les énigmes soit toutes finis pour sortir du labyrinthe
    public int puzzleToDo=4;
    public int puzzleDone=0;
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleDone == puzzleToDo)
        {
            //
        }
    }
}
