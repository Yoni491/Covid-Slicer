using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class FruitScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.y < -5)
         {
               Destroy(gameObject);
         }

        transform.Rotate(new Vector3(1, 0.4f));
    }

    void OnCollisionEnter(Collision collision)
    {
          //Vector3 collisionNormal = (collision.transform.position - transform.position).normalized;
          //float playerCollisionSpeed = Vector3.Dot(collisionNormal, this.GetComponent<Rigidbody>().velocity);
          //if (playerCollisionSpeed < 0) { playerCollisionSpeed = 0; }

          //float otherCollisionSpeed = Vector3.Dot(-collisionNormal, collision.rigidbody.velocity);
          //if (otherCollisionSpeed < 0) { otherCollisionSpeed = 0; }

          //if (otherCollisionSpeed > playerCollisionSpeed)
          //{
         //}
         InGamePanel.updateScore(1);
         Destroy(gameObject);
     }
}
