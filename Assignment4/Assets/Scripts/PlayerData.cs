using UnityEngine;

[System.Serializable]
public class PlayerData
{
   public int currScore;
    public int currLives;
    public int currTime;
    public float currRSpeed;
    public float currPSpeed;

    public PlayerData(GameManager gm)
    {
        currLives = PickLives.playerLives;
        currScore = Score.PinCount;
        currTime = ShowVal.tryz;
        currRSpeed = Rotator.rSpeed;
        currPSpeed = Pin.pSpeed;

    }
}