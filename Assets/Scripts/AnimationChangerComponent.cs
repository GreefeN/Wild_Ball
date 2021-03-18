using UnityEngine;

public class AnimationChangerComponent : MonoBehaviour
{
    private Animator _anim;
        
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void ChangeAnimation()
    {
        _anim.SetInteger("animTransition", Random.Range(1,3));
    }
}
