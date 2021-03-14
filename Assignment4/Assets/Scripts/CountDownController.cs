using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownController : MonoBehaviour
{
    // public int countdownTime;
    public GameObject timeUpTextObject;
    public Text countdownDisplay;
    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        while(ShowVal.tryz >= 0)
        {
            countdownDisplay.text = ShowVal.tryz.ToString();

            yield return new WaitForSeconds(1f);

            ShowVal.tryz--;
            blah();
        }
    }

    public void blah()
    {
        if (ShowVal.tryz == 0)
        {
            timeUpTextObject.SetActive(true);
            Invoke("nxtLev", 5);
        }

    }

    public void nxtLev()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
