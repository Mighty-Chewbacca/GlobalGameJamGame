using UnityEngine;
using System.Collections.Generic;

public class DialogueLines : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Dictionary<string, string> Lines = new Dictionary<string, string>();

        // Site A
        Lines.Add("ALine1", "123123");
        Lines.Add("ALine2", "123123");

        // Site B
        Lines.Add("BLine1", "123123");
        Lines.Add("BLine2", "123123");

        // Site C
        Lines.Add("CLine1", "123123");
        Lines.Add("CLine2", "123123");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
