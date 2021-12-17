using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject fightPanel;
    [SerializeField] GameObject bagPanel;
    [SerializeField] GameObject pokemonPanel;
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

            else if(menuPanel.activeSelf && !_menuArrows.bottomRight.gameObject.activeSelf)
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
        menuPanel.SetActive(false);
        secondText.gameObject.SetActive(false);

        if (_menuArrows.topLeft.gameObject.activeSelf)
        {
            fightPanel.SetActive(true);
        }

        else if(_menuArrows.bottomLeft.gameObject.activeSelf)
        {
            Debug.Log("Pokemon menu selected!");
            pokemonPanel.SetActive(true);
        }

        else if (_menuArrows.topRight.gameObject.activeSelf)
        {
            Debug.Log("Bag menu selected!");
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

        else if(pokemonPanel.activeSelf)
        {
            Debug.Log("Exit the pokemon menu");
            pokemonPanel.SetActive(false);
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
