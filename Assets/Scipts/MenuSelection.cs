using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour
{
    [SerializeField] Image fightArrow;
    [SerializeField] Image pokemonArrow;
    [SerializeField] Image bagArrow;
    [SerializeField] Image runArrow;

    void Update()
    {
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")) && fightArrow.gameObject.activeSelf)
        {
            fightArrow.gameObject.SetActive(false);
            pokemonArrow.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")) && fightArrow.gameObject.activeSelf)
        {
            fightArrow.gameObject.SetActive(false);
            bagArrow.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")) && bagArrow.gameObject.activeSelf)
        {
            bagArrow.gameObject.SetActive(false);
            runArrow.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) && bagArrow.gameObject.activeSelf)
        {
            bagArrow.gameObject.SetActive(false);
            fightArrow.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")) && pokemonArrow.gameObject.activeSelf)
        {
            pokemonArrow.gameObject.SetActive(false);
            fightArrow.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")) && pokemonArrow.gameObject.activeSelf)
        {
            pokemonArrow.gameObject.SetActive(false);
            runArrow.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")) && runArrow.gameObject.activeSelf)
        {
            runArrow.gameObject.SetActive(false);
            bagArrow.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) && runArrow.gameObject.activeSelf)
        {
            runArrow.gameObject.SetActive(false);
            pokemonArrow.gameObject.SetActive(true);
        }
    }
}
