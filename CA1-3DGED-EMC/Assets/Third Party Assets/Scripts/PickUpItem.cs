using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Had a lot of difficulty with pickup scripts. Tried to use tutorials but they didn't end up working.
/*<https://www.youtube.com/watch?v=YlB9BlRIryk&ab_channel=GameAssetWorld>, Accessed On: <01/24>, Using Line Numbers: 6 - 39*/

/*public class PickUpItem : MonoBehaviour
{
    private Transform PickUpPoint;
    private Transform player;

    public float pickUpDistance;
    public float forceMulti;

    public bool readyToThrow;
    public bool itemIsPicked;

    private Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Astrounalt_Pink Variant").transform;
        PickUpPoint = GameObject.Find("PickUpPoint").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E) && itemIsPicked == true && readyToThrow)
        {
            forceMulti += 300 * Time.deltaTime; 
        }

        pickUpDistance = Vector3.Distance(player.position, transform.position);

        if(pickUpDistance <= 2)
        {
            if(Input.GetKeyDown(KeyCode.E) && itemIsPicked == false && PickUpPoint.childCount < 1)
            {
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<BoxCollider>().enabled = false;
                this.transform.position = PickUpPoint.position;
                this.transform.parent = GameObject.Find("PickUpPoint").transform;

                itemIsPicked = true;
                forceMulti = 0; 
            }
        }

        if(Input.GetKeyUp(KeyCode.E) && itemIsPicked == true)
        {
            readyToThrow = true; 

            if(forceMulti > 10)
            {
                rb.AddForce(player.transform.forward * forceMulti);
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<BoxCollider>().enabled = true;
                itemIsPicked = false;

                forceMulti = 0;
                readyToThrow = false; 
            }

            forceMulti = 0; 
        }
    }
}*/