using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    private bool Paused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
            if (!Paused)
			{
                Paused = true;
                PauseMenu.SetActive(true);
                Time.timeScale = 0;

            } else if (Paused) {
                Paused = false;
                Time.timeScale = 1;
                PauseMenu.SetActive(false);
            }
		}


    }

	public void unPause()
	{
        Paused = false;
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    public void restart()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void quit()
	{
        Time.timeScale = 1;
        Application.Quit();
    }
}
