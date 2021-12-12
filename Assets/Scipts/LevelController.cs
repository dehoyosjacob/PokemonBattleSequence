using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] Text firstText;
    [SerializeField] Text secondText;

    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            //Debug.Log("Pressed Enter");
            if(!menuPanel.activeSelf)
            {
                BeginBattle();
            }
        }
    }

    void BeginBattle()
    {
        firstText.gameObject.SetActive(false);
        menuPanel.SetActive(true);
        secondText.gameObject.SetActive(true);
    }
}
