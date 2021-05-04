using UnityEngine;

namespace WildBall
{
    public class InteractiveObjects : MonoBehaviour
    {
        [SerializeField] private Animator door; //дверь которая должна открыться
        [SerializeField] private Animator lever; //рычаг открытия двери
        [SerializeField] private InterfaceScript _interface;
        private InputManager input; //считывание ввода игрока
        private playerController player; //хранит состояния игрока
        private Light light; //цвет рычага(красный не активирован, зелёный активирован)
        public bool pushed; //активирован/не активирован рычаг

        private void Awake()
        {
            light = GetComponent<Light>(); //получаем доступ к компоненту света
        }

        /// <summary>
        /// действия при попадании игрока в триггер
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (!pushed) //если рычаг не нажат
            {
                player = other.GetComponent<playerController>(); //получаем playerController игрока для изменения playerController.readyPressE
                player.readyPressE = true; //можно нажать Е 
            }
        }

        /// <summary>
        /// действия при нахождении игрока в триггере
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerStay(Collider other)
        {
            input = other.GetComponent<InputManager>(); //получаем InputManager компонент на игроке
            _interface.ActivateHint(player.readyPressE); //включаем подсказку при playerController.readyPressE = true
            if (input.pressedE) //проверяем нажатие клавиши Е
            {
                door.SetBool("OpenDoor", true); //запускает анимацию открытия двери
                lever.SetBool("Pushed", true);  //запускает анимацию нажатия рычага

                if (player.readyPressE) pushed = !pushed; //при input.pressedE = true  и playerController.readyPressE = true
                player.readyPressE = false; //отключает игроку готовность нажатия Е(переменная из playerController передается в interfaceScript для отключения подсказки нажатия E)

                light.color = new Color(0, 1, 0);   //меняет цвет подсветки на рычаге на зеленый(соответствует нажатому рычагу)
            }
        }

        /// <summary>
        /// действия при выходе игрока из триггера
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            player.readyPressE = false; //если игрок покинул триггер меняет состояние готовности нажатия Е
            _interface.ActivateHint(player.readyPressE); //отключает подсказку
        }
    }
}

