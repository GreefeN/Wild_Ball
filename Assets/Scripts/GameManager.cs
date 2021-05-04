using System.Collections;
using UnityEngine;

namespace WildBall
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private playerController player; //контроллер игрока хранящий состояния игрока
        private InterfaceScript _interface;
        private bool pause; //состояние паузы

        private void Awake()
        {
            _interface = GetComponent<InterfaceScript>();
        }

        /// <summary>
        /// функция Паузы игры
        /// </summary>
        public void StartOrPause()
        {
            pause = !pause;
            if (pause)
            {
                Time.timeScale = 0;
                _interface.ChangeCanvas(1);
            }
            else
            {
                Time.timeScale = 1;
                _interface.ChangeCanvas(0);
            }
        }

        /// <summary>
        /// метод вызывающий корутину экрана смерти
        /// </summary>
        public void Death()
        {
            StartCoroutine(WaitingDeath());
        }

        /// <summary>
        /// корутина экрана смерти
        /// </summary>
        /// <returns></returns>
        private IEnumerator WaitingDeath()
        {
            yield return new WaitForSeconds(0.1f);
            Time.timeScale = 0;
            _interface.ChangeCanvas(2);
        }
    }
}

