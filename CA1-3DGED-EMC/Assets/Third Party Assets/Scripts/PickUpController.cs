


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Had a lot of difficulty with pickup scripts. Tried to use tutorials but they didn't end up working. 
/*<https://www.youtube.com/watch?v=6bFCQqabfzo&t=332s&ab_channel=SpeedTutor>, Accessed On: <01/24>, Using Line Numbers: 6 - 39*/

/*public class PickUpController : MonoBehaviour
{
    [SerializeField] Transform PickUpPoint;
    private GameObject heldObj;
    private Rigidbody heldObjRB;

    [SerializeField] private float pickUpRange = 5.0f;
    [SerializeField] private float pickUpForce = 150.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
                {
                    PickUpObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }

        if (heldObj != null)
        {
            MoveObject();
        }
    }
    void MoveObject()
    {
        if (Vector3.Distance(heldObj.transform.position, PickUpPoint.position) > 0.1f)
        {
            Vector3 moveDirection = (PickUpPoint.position - PickUpPoint.transform.position);
            heldObjRB.AddForce(moveDirection * pickUpForce);
        }
    }
    void PickUpObject(GameObject pickObj)
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRB.transform.parent = PickUpPoint;
            heldObj = pickObj;
        }
    }

    void DropObject()
    {
        heldObjRB.useGravity = true;
        heldObjRB.drag = 1;
        heldObjRB.constraints = RigidbodyConstraints.None;

        heldObj.transform.parent = null;
        heldObj = null;
    }
}*/