using UnityEngine;

public class MilkItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Milk"))
        {
            GameVariables.milkCount += 1;
            Destroy(gameObject);
        }
    }
}
