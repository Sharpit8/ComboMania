using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueTxt;

    private void Start()
    {
      // ValueTxt.text = PMS.Instance.Value.ToString();
    }

    public void GoToFirstSence()
    {
        SceneManager.LoadScene("first");
        PMS.Instance.Value++;
    }

     public void GoToSecondScene()
    {
        SceneManager.LoadScene("second");
        PMS.Instance.Value++;
    }
}

