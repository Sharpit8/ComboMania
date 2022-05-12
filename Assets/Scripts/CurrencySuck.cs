using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencySuck : MonoBehaviour
{

    public Transform target;

     public ParticleSystem ps;

     private Vector3 Vect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        var fo = ps.forceOverLifetime;
        fo.enabled = true;


     Vect = Vector3.MoveTowards(transform.position, target.position, 40);
     

     fo.x = Vect.x;
      fo.y = Vect.y;

           
    }
}
