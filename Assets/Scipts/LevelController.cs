using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject fightPanel;
    [SerializeField] Text firstText;
    [SerializeField] Text secondText;

    public ArrowControl _menuArrows;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Pressed Enter");
            if(!menuPanel.activeSelf)
            {
                BeginBattle();
            }

            else if(menuPanel.activeSelf)
            {
                MenuSelect();
            }
        }
    }

    void BeginBattle()
    {
        firstText.gameObject.SetActive(false);
        menuPanel.SetActive(true);
        secondText.gameObject.SetActive(true);
    }

    void MenuSelect()
    {
        if(_menuArrows.topLeft.gameObject.activeSelf)
        {
            menuPanel.SetActive(false);
            secondText.gameObject.SetActive(false);
            fightPanel.SetActive(true);
        }
    }
}
