using UnityEngine;

public class EggItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Egg"))
        {
            GameItems.eggCount += 1;
            GameItems.ingredientCount += 1;
            Destroy(gameObject);
        }
    }
}