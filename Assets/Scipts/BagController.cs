using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{
    [SerializeField] Image leftArrow;
    [SerializeField] Image rightArrow;
    [SerializeField] GameObject itemsPanel;
    [SerializeField] GameObject keyItemsPanel;
    [SerializeField] GameObject pokeballsPanel;

    void Start()
    {
        itemsPanel.SetActive(true);
        keyItemsPanel.SetActive(false);
        pokeballsPanel.SetActive(false);

        leftArrow.gameObject.SetActive(false);
        rightArrow.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("a") || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GoLeft();
        }

        else if(Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.RightArrow))
        {
            GoRight();
        }
    }

    void GoLeft()
    {
        if(keyItemsPanel.activeSelf)
        {
            keyItemsPanel.SetActive(false);
            leftArrow.gameObject.SetActive(false);
            itemsPanel.SetActive(true);
            
        }

        else if(pokeballsPanel.activeSelf)
        {
            pokeballsPanel.SetActive(false);
            keyItemsPanel.SetActive(true);
            rightArrow.gameObject.SetActive(true);
        }

    }

    void GoRight()
    {
        if (itemsPanel.activeSelf)
        {
            itemsPanel.SetActive(false);
            leftArrow.gameObject.SetActive(true);
            keyItemsPanel.SetActive(true);

        }

        else if (keyItemsPanel.activeSelf)
        {
            keyItemsPanel.SetActive(false);
            pokeballsPanel.SetActive(true);
            rightArrow.gameObject.SetActive(false);
        }
    }
}
