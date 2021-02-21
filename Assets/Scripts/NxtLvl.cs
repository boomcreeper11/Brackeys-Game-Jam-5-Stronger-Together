using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NxtLvl : MonoBehaviour
{

	public GameObject LevelLoader;

	public void OnTriggerEnter2D(Collider2D other)
	{
			nextLevel();
	}

	
	void nextLevel()
    {
		LevelLoader.GetComponent<LevelLoader>().LoadNextLevel();
    }
}
