using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterEvent : MonoBehaviour
{

    // References
    TextMesh textMesh;
    GameSession gameSession;
    private void Start()
    {
        textMesh = gameObject.GetComponent<TextMesh>();
        gameSession = FindObjectOfType<GameSession>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameSession.addLetter(textMesh.text);
        Destroy(gameObject);
    }
}
