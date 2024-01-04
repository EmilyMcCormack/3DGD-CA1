using UnityEngine;

public class EggItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Egg"))
        {
            GameVariables.eggCount += 1;
            Destroy(gameObject);
        }
    }
}