using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

    public int points;
    public Text PointScore;

    ////private void Start()
    ////{
    ////    PointScore = GetComponent<Text> ();
    ////}

    private void Update()
    {
        //pointsText = ("Points: " + points);
        PointScore.text = "Score: " + points;
        Debug.Log(points);
    }
}
