﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string name)
	{
		SceneManager.LoadScene (name);
	}
}
