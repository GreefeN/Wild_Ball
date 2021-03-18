﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _menuCanvases;
    private GameObject _currentCanvas;
    
    

    private void Awake()
    {
        _currentCanvas = _menuCanvases[0];
        _currentCanvas.SetActive(true);
    }

    /// <summary>
    /// смена главного меню и выбора уровня
    /// </summary>
    public void ChangeMenuScreen()
    {
        _currentCanvas.SetActive(false);
        if (_currentCanvas == _menuCanvases[0])
        {
            _currentCanvas = _menuCanvases[1];
            _currentCanvas.SetActive(true);
        }
        else
        {
            _currentCanvas = _menuCanvases[0];
            _currentCanvas.SetActive(true);
        }
    }
   
   

    

}
