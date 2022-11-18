using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.4f;
    [SerializeField] float moveSpeed = 0.01f;

    [SerializeField] float boostSpeed = 50f;

    float currentSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Boost"){
            Debug.Log("speed");
            currentSpeed = boostSpeed;
        } 
    }


}
