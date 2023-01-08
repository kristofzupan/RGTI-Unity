using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame() {
        Time.timeScale = 1.0f;
        Globals.checkpoint1 = false;
        Globals.checkpoint2 = false;
        Globals.checkpoint3 = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Back()
    {
        Time.timeScale = 1.0f;
        Globals.checkpoint1 = false;
        Globals.checkpoint2 = false;
        Globals.checkpoint3 = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
