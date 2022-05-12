using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMS: MonoBehaviour
{
    public static PMS Instance { get; private set; }

    public int Value;
    public float Anvil_cooldown;
    public float Anvil_cooldownmax;

    public float Combo;

    public float ComboTimer;

    public float ComboTimerMax;

    public float Money;

    public Camera cam;

    public Vector3 screenPos;

     public Transform target;

     public GUIStyle customGUI;

     public GameObject ComboCounter;


    private void Awake()
    {

        Combo = 0;

       if (Instance == null)
       {
        Instance = this;
        DontDestroyOnLoad(gameObject);
       }
       else
       {
           Destroy(gameObject);
       }
    }

    void OnGUI(){

        screenPos = cam.WorldToScreenPoint(target.position);

        GUI.Label(new Rect(10, 0,100, 100), "Money: " + Money.ToString(),customGUI);
        GUI.Label(new Rect(10, 40,100, 100), "Combo: " + Combo.ToString(),customGUI);
    }
}
