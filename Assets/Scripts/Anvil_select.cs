using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil_select : MonoBehaviour
{
 
     [SerializeField] private Material Anvil_selectMaterial;
    public GameObject Anvil_Place;

    public GameObject Anvil_Darken;

    public float cooldownmax;

    public Camera cam;

    public Vector3 screenPos;

     public Transform target;

     public GUIStyle customGUI;
 
    // Start is called before the first frame update
    void Start()
    {
     Anvil_Darken.transform.localScale = new Vector3(1,0,1);
     PMS.Instance.Anvil_cooldownmax = cooldownmax;
    PMS.Instance.Anvil_cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {

    Anvil_selectMaterial.SetFloat("_Glow",0);

    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
    RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

    if (hit.collider != null && hit.collider.gameObject.name == gameObject.name)
    {
        Anvil_selectMaterial.SetFloat("_Glow",.3f);
    }

          if (Input.GetMouseButtonDown(0)) {
                 
            if (hit.collider != null && hit.collider.gameObject.name == gameObject.name && PMS.Instance.Anvil_cooldown<=0) {
               
               Vector3 MouseWorldPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject Anvil1 = Instantiate(Anvil_Place) as GameObject;
        Anvil1.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && PMS.Instance.Anvil_cooldown<=0)
        { 
            
               Vector3 MouseWorldPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject Anvil1 = Instantiate(Anvil_Place) as GameObject;
        Anvil1.transform.position = new Vector2(MouseWorldPostion.x,MouseWorldPostion.y);


        }
        
    }

    void FixedUpdate(){
     PMS.Instance.Anvil_cooldown=PMS.Instance.Anvil_cooldown-1;

     if (PMS.Instance.Anvil_cooldown<=0)
     {
        Anvil_Darken.transform.localScale = new Vector3(1,0,1);  
     }
     else{
         Anvil_Darken.transform.localScale = new Vector3(1,(PMS.Instance.Anvil_cooldown/PMS.Instance.Anvil_cooldownmax),1); 
     }

    }

     void OnGUI()
    {   
        //Resources.GetBuiltinResource<Font>("Arial.ttf");
        screenPos = cam.WorldToScreenPoint(target.position);
        
        GUI.Label(new Rect(screenPos.x-90, -screenPos.y+1080-100, 100, 100), "[1]",customGUI);
    }
}
