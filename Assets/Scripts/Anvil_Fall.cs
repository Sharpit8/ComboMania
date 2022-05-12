using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Anvil_Fall : MonoBehaviour
{
  
    public float moveSpeed = 5f;
    public Rigidbody2D rb; 
    public Animator animator; 

    public GameObject Particules;
    int timer = 120;
    public GameObject Anvil_Hitbox;

   public static int Anvil_FallHeight = 8;
     public double Fallpoint = 5;
    Vector2 movement; 

   public int once = 0;
   

    // Start is called before the first frame update
    void Start()
    {
      Fallpoint = transform.position.y - Anvil_FallHeight;
    }

    // Update is called once per frame
    void Update()
    {

      if (rb.position.y <= Fallpoint && once==0)
      {
        rb.gravityScale = 0;
        rb.velocity = new Vector2(0,0);
        once = 1;
        animator.SetInteger("HitGround", 1 );
       CameraShaker.Instance.ShakeOnce(1.5f,2f, 0.1f, 1f);

        GameObject hitbox = Instantiate(Anvil_Hitbox) as GameObject;
        hitbox.transform.position = new Vector2(transform.position.x,transform.position.y - (float)0.20);
      }

        //Input
       // movement.x = Input.GetAxisRaw("Horizontal");
      //  movement.y = Input.GetAxisRaw("Vertical");

    }

    void  FixedUpdate()
    {
        timer = timer - 1;

        if (timer<=0)
        {
           GameObject Particules1 = Instantiate(Particules) as GameObject;
        Particules1.transform.position = new Vector2(transform.position.x,transform.position.y);
          Object.Destroy(gameObject);
        }
    //Movement
   // rb(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
