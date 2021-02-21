using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNext : MonoBehaviour
{
    public GameObject LevelLoader;

    void Nxtlvl()
    {
        LevelLoader.GetComponent<LevelLoader>().LoadNextLevel();
    }
}