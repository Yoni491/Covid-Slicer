using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    [SerializeField]
    Transform []fruits = null;
    [SerializeField]
    Transform bomb = null;
     float timer = 0;
    float timeToEject;
    int randomFruitIndex;
    int numOfFruitToLaunch;

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
            LaunchFruits();
        }
    }
    private void LaunchFruits()
    {
        Transform fruit;
        Transform ejectedBomb;
        numOfFruitToLaunch = UnityEngine.Random.Range(1, 4);
        for (int i = 0; i < numOfFruitToLaunch; i++)
        {
            randomFruitIndex = UnityEngine.Random.Range(0, fruits.Length - 1);
            fruit = Instantiate(fruits[randomFruitIndex]);
            fruit.position = transform.position + new Vector3(0, 0, UnityEngine.Random.Range(-1.2f, 1.2f));
            fruit.GetComponent<Rigidbody>().AddForce(new Vector3(0, UnityEngine.Random.Range(350, 450), 0));
        }
        if (UnityEngine.Random.Range(1, 4) < 2)
        {
            ejectedBomb = Instantiate(bomb);
            ejectedBomb.position = transform.position + new Vector3(0, 0, UnityEngine.Random.Range(-1.2f, 1.2f));
            ejectedBomb.GetComponent<Rigidbody>().AddForce(new Vector3(0, UnityEngine.Random.Range(350, 450), 0));
        }
    }
}
