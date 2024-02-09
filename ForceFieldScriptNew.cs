using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldScriptNew : MonoBehaviour
{
    public Vector2 _forcevec = new Vector2 (100,0);
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerLight"))
        {
            // other.gameObject._isunderFF = true;
            // other.gameObject.forcefield_vec = _forcevec;
            player_light pl = other.gameObject.GetComponent<player_light>();
            pl._isunderFF=true;
            pl.forcefield_vec = _forcevec;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerLight"))
        {
            player_light pl = other.gameObject.GetComponent<player_light>();
            pl._isunderFF=false;
            // pl.forcefield_vec = _forcevec;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PlayerLight"))
        {
            player_light pl = other.gameObject.GetComponent<player_light>();
            pl.forcefield_vec = _forcevec;
        }
    }
}
