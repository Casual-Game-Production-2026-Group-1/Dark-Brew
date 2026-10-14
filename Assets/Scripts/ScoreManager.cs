using System.Collections;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    //Scoremanager
    public static ScoreManager Instance { get; private set; }

    public int coffeeScore = 0;
    public int dialogueScore = 0;
    public int stars = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            addDialogue();
        }
        if (coffeeScore == 1)
        {
            stars = 1;
        }
        else if (dialogueScore == 1)
        {
            stars = 1;
        }
        if (coffeeScore == 1 && dialogueScore == 1)
        {
            stars = 3;
        }
    }

    public void addCoffee()
    {
        coffeeScore += 1;
    }

    public void addDialogue()
    {
        dialogueScore += 1;
    }
}
