using UnityEngine;

public class ButterItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Butter"))
        {
            GameItems.butterCount += 1;
            GameItems.ingredientCount += 1;
            Destroy(gameObject);
        }
    }
}
