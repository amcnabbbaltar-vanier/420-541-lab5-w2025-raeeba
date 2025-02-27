using UnityEngine;

public class HitDetectorRight : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyController enermyController = other.GetComponent<EnemyController>();
            if (enemyController != null)
            {
                enemyController.GotHit();
            }
        }
    }
}
