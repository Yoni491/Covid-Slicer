using System.Collections;
using System.Collections.Generic;
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
        transform.Rotate(new Vector3(1, 0.4f));
    }
    void OnCollisionEnter(Collision collision)
    {
        Vector3 collisionNormal = (collision.transform.position - transform.position).normalized;
        float playerCollisionSpeed = Vector3.Dot(collisionNormal, this.GetComponent<Rigidbody>().velocity);
        if (playerCollisionSpeed < 0) { playerCollisionSpeed = 0; }

        float otherCollisionSpeed = Vector3.Dot(-collisionNormal, collision.rigidbody.velocity);
        if (otherCollisionSpeed < 0) { otherCollisionSpeed = 0; }

        if (otherCollisionSpeed > playerCollisionSpeed)
        {
            Destroy(gameObject);
        }
        
    }
}
