using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    [SerializeField]
    Transform []fruits = null;
     float timer = 0;
    float timeToEject;
    int randomFruitIndex;

    void Start()
    {
        timeToEject = UnityEngine.Random.Range(2, 3);
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>= timeToEject)
        {
            timer = 0;
            timeToEject = UnityEngine.Random.Range(1, 2);

            Transform fruit;
            fruit = LaunchFruit();
        }
    }
    private Transform LaunchFruit()
    {
        Transform fruit;
        randomFruitIndex = UnityEngine.Random.Range(0, fruits.Length - 1);
        fruit = Instantiate(fruits[randomFruitIndex]);
        fruit.position = transform.position + new Vector3(0, 0, UnityEngine.Random.Range(-1, 1));
        fruit.GetComponent<Rigidbody>().AddForce(new Vector3(0, 400, 0));
        return fruit;
    }
}
