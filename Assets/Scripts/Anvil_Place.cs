using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil_Place : MonoBehaviour
{

    public GameObject Anvil;

 public GameObject Anvil_Select;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 MouseWorldPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);

         if (Input.GetMouseButtonDown(0))
       { 
        GameObject Anvil1 = Instantiate(Anvil) as GameObject;
        Anvil1.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y + (float) 8 +(float)0.3 );
         PMS.Instance.Anvil_cooldown = PMS.Instance.Anvil_cooldownmax;
         Object.Destroy(gameObject);
       }

       if (Input.GetMouseButtonDown(1))
       { 
           Object.Destroy(gameObject);
       }
        
        transform.position = new Vector3 (MouseWorldPostion.x,MouseWorldPostion.y+(float)0.3,0);

        
    }
}
