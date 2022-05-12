using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Anvil : MonoBehaviour
{


    public GameObject Anvil;
    public GameObject Cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*
        if (Input.GetMouseButtonDown(0))
        {
Vector3 MouseWorldPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject Anvil1 = Instantiate(Anvil) as GameObject;
        Anvil1.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);
    //  Anvil1.GetComponent<Anvil_Fall>().Fallpoint = MouseWorldPostion.y - 4.0;
       Anvil1.GetComponent<Anvil_Fall>().rb.gravityScale = 1;
       Anvil1.GetComponent<Anvil_Fall>().once = 0;

        }
        */

         if (Input.GetMouseButtonDown(1))
        {
Vector3 MouseWorldPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject Cat1 = Instantiate(Cat) as GameObject;
        Cat1.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);
         GameObject Cat2 = Instantiate(Cat) as GameObject;
        Cat2.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);
         GameObject Cat3 = Instantiate(Cat) as GameObject;
        Cat3.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);
        GameObject Cat4 = Instantiate(Cat) as GameObject;
        Cat4.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);
        GameObject Cat5 = Instantiate(Cat) as GameObject;
        Cat5.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);
        GameObject Cat6 = Instantiate(Cat) as GameObject;
        Cat6.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);


        }
        
    }
}
