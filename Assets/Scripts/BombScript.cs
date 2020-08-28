using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] Animator animator;
    private new AudioSource audio;
    // Start is called before the first frame update
    bool isSlashed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        audio.Play();
        animator.SetTrigger("isTouched");
        GetComponent<Rigidbody>().isKinematic=true;
        MainManager.LoseLife(1);
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + 3);
        //לעשות שהפצצה עושה destroy
    }
}
