using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OUCH");
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "Package" && !hasPackage){
            Debug.Log("picked up package");
            hasPackage = true;
            Destroy(other.gameObject, 0.25f);
        }

        if(other.gameObject.tag == "Person" && hasPackage){
            Debug.Log("package delivered");
            hasPackage = false;
        }
        
    }
}
