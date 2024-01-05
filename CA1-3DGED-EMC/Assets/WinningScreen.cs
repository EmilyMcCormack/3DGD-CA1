using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameManager gameManager;
    private float timer = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameItems.ingredientCount >= 4)
        {
            timer += Time.deltaTime;

            if (timer >= 3)
            {
                gameManager.Win();
            }
        }
    }


}
