using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeAnim : MonoBehaviour
{
    private Animator anima;
    private void Start()
    {
        anima = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Asteroid"))
        {
            anima.SetTrigger("death");
        }
                 
    }
    private void Explode()
    {
        Destroy(this.gameObject);
    }
}
