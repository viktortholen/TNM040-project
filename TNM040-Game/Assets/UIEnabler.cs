using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIEnabler : MonoBehaviour {

    public TextMeshProUGUI Score;

    private void Start()
    {
        Score.GetComponent<TextMeshProUGUI>();
        Score.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Score.GetComponent<TextMeshProUGUI>();
            Score.enabled = true;

        }
    }
}
