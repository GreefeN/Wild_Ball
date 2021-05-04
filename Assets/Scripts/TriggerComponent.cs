using UnityEngine;
using UnityEngine.Events;

namespace WildBall
{
    [RequireComponent(typeof(Collider))]
    public class TriggerComponent : MonoBehaviour
    {
        [SerializeField] private UnityEvent action; // действие при срабатывании триггера

        /// <summary>
        /// при срабатывании триггера, выполняет метод помещенный в action
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) action.Invoke(); //проверяет Тэг объекта в other и выполняет действие
        }
    }
}

