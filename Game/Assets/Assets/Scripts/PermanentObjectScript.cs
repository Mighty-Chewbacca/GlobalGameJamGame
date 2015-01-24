using UnityEngine;
using System.Collections;

public class PermanentObjectScript : MonoBehaviour {

	//this script is going to permenantly going to be in the game
	//created in the menu and kept throughout



	void awake()
	{
		DontDestroyOnLoad (this);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
