using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonMenuController : MonoBehaviour
{
    [SerializeField] GameObject defaultScreen;
    [SerializeField] GameObject cancelScreen;

    public LevelController _levelController;
 
    // Start is called before the first frame update
    void Start()
    {
        defaultScreen.SetActive(true);
        cancelScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.RightArrow))
        {
            if(defaultScreen.activeSelf)
            {
                defaultScreen.SetActive(false);
                cancelScreen.SetActive(true);
            }
        }

        else if(Input.GetKeyUp("a") || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if(cancelScreen.activeSelf)
            {
                cancelScreen.SetActive(false);
                defaultScreen.SetActive(true);
            }
        }

        else if(Input.GetKeyUp(KeyCode.Return))
        {
            if(cancelScreen.activeSelf)
            {
                _levelController.BackToMenu();
            }
        }
    }
}
