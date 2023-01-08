using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField] GameObject difficultyMenu;
    [SerializeField] GameObject instructionsMenu;

    void Start()
    {
        difficultyMenu.SetActive(false);
        instructionsMenu.SetActive(false);
    }

    public void PlayGame ()
    {
        Debug.Log("start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void changeDifficulty ()
    {
        difficultyMenu.SetActive(true);
    }

    public void ChangeToEasy ()
    {
        Globals.dificulty = 1;
        difficultyMenu.SetActive(false);
    }

    public void ChangeToMedium()
    {
        Globals.dificulty = 2;
        difficultyMenu.SetActive(false);
    }

    public void ChangeToHard()
    {
        Globals.dificulty = 3;
        difficultyMenu.SetActive(false);
    }

    public void Instructions()
    {
        instructionsMenu.SetActive(true);
    }

    public void ExitInstructions()
    {
        instructionsMenu.SetActive(false);
    }
}
