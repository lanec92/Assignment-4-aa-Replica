using UnityEngine;
using UnityEngine.UI;


public class PickLives : MonoBehaviour
{
    public Dropdown LifeDropDown;

    public static int playerLives;
    public static int recordLives;

    public void NumLives()
    {
        switch (LifeDropDown.value)
        {
            default:
                playerLives = 1;
                recordLives = 1;
                break;

            case 1:
                playerLives = 1;
                recordLives = 1;
                break;

            case 2:
                playerLives = 2;
                recordLives = 2;
                break;

            case 3:
                playerLives = 3;
                recordLives = 3;
                break;

        }
    }
}
