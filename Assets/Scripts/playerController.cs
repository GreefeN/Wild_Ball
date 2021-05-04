using UnityEngine;

namespace WildBall
{
    [RequireComponent(typeof(Rigidbody))]

    public class playerController : MonoBehaviour
    {
        [SerializeField, Range(0, 30)] private float speed = 2;
        private Rigidbody playerBody;
        public bool readyPressE; //состояние игрока (готов/не готов нажать Е)
        public bool readyRotate; //готовность игрока вращать объект

        private void Awake()
        {
            playerBody = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// метод движения игрока принимающий направление движения
        /// </summary>
        /// <param name="dir">направление движения</param>
        public void MovementPlayer(Vector3 dir)
        {
            playerBody.AddForce(dir * speed);
        }
    }
}

