using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    [SerializeField] private Transform targetPosition;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = targetPosition.position;
    }
}
