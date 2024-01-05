using UnityEngine;

public class BloodItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Blood"))
        {
            GameItems.bloodCount += 1;
            GameItems.ingredientCount += 1;
            Destroy(gameObject);
        }
    }
}
