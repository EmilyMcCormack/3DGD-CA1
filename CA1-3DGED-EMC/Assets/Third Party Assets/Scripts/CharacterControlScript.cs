/*<https://www.youtube.com/watch?v=7eAwVUsiqZU&t=512s&ab_channel=MattWester>, Accessed On: <01/24>, Using Line Numbers: 6 - 39*/

using UnityEngine;
using UnityEngine.AI; 

public class CharacterControlScript : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public Animator playerAnimator;
    public GameObject targetDest;

    CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint; 

            if(Physics.Raycast(ray, out hitPoint))
            {
                targetDest.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);
            }
        }

        if(player.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", true);
        }
        else if (player.velocity == Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", false);
        }
    }
}