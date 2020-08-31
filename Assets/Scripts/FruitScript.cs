using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class FruitScript : MonoBehaviour
{
    [SerializeField]
    private GameObject fruitHalf1 = null;
    [SerializeField]
    private GameObject fruitHalf2 = null;
    private new AudioSource audio;
    bool isSlashed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
         if(transform.position.y < -5)
         {
            if(!isSlashed)
                MainManager.LoseLife(1);
            Destroy(gameObject);
         }

        transform.Rotate(new Vector3(1, 0.4f));
    }
    void OnCollisionEnter(Collision collision)
    {
        audio.time = 1;
        audio.Play();
        InGamePanel.updateScore(1);
        fruitHalf1.SetActive(true);
        fruitHalf2.SetActive(true);
        Vector3 fruitHalfsVec = fruitHalf1.transform.position - fruitHalf2.transform.position;
        fruitHalfsVec=Vector3.Normalize(fruitHalfsVec);
        fruitHalfsVec=Vector3.Scale(new Vector3(100, 100, 100), fruitHalfsVec);
        fruitHalf1.GetComponent<Rigidbody>().AddForce(fruitHalfsVec);
        fruitHalf2.GetComponent<Rigidbody>().AddForce(Vector3.Scale(new Vector3(-1, -1, -1), fruitHalfsVec));
        GetComponent<MeshRenderer>().enabled = false;
        isSlashed = true;
        GetComponent<MeshCollider>().enabled = false;
        InGamePanel.addCombo(1);
    }

}
