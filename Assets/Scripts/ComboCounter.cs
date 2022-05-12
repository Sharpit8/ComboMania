using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class ComboCounter : MonoBehaviour
{

    [SerializeField] private Image radicalIndicator = null;

    [SerializeField] private Image radicalIndicator1 = null;

     public Camera cam;

    public Vector3 screenPos;

     public Transform target;

     public GUIStyle customGUI;

     public GameObject ShowMoneyGain;

     private int once;



     public  TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        PMS.Instance.ComboCounter = this.gameObject;
         radicalIndicator.fillAmount = 0;
          radicalIndicator1.fillAmount = 0;
        once = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PMS.Instance.ComboTimer=PMS.Instance.ComboTimer-1;

        radicalIndicator.fillAmount = PMS.Instance.ComboTimer/PMS.Instance.ComboTimerMax;

        if (PMS.Instance.ComboTimer>PMS.Instance.ComboTimerMax)
        {PMS.Instance.ComboTimer=PMS.Instance.ComboTimerMax;}

        if (PMS.Instance.ComboTimer<=0 && once==0)
        {
          GameObject ShowMoneyGain1 = Instantiate(ShowMoneyGain) as GameObject;
       ShowMoneyGain1.transform.position = new Vector2(transform.position.x,transform.position.y);
       var ReferenceScript = ShowMoneyGain1.GetComponent<ShowMoneyGain>();
       ReferenceScript.moneyGain = PMS.Instance.Combo;
        ReferenceScript.moneyGainBonus = (int)(Mathf.Pow(PMS.Instance.Combo, 1.1f)-PMS.Instance.Combo);

            PMS.Instance.Money +=  (int)Mathf.Pow(PMS.Instance.Combo, 1.1f);
            PMS.Instance.Combo = 0;
            radicalIndicator1.fillAmount = 0;
            once=1;
            
        }
       
       if (PMS.Instance.ComboTimer>0)
       {
            radicalIndicator1.fillAmount = 1;
            once=0;
        }
        
    }

    void OnGUI(){
        
        if (PMS.Instance.Combo>0 && PMS.Instance.Combo<10)
        {textmeshPro.SetText("  " +PMS.Instance.Combo.ToString());}

        if (PMS.Instance.Combo>=10 && PMS.Instance.Combo<100)
        {
        textmeshPro.SetText(" " + PMS.Instance.Combo.ToString());
        }

          if (PMS.Instance.Combo>=100)
        {
        textmeshPro.SetText( PMS.Instance.Combo.ToString());
        }
        
        if (PMS.Instance.Combo<=0)
        {textmeshPro.SetText("");}

    }
}
