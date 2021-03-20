using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// загрузка выбранного уровня игры
    /// </summary>
    /// <param name="btn"></param>
    public void ChooseLevel(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    /// <summary>
    /// рестарт уровная, с выходом из паузы
    /// </summary>
    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// загрузка главного меню, с выходом из паузы
    /// </summary>
    public void LoadMainMenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
