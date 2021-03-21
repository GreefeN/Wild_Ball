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
        _anim.SetFloat("speed", _ballBody.velocity.y);
    }
}
