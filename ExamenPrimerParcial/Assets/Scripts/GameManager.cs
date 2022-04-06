using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager intance;
    public int lasangnas;

    void Start()
    {
        

    }

   
    void Update()
    {
        MakeSingleton();
       
    }

    void MakeSingleton()
    {
        if(intance !=null)
        {
            Destroy(gameObject);
        }

        else
        {
            intance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
