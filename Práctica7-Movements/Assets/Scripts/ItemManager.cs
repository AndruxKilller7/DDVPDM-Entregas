using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (colision.CompareTag("Lasaña"))
        {
            GameManager.intance.lasangnas += 1;
        }
    }

}
