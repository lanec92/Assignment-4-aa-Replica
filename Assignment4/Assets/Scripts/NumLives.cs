using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumLives : MonoBehaviour
{
    public Text livesText;

    void Update()
    {
        if (PickLives.playerLives == 0)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            livesText.text = PickLives.playerLives.ToString();

        }
    }
}