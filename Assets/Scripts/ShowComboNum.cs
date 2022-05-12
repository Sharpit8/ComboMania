using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowComboNum : MonoBehaviour
{

   private float Combo;
   public GUIStyle customGUI;

   public int timer;

      public int timermax;

     public Camera cam;

    public Vector3 screenPos;

      public Transform target;

      public GameObject Particles;

    

    // Start is called before the first frame update
    void Start()
    {
        PMS.Instance.Combo=PMS.Instance.Combo+1;
       if (PMS.Instance.ComboTimer<=0)
       {
         PMS.Instance.ComboTimer = PMS.Instance.ComboTimerMax/2f;
       }else{
       PMS.Instance.ComboTimer += 20;
       }

       PMS.Instance.ComboCounter.transform.position = new Vector2(transform.position.x,transform.position.y);
         
        Combo = PMS.Instance.Combo;
        cam = Camera.main;
        timer = timermax;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Vector3 movement = new Vector3(0,1,0);
         transform.Translate(movement * Time.deltaTime);

         timer= timer - 1;
     
     if (timer<=0)
     {Object.Destroy(gameObject);
    // GameObject Particles1 = Instantiate(Particles) as GameObject;
    //Particles1.transform.position = new Vector2(transform.position.x+0.055f,transform.position.y-0.1f);
     }

    }

    void OnGUI()
    {
     screenPos = cam.WorldToScreenPoint(target.position);

        Color zm =  customGUI.normal.textColor;  //  makes a new color zm
        zm.a = ((float)timer/(float)timermax); // makes the color zm transparent
        customGUI.normal.textColor = zm;
        GUI.Label(new Rect(screenPos.x, -screenPos.y+1080, 100, 100), Combo.ToString() ,customGUI);
 
    }
}
