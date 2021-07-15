using UnityEngine;

namespace WildBall
{
    [RequireComponent(typeof(Rigidbody))]

    public class playerController : MonoBehaviour
    {
        [SerializeField, Range(0, 500)] private float speed = 300;
        [SerializeField] private GameObject deathParticle; //частицы смерти игрока
        [SerializeField] private GameObject playerMesh; //визуальное отображение игрока
        public Rigidbody playerBody;
        public bool readyPressE; //состояние игрока (готов/не готов нажать Е)
        public bool readyRotate; //готовность игрока вращать объект
        public bool DeathPlayer; //состояние смерти игрока

        private void Awake()
        {
            playerBody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (DeathPlayer)
            {
                playerMesh.SetActive(false);
                deathParticle.SetActive(true);
            }
        }

        /// <summary>
        /// метод движения игрока принимающий направление движения
        /// </summary>
        /// <param name="dir">направление движения</param>
        public void MovementPlayer(Vector3 dir)
        {
            playerBody.AddForce(dir * speed * Time.fixedDeltaTime);
        }
    }
}

