using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class FruitScript : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
         if(transform.position.y < -5)
         {
              MainManager.LoseLife(1);
              Destroy(gameObject);
         }

        transform.Rotate(new Vector3(1, 0.4f));
    }
    void OnCollisionEnter(Collision collision)
    {
         InGamePanel.updateScore(1);
         Destroy(gameObject);
     }
}
