using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    // public list<GateScript> gts;
    // Start is called before the first frame update
    public bool _condition;
    private Animator anim;
    public SwitchScript ss;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ss._switchState==2 || _condition){
        Debug.Log("Hello");
        anim.SetBool("GateBool",true);
        gameObject.GetComponent<Collider2D>().isTrigger = true;
        }
    }

}
