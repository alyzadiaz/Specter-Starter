using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[Header("Player Speed")]
    public float speed = 5f;
    //[Header("Maximum Health")]
    private int maxHealth = 3;
    private int health;
    private Vector2 moveAmount;
    private RigidBody2D rb;

    void Start()
    {
        health = maxHealth;
        rb = GetComponent<Rigidbody2D>();
    }

    public void move(){
        //move the rigidbody based on move amount vector
        getMovement();
        rb.MovePosition(rb.position * moveAmount * Time.deltaTime);
    }

    public void getMovement(){
        //compute moveAmount
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed;
    }

    public void takeDamage(int amt){
        health-=amt;
        if(health<=0){
            print("ded");
        }
    }
}
