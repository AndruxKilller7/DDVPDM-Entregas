using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemManager : MonoBehaviour
{
    public Text container;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        container.text = GameManager.intance.lasangnas.ToString();  
        
    }


    void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Lasa�a"))
        {
            GameManager.intance.lasangnas += 1;
        }
    }

}
