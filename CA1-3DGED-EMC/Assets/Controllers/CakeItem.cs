using UnityEngine;

public class CakeItem : MonoBehaviour
{
    //public GameObject Egg;
    //bool isEggDestroyed = false;
    //public GameObject blood;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Egg"))
        {
          //  GameVariables.eggCount += 1;
            Destroy(gameObject);
            //isEggDestroyed = true;

        }
        /*
        else if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("blood") && isEggDestroyed == true)
        {
            GameVariables.bloodCount += 1;
            Destroy(gameObject);
        }
        */
    }
}