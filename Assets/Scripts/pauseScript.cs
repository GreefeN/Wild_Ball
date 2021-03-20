using UnityEngine;

public class pauseScript : MonoBehaviour
{
    [SerializeField] private GameObject[] interfaceCanvases;    //2 канваса, 1 под кнопку паузы, 2 экран паузы
    private bool pause; //состояние паузы
    private GameObject _currentCanvas;

    private void Awake()
    {
        _currentCanvas = interfaceCanvases[0];
        _currentCanvas.SetActive(true);
    }

    /// <summary>
    /// функция Паузы игры
    /// </summary>
    public void StartOrPause()
    {
        pause = !pause;
        if (pause)
        {
            Time.timeScale = 0;
            ChangeCanvas(1);
        }
        else
        {
            Time.timeScale = 1;
            ChangeCanvas(0);
        }
    }

    /// <summary>
    /// смена Canvas игры на Canvas pause
    /// </summary>
    /// <param name="i"></param>
    private void ChangeCanvas(int i)
    {
        _currentCanvas.SetActive(false);
        _currentCanvas = interfaceCanvases[i];
        _currentCanvas.SetActive(true);
    }
}
