using UnityEngine;

public class ButterItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Butter"))
        {
            GameVariables.butterCount += 1;
            Destroy(gameObject);
        }
    }
}
