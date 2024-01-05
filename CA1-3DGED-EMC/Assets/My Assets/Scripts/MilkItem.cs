using UnityEngine;

public class MilkItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Milk"))
        {
            GameItems.milkCount += 1;
            GameItems.ingredientCount += 1;
            Destroy(gameObject);
        }
    }
}
