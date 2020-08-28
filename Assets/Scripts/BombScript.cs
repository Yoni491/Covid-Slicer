using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        animator.SetTrigger("isTouched");
        GetComponent<Rigidbody>().isKinematic=true;
        MainManager.LoseLife(1);

        //להפעיל את הסאונד

    }
}
