using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  
    public float moveSpeed = 5f;
    public Rigidbody2D rb; 
    public Animator animator; 
    int timer = 30;
     int ran = 1;
    Vector2 movement; 

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {

       
      

        //Input
       // movement.x = Input.GetAxisRaw("Horizontal");
      //  movement.y = Input.GetAxisRaw("Vertical");


       if (timer<=0)
       { 
         ran = Random.Range(0,6);
        if (ran<=1)
        {movement.x = Random.Range(-1,2);
        movement.y = Random.Range(-1,2);} else {
        movement.x=0;
        movement.y=0;
        }

        timer = Random.Range(10,60);
       }

         

        animator.SetFloat("Horizontal", movement.x );
        animator.SetFloat("Vertical", movement.y );
        animator.SetFloat("Speed", movement.sqrMagnitude);
    
    if (movement.x>0)
    {
         gameObject.transform.localScale = new Vector3(1,1,1);   
    }

    if (movement.x<0)
    {
         gameObject.transform.localScale = new Vector3(-1,1,1);   
    }
        
    }

    void  FixedUpdate()
    {
        timer = timer - 1;
    //Movement
    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

}
