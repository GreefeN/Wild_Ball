using System.Collections;
using UnityEngine;

namespace WildBall
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private playerController player; //контроллер игрока хранящий состояния игрока
        private InterfaceScript _interface;
        private bool pause; //состояние паузы
        public int countBonus = 0; //количество собранных алмазов

        private void Awake()
        {
            _interface = GetComponent<InterfaceScript>();
        }

        private void Update()
        {
            _interface.countBonus.text = countBonus.ToString();
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
            ChangeStatusPlayer();
            yield return new WaitForSeconds(0.5f);
            Time.timeScale = 0;
            _interface.ChangeCanvas(2);
        }

        /// <summary>
        /// изменяет состояния игрока
        /// </summary>
        private void ChangeStatusPlayer()
        {
            player.playerBody.isKinematic = !player.playerBody.isKinematic; //отключает воздействие на тело игрока
            player.DeathPlayer = !player.DeathPlayer; //делает игрока мертвым            
        }
    }
}

