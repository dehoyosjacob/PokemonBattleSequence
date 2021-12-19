using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonActionController : MonoBehaviour
{
    [SerializeField] Image topArrow;
    [SerializeField] Image midArrow;
    [SerializeField] Image botArrow;
    [SerializeField] GameObject pokemonActionMenu;

    // Start is called before the first frame update
    void Start()
    {
        topArrow.gameObject.SetActive(true);
        midArrow.gameObject.SetActive(false);
        botArrow.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("w") || Input.GetKeyUp(KeyCode.UpArrow))
        {
            MoveUp();
        }

        else if(Input.GetKeyUp("s") || Input.GetKeyUp(KeyCode.DownArrow))
        {
            MoveDown();
        }

        else if(Input.GetKeyUp(KeyCode.Return))
        {
            if(botArrow.gameObject.activeSelf)
            {
                pokemonActionMenu.SetActive(false);
            }
        }
    }

    void MoveUp()
    {
        if(midArrow.gameObject.activeSelf)
        {
            midArrow.gameObject.SetActive(false);
            topArrow.gameObject.SetActive(true);
        }

        else if(botArrow.gameObject.activeSelf)
        {
            botArrow.gameObject.SetActive(false);
            midArrow.gameObject.SetActive(true);
        }
    }

    void MoveDown()
    {
        if(topArrow.gameObject.activeSelf)
        {
            topArrow.gameObject.SetActive(false);
            midArrow.gameObject.SetActive(true);
        }

        else if(midArrow.gameObject.activeSelf)
        {
            midArrow.gameObject.SetActive(false);
            botArrow.gameObject.SetActive(true);
        }
    }
}
