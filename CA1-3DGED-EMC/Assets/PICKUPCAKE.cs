using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PICKUPCAKE : MonoBehaviour
{
    bool picked = false;
    bool inrange;
    public GameObject cake;
    // Start is called before the first frame update
    void Start()
    {
        picked = false;
        inrange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (picked == false)
        {
            cake.SetActive(true);
        }
        if(inrange == true && Input.GetKeyDown(KeyCode.E)) 
        {
            picked =true;
            if (picked == true) { cake.SetActive(false); }
        }
        Debug.Log("Inrange " + inrange);
    }
    private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                inrange = true;
            }
        }    
}
