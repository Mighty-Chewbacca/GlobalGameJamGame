using UnityEngine;
using System.Collections;

public class HolderScript : MonoBehaviour {

    bool occupied = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setOccupied(bool isoccupied)
    {
        occupied = isoccupied;
    }

    public bool getOccupied()
    {
        return occupied;
    }
}
