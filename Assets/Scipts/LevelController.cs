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
    public GameObject pokemonPanel;
    public PokemonDataHolder pokemon1;
    public PokemonDataHolder pokemon2;

    int escapeOdds;
    int attempts = 0;
    int randomNumber;

    //test variables
    bool pokemonTest;
    bool bagTest;
    bool runTest;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return))
        {
            //Debug.Log("Pressed Enter");
            if(firstText.gameObject.activeSelf && !menuPanel.activeSelf)
            {
                BeginBattle();
            }

            else if(menuPanel.activeSelf)
            {
                MenuSelect();
            }
        }

        else if(Input.GetKeyUp(KeyCode.Backspace) && !pokemonPanel.activeSelf)
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
        
        secondText.gameObject.SetActive(false);

        if (_menuArrows.topLeft.gameObject.activeSelf)
        {
            menuPanel.SetActive(false);
            fightPanel.SetActive(true);
        }

        else if(_menuArrows.bottomLeft.gameObject.activeSelf)
        {
            menuPanel.SetActive(false);
            Debug.Log("Pokemon menu selected!");
            pokemonPanel.SetActive(true);
        }

        else if (_menuArrows.topRight.gameObject.activeSelf)
        {
            menuPanel.SetActive(false);
            Debug.Log("Bag menu selected!");
            bagPanel.SetActive(true);
        }

        else if (_menuArrows.bottomRight.gameObject.activeSelf)
        {
            Debug.Log("Run menu selected!");
            Run(pokemon1.speed, pokemon2.speed);
        }
    }

    public void BackToMenu()
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

    void Run(int pSpeed, int oSpeed)
    {
        if(pSpeed > oSpeed)
        {
            Debug.Log("Ran away safely!");
        }

        else if(oSpeed >= pSpeed)
        {
            attempts++;
            escapeOdds = (((pSpeed * 128) / oSpeed) + (30 * attempts)) % 256;
            randomNumber = Random.Range(0,256);

            if(randomNumber < escapeOdds)
            {
                Debug.Log("Ran away safely!");
            }

            else if(randomNumber >= escapeOdds)
            {
                Debug.Log("Can't Escape!");
            }
        }
    }
}
