using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowControl: MonoBehaviour
{
    public Image topLeft;
    public Image bottomLeft;
    public Image topRight;
    public Image bottomRight;

    void Update()
    {
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")) && topLeft.gameObject.activeSelf)
        {
            topLeft.gameObject.SetActive(false);
            bottomLeft.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")) && topLeft.gameObject.activeSelf)
        {
            topLeft.gameObject.SetActive(false);
            topRight.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")) && topRight.gameObject.activeSelf)
        {
            topRight.gameObject.SetActive(false);
            bottomRight.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) && topRight.gameObject.activeSelf)
        {
            topRight.gameObject.SetActive(false);
            topLeft.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")) && bottomLeft.gameObject.activeSelf)
        {
            bottomLeft.gameObject.SetActive(false);
            topLeft.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")) && bottomLeft.gameObject.activeSelf)
        {
            bottomLeft.gameObject.SetActive(false);
            bottomRight.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")) && bottomRight.gameObject.activeSelf)
        {
            bottomRight.gameObject.SetActive(false);
            topRight.gameObject.SetActive(true);
        }

        else if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) && bottomRight.gameObject.activeSelf)
        {
            bottomRight.gameObject.SetActive(false);
            bottomLeft.gameObject.SetActive(true);
        }
    }
}
