using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownController : MonoBehaviour
{
    public int countTime;
    public TextMeshProUGUI coundownDisplay;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(CountodownToStart());
    }

    IEnumerator CountodownToStart()
    {
        while (countTime > 0)
        {
            coundownDisplay.text = countTime.ToString();
            yield return new WaitForSeconds(1f);
            countTime--;
        }

        coundownDisplay.text = "Go!";
        Globals.countDown = false;
        yield return new WaitForSeconds(1f);
        coundownDisplay.gameObject.SetActive(false);
    }
}
