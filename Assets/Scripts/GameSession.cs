using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    // References
    public string word;
    CheckDictionary dictionary;

    private void Start()
    {
        dictionary = FindObjectOfType<CheckDictionary>();
    }

    public void addLetter(string letter)
    {
        word += letter;
        Debug.Log(word);
        dictionary.checkWord(word);
    }
}
