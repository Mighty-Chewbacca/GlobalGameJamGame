using UnityEngine;
using System.Collections.Generic;

public class DialogueLines : MonoBehaviour
{
    Dictionary<string, string> Words = new Dictionary<string, string>();
    Dictionary<string, string> Phrases = new Dictionary<string, string>();

    // Use this for initialization
    void Start()
    {
        // Scene 1
        Words.Add("BedroomPhrase1Word1", "get");
        Words.Add("BedroomPhrase1Word2", "out");
        Words.Add("BedroomPhrase1Word3", "of");
        Words.Add("BedroomPhrase1Word4", "bed");

        Phrases.Add("BedroomPhrase1", "get out of bed");

        // Site B
        Words.Add("BLine1", "123123");
        Words.Add("BLine2", "123123");

        // Site C
        Words.Add("CLine1", "123123");
        Words.Add("CLine2", "123123");
    }

    // Update is called once per frame
    void Update()
    {

    }

    string getWord(string key)
    {
        return Words[key];
    }

    bool compareWords(string[] order, int phraselength)
    {
        // List chosen words in order 
        string input = order[0];
        for (int i = 1; i < phraselength; i++)
        {
            input = input + order[i];
        }
        return false;
    }
}
