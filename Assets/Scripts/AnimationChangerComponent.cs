using UnityEngine;

public class AnimationChangerComponent : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    /// <summary>
    /// передает сгенерированный int параметр в Animator
    /// </summary>
    public void ChangeAnimation()
    {
        _anim.SetInteger("animTransition", Random.Range(0, 3)); //0 - не менять анимацию, 1,2 - смена анимации
    }
}
