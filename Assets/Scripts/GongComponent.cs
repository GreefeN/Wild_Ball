using UnityEngine;

namespace WildBall
{
    public class GongComponent : MonoBehaviour
    {
        [SerializeField] private Rigidbody bridge; //объект Мост
        private string tag = "Player"; //тег Игрок для сопоставления объекта коллизии
        private AudioSource gong; //источник звука удара гонга

        private void Awake()
        {
            gong = GetComponent<AudioSource>(); //получаем доступ к источнику звука на гонге
        }

        /// <summary>
        /// действия при столновении с гонгом
        /// </summary>
        /// <param name="collision"></param>
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(tag)) //проверяется Тег объекта коллизии
            {
                gong.Play(); //воспроизводится звук гонга
                bridge.isKinematic = false; //отключается кинематик свойство моста
            }
        }
    }
}

