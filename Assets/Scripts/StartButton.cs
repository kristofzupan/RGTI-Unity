using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void PlayGame ()
    {
        Debug.Log("start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
