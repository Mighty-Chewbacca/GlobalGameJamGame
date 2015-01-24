using UnityEngine;
using System.Collections;

public class SwitchScenes : MonoBehaviour {
	//number to represent each scene
	//next scene just adds one to the current one
	//10 scenes in total


	public int currentScene;

	public int storedvalueforeachscene;

	void Awake()
	{
		DontDestroyOnLoad (this);
	}

	void Start () 
	{
		currentScene = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (currentScene == 1) 
		{
			Application.LoadLevel(1);
		}

		if (currentScene == 2) 
		{
			Application.LoadLevel(2);
		}

		if (currentScene == 3) 
		{
			Application.LoadLevel(3);
		}

//		if (currentScene == 4) 
//		{
//			Application.LoadLevel(4);
//		}
//
//		if (currentScene == 5) 
//		{
//			Application.LoadLevel(5);
//		}
//
//		if (currentScene == 6) 
//		{
//			Application.LoadLevel(6);
//		}
//
//		if (currentScene == 7) 
//		{
//			Application.LoadLevel(7);
//		}
//
//		if (currentScene == 8) 
//		{
//			Application.LoadLevel(8);
//		}
//
//		if (currentScene == 9) 
//		{
//			Application.LoadLevel(9);
//		}
//
//		if (currentScene == 10) 
//		{
//			Application.LoadLevel(10);
//		}
	}

	public void LoadNextScene()
	{
		currentScene++;
	}

	public void BackToStart()
	{
		currentScene = 1;
	}

	public int GetCurrentScene()
	{
		return currentScene;
	}
}
