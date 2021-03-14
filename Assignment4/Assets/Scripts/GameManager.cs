using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public GameManager gm;

    public Animator animator;
    public void EndGame()
    {

        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
    }

    public void RestartLevel()
    {
        PickLives.playerLives--;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("Game Saved!");
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Debug.Log("Loaded Game w/" + data.currScore + " " + data.currLives);
        Score.PinCount = data.currScore;
        PickLives.playerLives = data.currLives;
        ShowVal.tryz = data.currTime;
        Rotator.rSpeed = data.currRSpeed;
        Pin.pSpeed = data.currPSpeed;

    }

    public void SaveAsJSON()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        string json = JsonUtility.ToJson(data);
        Debug.Log("Saving as JSON: " + json);
    }
}
