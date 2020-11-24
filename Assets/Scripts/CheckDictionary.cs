using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;



public class CheckDictionary : MonoBehaviour
{
    private string[] validWords;
    private int index;
    [SerializeField] string searchTerm = "Dog";
    private void Awake()
    {
        // Load scrabble dictionary text file from resources
        TextAsset sourceText = (TextAsset)Resources.Load("scrabbleWords", typeof(TextAsset));
        // Convert dictionary to an array and trim off extra white space
        validWords = sourceText.text.Split("\n"[0])
        .Select(s => s.Trim())
        .Where(s => s != String.Empty)
        .ToArray();
    }

    public void Start()
    {

    }

    public int checkWord(string word)
    {
        // Find index of searchTerm and return negative value if not found
        index = Array.BinarySearch<string>(validWords, word, StringComparer.OrdinalIgnoreCase);
        if (index >= 0)
        {
            Debug.Log("FOUND " + word + " AT INDEX " + index);
            return word.Length;
        }
        else
        {
            Debug.Log("DID NOT FIND " + word);
            return 0;
        }
    }

    public void Update()
    {
    }


}
