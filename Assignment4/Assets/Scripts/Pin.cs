using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public int blahz = PickLives.playerLives;

    private bool isPinned = false;

    public static float pSpeed = 2000f;
    public Rigidbody2D rb;

    public void AdjustSpeed(float newSpeed)
    {
        pSpeed = newSpeed;
    }

    void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * pSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            Debug.Log("Hit");

            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
