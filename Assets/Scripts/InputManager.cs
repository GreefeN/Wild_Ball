using UnityEngine;

namespace WildBall
{
    [RequireComponent(typeof(playerController))]
    public class InputManager : MonoBehaviour
    {
        private readonly string HORIZONTAL_AXIS = "Horizontal";
        private readonly string VERTICAL_AXIS = "Vertical";
        private Vector3 direction; //направление движения
        private playerController controller; //доступ к методам контроля игрока
        public bool pressedE; //переменная факта нажатия клавиши Е

        private void Awake()
        {
            controller = GetComponent<playerController>();
        }

        void Update()
        {
            float hor = Input.GetAxis(HORIZONTAL_AXIS); //получаем значение для лево-право
            float ver = Input.GetAxis(VERTICAL_AXIS); //получаем значение для вперед-назад
            direction = new Vector3(hor, 0, ver).normalized; //получаем нормализованный вектор движения(направление движения)

            pressedE = Input.GetKey(KeyCode.E); //получение нажатия клавиши Е
        }

        private void FixedUpdate()
        {
            controller.MovementPlayer(direction); //с интервалом FixedUpdate вызываем метод движения из playerController
        }
    }
}

