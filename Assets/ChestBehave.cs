using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBehave : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // play animator
            animator.SetTrigger("Open");
        }
    }
}
