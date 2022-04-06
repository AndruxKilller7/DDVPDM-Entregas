using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;


public class SkinManager : MonoBehaviour
{

    private SpriteResolver resolvers;

    public 

    void Start()
    {
        resolvers = GetComponent<SpriteResolver>();
    }

  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            resolvers.SetCategoryAndLabel("Head", "Skull");
        }
    }
}
