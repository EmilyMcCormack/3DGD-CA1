using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winUI;
    public GameObject progressBar; 
   
    // Start is called before the first frame update
    void Start()
    {
        winUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        winUI.SetActive(true);
        progressBar.SetActive(false);
    }
}
