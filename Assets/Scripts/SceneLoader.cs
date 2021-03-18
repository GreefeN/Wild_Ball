using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// выбор уровня игры
    /// </summary>
    /// <param name="btn"></param>
    public void ChooseLevel(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
