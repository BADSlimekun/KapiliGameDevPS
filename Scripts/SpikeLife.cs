using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeLife : MonoBehaviour
{
    public Rigidbody2D rb;
    public string PlayerTagL;
    public string PlayerTagH;
    public Vector2 vel;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = vel.normalized*speed;
        Destroy(this.gameObject, 4f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        Debug.Log("Collidedededededede");
        if (other.tag == PlayerTagL)
        {
            Destroy(this.gameObject);
            
        }
    }
}
