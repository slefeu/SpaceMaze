using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeboxPuzzle : MonoBehaviour
{
    //donne un id et un mot aux jukebox, si ils sont actionnés dans l'ordre, alors la clé apparaitra
    public List<GameObject> JukeBox;
    [SerializeField] private List<int> jukeBoxeIds;
    public List<string> usedWords;
    private int randID;
    private int id;
    private int randWords;
    public List<int> positions;
    public Material[] mat;
    public bool done = false;
    public GameObject signal;
    public List<GameObject> feedback;
    // Start is called before the first frame update
    void Start()
    {
        randWords = Random.Range(0, 12);
        CompleteWords();

        for (int i = 0; i < JukeBox.Count; i++)
        {

            randID = Random.Range(1, JukeBox.Count - i) - 1;
            id = jukeBoxeIds[randID];
            JukeBox[i].GetComponent<NewBehaviourScript>().id = id;
            JukeBox[i].GetComponent<NewBehaviourScript>().word = usedWords[id - 1];
            Debug.Log(jukeBoxeIds[randID]);
            jukeBoxeIds.RemoveAt(randID);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (positions[0] != 0 && positions[1] != 0 && positions[2] != 0 && positions[3] != 0 && !done)
        {
            if (positions[0] < positions[1] && positions[1] < positions[2] && positions[2] < positions[3])
            {
                done = true;
                GameManager._instance.Coroutine();
                //énigme validé : verrou ouvert
            }
            else
            {
                for (int i = 0; i < feedback.Count; i++)
                {
                    feedback[i].GetComponent<MeshRenderer>().material = mat[0];
                    positions[i] = 0;
                }
                Player._instance.life--;
            }
        }
        if (done)
        {
            signal.GetComponent<MeshRenderer>().material = mat[1];
        }

    }
    private void CompleteWords()
    {
        switch (randWords)
        {
            case 0:
                usedWords = new List<string> { "Life", "You", "Your", "Moving" };
                break;
            case 1:
                usedWords = new List<string> { "Life", "Not", "Be", "Reality"};
                break;
            case 2:
                usedWords = new List<string> { "Life", "First", "It", "You" };
                break;
            case 3:
                usedWords = new List<string> { "Life", "Life", "It", "And" };
                break;
            case 4:
                usedWords = new List<string> { "Life", "When", "Other", "What" };
                break;
            case 5:
                usedWords = new List<string> { "Respect", "Others", "Respect", "You" };
                break;
            case 6:
                usedWords = new List<string> { "Respect", "Others", "Hates", "You" };
                break;
            case 7:
                usedWords = new List<string> { "Are", "The", "Saddest", "Ones" };
                break;
            case 8:
                usedWords = new List<string> { "Are", "Funniest", "Happiest", "Are" };
                break;
            case 9:
                usedWords = new List<string> { "You", "Life", "Future", "Study" };
                break;
            case 10:
                usedWords = new List<string> { "You", "Past", "Future", "Study" };
                break;
            case 11:
                usedWords = new List<string> { "Life", "But", "It", "Complicated" };
                break;
            case 12:
                usedWords = new List<string> { "Winning", "But", "It", "Complicated" };
                break;
        }

    }
}