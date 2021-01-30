using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;
    //il faut que les énigmes soit toutes finis pour sortir du labyrinthe
    public int puzzleToDo=4;
    public int puzzleDone=0;
    private GameObject _puzzleDidDraw;
    private Text _puzzleDidDrawText;
    public GameObject _endTrigger;
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
            _puzzleDidDraw = GameObject.FindGameObjectWithTag("TextEvent");
            _puzzleDidDrawText = _puzzleDidDraw.GetComponent<Text>();
            _puzzleDidDraw.SetActive(false);
            _endTrigger = GameObject.FindGameObjectWithTag("EndTrigger");
            _endTrigger.SetActive(false);
        }
        else
            Destroy(this);
    }
    private IEnumerator OnEventActivate()
    {
        puzzleDone++;
        _puzzleDidDraw.SetActive(true);
        if (puzzleDone < 3)
            _puzzleDidDrawText.text = ("You stil have" + (4 - puzzleDone) + "more puzzle to do before you can escape");
        if (puzzleDone == 4)
        {
            _puzzleDidDrawText.text = ("You finished all the puzzles, get out of here");
            _endTrigger.SetActive(true);
            yield return new WaitForSeconds(3f);
            _puzzleDidDraw.SetActive(false);
            yield return 0;
        }


    }
    public void Coroutine()
    {
        StartCoroutine(OnEventActivate());
    }

}
