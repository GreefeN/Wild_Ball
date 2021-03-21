using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishTriggerScript : MonoBehaviour
{
    [SerializeField] private SceneLoader _sceneLoader;

    /// <summary>
    /// при срабатывании триггера финиша, вызов загрузки следующего уровня
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        _sceneLoader.LoadNextLevel();
    }
}
