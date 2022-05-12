using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOrderHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;
        
       // foreach(var rend in GetComponentsInChildren<Renderer>())
       // {
          // rend.sortingOrder = (int)GetComponent<Collider2D>().bounds.min.y * 1000;
      //  }
    }
}
