using UnityEngine;

namespace WildBall
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform player; // для получения текущего положения player
        private Vector3 offset; //смещение

        private void Start()
        {
            offset = transform.position - player.position; //вычисляем смещение
        }

        private void FixedUpdate()
        {
            transform.position = player.position + offset; //переназначаем с интервалом FixedUpdate новое положение камеры
        }
    }
}

