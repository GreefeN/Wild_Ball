using UnityEngine;

namespace WildBall
{
    public class WaveBridgeScript : MonoBehaviour
    {
        private Animator anim;

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        private void OnTriggerEnter(Collider other)
        {
            anim.SetTrigger("isTriggered");
        }
    }
}

