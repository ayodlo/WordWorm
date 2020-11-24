using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    GameSession gameSession;
    TextMeshProUGUI scoreDisplay;
    string currentScore;

    // Start is called before the first frame update
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        scoreDisplay = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        currentScore = gameSession.getScore().ToString();
        scoreDisplay.text = currentScore;
        Debug.Log(scoreDisplay.text);
        Debug.Log(currentScore);
    }
}
