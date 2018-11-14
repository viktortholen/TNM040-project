using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameMaster : MonoBehaviour {

    public int points;
    public TextMeshProUGUI PointScore;
    public TextMeshProUGUI YouWinMessage;
    ////private void Start()
    ////{
    ////    PointScore = GetComponent<Text> ();
    ////}

    private void Update()
    {
        //pointsText = ("Points: " + points);
        PointScore.text = "Score: " + points + "/17";

        if (points == 17)
        {
            YouWinMessage.text = "Find The Portal!";
        }
        
        Debug.Log(points);

      
    }
}
