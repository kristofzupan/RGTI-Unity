using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject restart;
    [SerializeField] Text checkpoints;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text timer;
    [SerializeField] TextMeshProUGUI finalScore;
    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGameOver()
    {
        gameOverScreen.SetActive(true);
        finalScore.text = timer.text;

        /*timer.setActive(false);
        restart.setActive(false);
        checkpoints.setActive(false); */



    }
}
