using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bullet_destroyer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tank")
        {
            Destroy(collision.gameObject);
        }




        Destroy(gameObject);
    }


    
}
