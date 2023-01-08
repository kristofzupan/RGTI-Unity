using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class finishLine : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text timer;
    [SerializeField] TextMeshProUGUI finalScore;
    [SerializeField] Text result;

    private float GhostTime;
    private float PlayerTime;


    void Start()
    {
        gameOverScreen.SetActive(false);
        GhostTime = 0.0f;
        PlayerTime = 0.0f;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        if (other.tag == "Player")
        {
            if(Globals.checkpoint1 && Globals.checkpoint2 && Globals.checkpoint3)
            {
                PlayerTime = Time.time;
                if (PlayerTime > GhostTime)
                {
                    result.text = "You lost, the ghost finnished the race before you!";
                } else
                {
                    result.text = "You won! Congratulations!";
                }
                Time.timeScale = 0.0f;
                gameOverScreen.SetActive(true);
                finalScore.text = timer.text;
                timer.text = "timer";
                Globals.checkpoint1 = false;
                Globals.checkpoint2 = false;
                Globals.checkpoint3 = false;
            }
        } else if (other.tag != "Ghost")
        {
            Debug.Log("Ghost enter");
            GhostTime = Time.time;
        }

        
    }

}
