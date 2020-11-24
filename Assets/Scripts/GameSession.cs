using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    // References
    public string word;
    public int score = 0;
    public int wordLength;
    CheckDictionary dictionary;

    private void Start()
    {
        dictionary = FindObjectOfType<CheckDictionary>();
    }

    public void addLetter(string letter)
    {
        word += letter;
        wordLength = dictionary.checkWord(word);
        if (wordLength > 0)
        {
            score += calculateScore(wordLength);
        }
        Debug.Log(score);
    }

    public int calculateScore(int length)
    {
        return (length * length * 10);
    }
    public int getScore()
    {
        return score;
    }
}
