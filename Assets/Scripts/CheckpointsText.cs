using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointsText : MonoBehaviour
{
    public Text checkPointText;
    private int counterCheckpoints;
    // Start is called before the first frame update
    void Start()
    {
        counterCheckpoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counterCheckpoints = 0;
        if (Globals.checkpoint1)
        {
            counterCheckpoints++;
        }

        if (Globals.checkpoint2)
        {
            counterCheckpoints++;
        }

        if (Globals.checkpoint3)
        {
            counterCheckpoints++;
        }

        checkPointText.text = counterCheckpoints.ToString() + "/3"; 
    }
}
