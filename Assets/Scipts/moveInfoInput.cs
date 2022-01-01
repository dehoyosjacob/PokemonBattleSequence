using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveInfoInput : MonoBehaviour
{
    public string moveName;
    public int maxPP;
    public int currentPP;
    public Sprite moveType;
    public int power;
    public int accuracy;

    void Start()
    {
        currentPP = maxPP;
    }
}
