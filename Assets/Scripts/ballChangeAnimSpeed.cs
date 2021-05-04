using System;
using UnityEngine;

public class ballChangeAnimSpeed : MonoBehaviour
{
    private Rigidbody _ballBody;
    private Animator _anim;

    private void Awake()
    {
        _ballBody = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }
    /// <summary>
    /// в зависимоти от движения вверх или вниз, задается величена speed для переключения ускоренного или замедленного вращения
    /// </summary>
    private void FixedUpdate()
    {
        _anim.SetFloat("speedUPDOWN", _ballBody.velocity.y); //переключение анимации ускорения/замедления
        _anim.SetInteger("speed", Convert.ToInt32(_ballBody.velocity.magnitude)); //переменная "скорости" для анимации среднего значения вращения
        if (_ballBody.velocity.y == 0) _anim.SetBool("NotUporDown", true); //переменная для условия перехода от ускорения/замедления к простому вращению
        else _anim.SetBool("NotUporDown", false);
    }
}
