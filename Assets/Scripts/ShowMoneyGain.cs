using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ShowMoneyGain : MonoBehaviour
{
       public GUIStyle customGUI;
   public int timer;

      public int timermax;

     private Camera cam;

    public Vector3 screenPos;

    public float moneyGainBonus = 0;

    public float moneyGain = 0;

      public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
       // moneyGain = PMS.Instance.Combo;
       // moneyGainBonus = (int)(Mathf.Pow(PMS.Instance.Combo, 1.1f)-PMS.Instance.Combo);
    }

   void FixedUpdate()
    {
      Vector3 movement = new Vector3(0,1,0);
         transform.Translate(movement * Time.deltaTime);

         timer= timer - 1;
     
    if (timer<=0)
    {
        Object.Destroy(gameObject);
    }

    }

    void OnGUI()
    {
     screenPos = cam.WorldToScreenPoint(target.position);

        Color zm =  customGUI.normal.textColor;  //  makes a new color zm
        zm.a = ((float)timer/(float)timermax); // makes the color zm transparent
        customGUI.normal.textColor = zm;
        GUI.Label(new Rect(screenPos.x, -screenPos.y+1080, 100, 100), "+" + (moneyGainBonus+moneyGain).ToString() + " Money" + " (" + moneyGainBonus + " Bonus)",customGUI);
 
    }
}
