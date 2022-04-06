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

    // Update is called once per frame
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
