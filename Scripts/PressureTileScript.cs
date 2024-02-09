using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureTileScript : MonoBehaviour
{
    public bool _tileBool;
    // public bool _forceFieldtile;
    // public SpikeProjectile _shootScript;
    // public DynamicSpikeScript _dynamicSpikeScript;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CrateTag") || other.gameObject.CompareTag("PlayerHeavy")){
            _tileBool = true;
            // ShootScriptBool(true);
            // PopSpike(true);
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CrateTag") || other.gameObject.CompareTag("PlayerHeavy")){
            _tileBool = false;
            // ShootScriptBool(false);
            // PopSpike(false);
        }
    }

    // void ShootScriptBool(bool lol)
    // {
    //     _shootScript._activateThis = lol;
    // }

    // void PopSpike(bool lol)
    // {
    //     _dynamicSpikeScript._activeSpike = lol;
    // }
}
