using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSelectionController : MonoBehaviour
{
    [SerializeField] GameObject move1;
    [SerializeField] GameObject move2;
    [SerializeField] GameObject move3;
    //[SerializeField] GameObject move4;

    // Start is called before the first frame update
    void Start()
    {
        move1.SetActive(true);
        move2.SetActive(false);
        move3.SetActive(false);
        //move4.SetActive(false);
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
    }

    void MoveUp()
    {
        if(move1.activeSelf)
        {
            move1.SetActive(false);
            move3.SetActive(true);
        }

        else if(move2.activeSelf)
        {
            move2.SetActive(false);
            move1.SetActive(true);
        }

        else if(move3.activeSelf)
        {
            move3.SetActive(false);
            move2.SetActive(true);
        }
    }

    void MoveDown()
    {
        if(move1.activeSelf)
        {
            move1.SetActive(false);
            move2.SetActive(true);
        }

        else if(move2.activeSelf)
        {
            move2.SetActive(false);
            move3.SetActive(true);
        }

        else if(move3.activeSelf)
        {
            move3.SetActive(false);
            move1.SetActive(true);
        }
    }
}
