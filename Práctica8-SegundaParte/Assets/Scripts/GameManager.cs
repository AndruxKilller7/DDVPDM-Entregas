using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager intance;
    public int lasangnas;

    public DatesP datesPlayer;
    public string nameCharacter;
    public int inteligencia;
    public int lasangas;
    public int agylity;
    public int force;



   


    void Start()
    {
       

    }

   
    void Update()
    {
        MakeSingleton();
        nameCharacter = datesPlayer.nameCharacter;
        inteligencia = datesPlayer.inteligencia;
        lasangas = datesPlayer.lasangas;
        agylity = datesPlayer.agylity;
        force = datesPlayer.force;


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
