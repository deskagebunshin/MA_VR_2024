using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BallCounter : MonoBehaviour
{

    private int numberOfBalls;
    public TextMeshPro ballCounterText;
    private void OnTriggerEnter(Collider possibleBall)
    {
        if(possibleBall.gameObject.tag == "Ball")
        {
            numberOfBalls++;
            Destroy(possibleBall.gameObject);
            Debug.Log("Ball Entered total balls = " + numberOfBalls );
            ballCounterText.text = "Balls: " + numberOfBalls;
            ballCounterText.color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f));
        }
    }

}
