using System.Collections;
using UnityEngine;

namespace WildBall
{
    public class BonusScript : MonoBehaviour
    {
        [SerializeField] private GameObject burstParticle; //частицы взрыва
        [SerializeField] private GameObject diamond; //объект с мешем самого бонуса
        [SerializeField] private GameManager gameManager; //компонент хранящий количество собарнных бонусов
        private Collider bonus; //родительский объект бонуса, роль триггера
        

        private void Awake()
        {
            bonus = GetComponent<Collider>();
        }

        private void OnTriggerEnter(Collider other)
        {
            gameManager.countBonus++; //добавляем к счетчику собранных бонусов
            StartCoroutine("waitingDestroy"); //запускаем карутину удаления бонуса со сцены
        }

        /// <summary>
        /// выключает мэш, включает взрыв, после задержки удаляет объект бонуса
        /// </summary>
        /// <returns></returns>
        private IEnumerator waitingDestroy()
        {
            Destroy(diamond);
            burstParticle.SetActive(true);
            yield return new WaitForSeconds(1);
            Destroy(bonus.gameObject);
        }
    }
}

