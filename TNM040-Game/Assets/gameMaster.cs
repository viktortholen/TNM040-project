using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameMaster : MonoBehaviour {

    public int points;
    public TextMeshProUGUI PointScore;
    public GameObject Grid;


    int childs;

    private void Start()
    {
        Time.timeScale = 1;
          childs = Grid.transform.childCount;
    }

private void Update()
    {
      
        //pointsText = ("Points: " + points);
        PointScore.text = "Score: " + points + "/" + childs;
            

      
    }
}
