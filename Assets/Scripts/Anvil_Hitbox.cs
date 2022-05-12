using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil_Hitbox : MonoBehaviour
{

  private int timer;

    public GameObject Particles_Blood;
     public GameObject Particles_Guts;

     public GameObject ComboNum;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2;
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
     
    if (other.gameObject.tag == "Cat")
      {
           //print("Cat Hit");
           GameObject blood = Instantiate(Particles_Blood) as GameObject;
       blood.transform.position = new Vector2(other.transform.position.x,other.transform.position.y);

       GameObject guts = Instantiate(Particles_Guts) as GameObject;
       guts.transform.position = new Vector2(other.transform.position.x,other.transform.position.y);

        GameObject ComboNum1 = Instantiate(ComboNum) as GameObject;
       ComboNum1.transform.position = new Vector2(other.transform.position.x,other.transform.position.y);
       
      

       Destroy(other.gameObject);

      }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //print(timer);
      timer=timer-1;
      if (timer<=0)
     { 
       Object.Destroy(gameObject);
     }

        
    }

}
