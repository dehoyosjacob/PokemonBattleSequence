using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonSummaryController : MonoBehaviour
{
    [SerializeField] GameObject pokemonSummary;
    [SerializeField] GameObject infoPanel;
    [SerializeField] GameObject skillsPanel;
    [SerializeField] GameObject movesPanel;
    [SerializeField] GameObject movesSummary;

    // Start is called before the first frame update
    void Start()
    {
        infoPanel.SetActive(true);
        skillsPanel.SetActive(false);
        movesPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("a") || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if(!movesSummary.activeSelf)
            {
                GoLeft();
            }
            
        }

        else if(Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (!movesSummary.activeSelf)
            {
                GoRight();
            }
        }

        

        else if(Input.GetKeyUp(KeyCode.Return))
        {
            if(movesPanel.activeSelf)
            {
                movesSummary.SetActive(true);
            }
        }

        else if (Input.GetKeyUp(KeyCode.Backspace))
        {
            if (!movesSummary.activeSelf)
            {
                pokemonSummary.SetActive(false);
                Debug.Log("pokemon summary");
            }

            else if (movesSummary.activeSelf)
            {
                movesSummary.SetActive(false);
                Debug.Log("moves summary");
            }
        }
    }

    void GoLeft()
    {
        if(infoPanel.activeSelf)
        {
            infoPanel.SetActive(false);
            movesPanel.SetActive(true);
        }

        else if(skillsPanel.activeSelf)
        {
            skillsPanel.SetActive(false);
            infoPanel.SetActive(true);
        }

        else if(movesPanel.activeSelf)
        {
            movesPanel.SetActive(false);
            skillsPanel.SetActive(true);
        }
    }

    void GoRight()
    {
        if(infoPanel.activeSelf)
        {
            infoPanel.SetActive(false);
            skillsPanel.SetActive(true);
        }

        else if(skillsPanel.activeSelf)
        {
            skillsPanel.SetActive(false);
            movesPanel.SetActive(true);
        }

        else if(movesPanel.activeSelf)
        {
            movesPanel.SetActive(false);
            infoPanel.SetActive(true);
        }
    }
}
