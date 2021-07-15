using UnityEngine;
using UnityEngine.UI;

namespace WildBall
{
    public class InterfaceScript : MonoBehaviour
    {
        [SerializeField] private GameObject[] interfaceCanvases; //3 канваса: [0] под кнопку паузы, [1] экран паузы, [2] экран смерти        
        private GameObject _currentCanvas; //текущий Canvas
        public GameObject hint; //объект содержащий текст подсказки
        public Text textHint;
        public Text countBonus;

        private void Awake()
        {
            _currentCanvas = interfaceCanvases[0];
            _currentCanvas.SetActive(true);
        }

        /// <summary>
        /// смена текущего Canvas игры/паузы/смерти
        /// </summary>
        /// <param name="i"></param>
        public void ChangeCanvas(int i)
        {
            _currentCanvas.SetActive(false);
            _currentCanvas = interfaceCanvases[i];
            _currentCanvas.SetActive(true);
        }

        /// <summary>
        /// активирует подсказку press E
        /// </summary>
        /// <param name="b"></param>
        public void ActivateHint(bool b)
        {
            if (b) //проверяет playerController.readyPressE
            {
                textHint.text = "Press E";
                hint.SetActive(true); //включает подсказку если playerController.readyPressE = true
            }
            else hint.SetActive(false); //отключает подсказку если playerController.readyPressE = false
        }

        /// <summary>
        /// активирует подсказку Rotate Me возле рычага вращения
        /// </summary>
        /// <param name="b"></param>
        public void ActivateHintRotate(bool b)
        {
            if (b) //проверяет playerController.readyRotate
            {
                textHint.text = "Rotate Me";
                hint.SetActive(true); //включает подсказку если playerController.readyRotate = true
            }
            else hint.SetActive(false); //отключает подсказку если playerController.readyRotate = false
        }
    }
}


