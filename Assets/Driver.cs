using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.4f;
    [SerializeField] float moveSpeed = 0.01f;

    [SerializeField] float boostSpeed = 50f;

    float currentSpeed;
    public float theCountdown;
    bool boostActive;
    
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

        if(boostActive){
            theCountdown -= Time.deltaTime;
            if(theCountdown <= 0)
            {
                Debug.Log("slowing down");
                currentSpeed = moveSpeed;
                boostActive = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Boost"){
            theCountdown = 5;
            Debug.Log("speed");
            currentSpeed = boostSpeed;
            boostActive = true;

        } 
    }


}
