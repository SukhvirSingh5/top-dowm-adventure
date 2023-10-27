using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public AudioSource keySound;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Farmer"))
        {
            Debug.Log("obtained apple");
            keySound.Play();
            Destroy(this.gameObject); 
        }
    }
}