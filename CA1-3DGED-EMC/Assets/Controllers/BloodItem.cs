using UnityEngine;

public class BloodItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Blood"))
        {
            GameVariables.bloodCount += 1;
            Destroy(gameObject);
        }
    }
}
