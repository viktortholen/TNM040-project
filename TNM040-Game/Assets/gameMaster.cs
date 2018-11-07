using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

    public int points = 0;
    Text pointScore;

    private void Start()
    {
        pointScore = GetComponent<Text> ();
    }

    private void Update()
    {
        //pointsText = ("Points: " + points);
        pointScore.text = "Score: " + points;
        Debug.Log(points);
    }
}
