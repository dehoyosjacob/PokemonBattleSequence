using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject fightPanel;
    [SerializeField] GameObject bagPanel;
    [SerializeField] Text firstText;
    [SerializeField] Text secondText;

    public ArrowControl _menuArrows;

    //test variables
    bool pokemonTest;
    bool bagTest;
    bool runTest;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Pressed Enter");
            if(firstText.gameObject.activeSelf && !menuPanel.activeSelf)
            {
                BeginBattle();
            }

            else if(menuPanel.activeSelf)
            {
                MenuSelect();
            }
        }

        else if(Input.GetKeyUp(KeyCode.Backspace))
        {
            if (!firstText.gameObject.activeSelf)
            {
                BackToMenu();
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

        else if(_menuArrows.bottomLeft.gameObject.activeSelf)
        {
            Debug.Log("Pokemon menu selected!");
            pokemonTest = true;
        }

        else if (_menuArrows.topRight.gameObject.activeSelf)
        {
            Debug.Log("Bag menu selected!");
            //bagTest = true;
            menuPanel.SetActive(false);
            fightPanel.SetActive(false);
            bagPanel.SetActive(true);
        }

        else if (_menuArrows.bottomRight.gameObject.activeSelf)
        {
            Debug.Log("Run menu selected!");
            runTest = true;
        }
    }

    void BackToMenu()
    {
        if(fightPanel.activeSelf)
        {
            fightPanel.SetActive(false);
        }

        else if(pokemonTest)
        {
            Debug.Log("Exit the pokemon menu");
            pokemonTest = false;
        }

        else if(bagPanel.activeSelf)
        {
            Debug.Log("Exit the bag menu");
            //bagTest = false;
            bagPanel.SetActive(false);
        }

        menuPanel.SetActive(true);
        secondText.gameObject.SetActive(true);
    }
}
