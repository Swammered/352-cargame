using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    
    [SerializeField] Color hasPackageColor = Color.green;
    [SerializeField] Color noPackageColor = Color.white;

    SpriteRenderer spriteRenderer;

    bool hasPackage = false;
    private void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OUCH");
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "Package" && !hasPackage){
            Debug.Log("picked up package");
            //spriteRenderer = hasPackageColor;
            hasPackage = true;
            Destroy(other.gameObject, 0.25f);
        }

        if(other.gameObject.tag == "Person" && hasPackage){
            Debug.Log("package delivered");
            //spriteRenderer = noPackageColor;
            hasPackage = false;
        }
        
    }
}
