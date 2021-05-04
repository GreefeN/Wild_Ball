using System.Collections;
using UnityEngine;

namespace WildBall
{
    public class BridgeLeverScript : MonoBehaviour
    {
        [SerializeField] private GameObject bridge; //мост для вращения
        [SerializeField] private playerController player;
        [SerializeField] private InterfaceScript _interface;
        private Rigidbody body; //rigidbody для доступа к constraints

        private void Awake()
        {
            body = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            bridge.transform.rotation = transform.rotation;
        }

        private void OnCollisionEnter(Collision collision)
        {
            body.constraints = RigidbodyConstraints.None; //добавляем на случай повторного толчка рычага, если в этот момент он еще "заморожен"
        }

        private void OnCollisionExit(Collision collision)
        {
            body.constraints = RigidbodyConstraints.FreezeRotationY; //при потере контакта с рычагом, фиксируется вращение по Y
            StartCoroutine(WaitLevelPositionBack());
        }

        /// <summary>
        /// задержка возвращения рычага к изначальной позиции
        /// </summary>
        /// <returns></returns>
        private IEnumerator WaitLevelPositionBack()
        {
            yield return new WaitForSeconds(3.0f);
            body.constraints = RigidbodyConstraints.None; //отменяем заморозку вращения рычага, для воздействия "пружины" в hinge joint
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) //выполняется если в триггере игрок
            {
                player.readyRotate = true; //возможность игрока вращать
                _interface.ActivateHintRotate(player.readyRotate); //метод включает подсказку в области вращения рычага
            }            
        }

        private void OnTriggerExit(Collider other)
        {
            player.readyRotate = false; //выключает возможность игрока вращать
            _interface.ActivateHintRotate(player.readyRotate); ////метод выключает подсказку в области вращения рычага
        }
    }
}

