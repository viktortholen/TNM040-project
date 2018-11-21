using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameMaster : MonoBehaviour {

    public int points;
    public TextMeshProUGUI PointScore;
    public TextMeshProUGUI YouWinMessage;
    public GameObject Grid;

    ////private void Start()
    ////{
    ////    PointScore = GetComponent<Text> ();
    ////}
   


    
   

    private void Update()
    {
        int  childs = Grid.transform.childCount;
        //pointsText = ("Points: " + points);
        PointScore.text = "Score: " + points + "/" + childs;
            
        Debug.Log(childs);
        if (points == 17)
        {
            YouWinMessage.text = "Find The Portal!";
        }
        
        Debug.Log(points);

      
    }
}
