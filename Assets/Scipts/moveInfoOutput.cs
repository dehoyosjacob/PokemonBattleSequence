using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveInfoOutput : MonoBehaviour
{
    [SerializeField] Text moveNameFight;
    [SerializeField] Text moveNameSummary;
    [SerializeField] Text maxPP_Fight;
    [SerializeField] Text maxPP_Summary;
    [SerializeField] Text currPP_Fight;
    [SerializeField] Text currPP_Summary;
    [SerializeField] Image typeFight;
    [SerializeField] Image typeSummary;
    [SerializeField] Text movePower;
    [SerializeField] Text moveAccuracy;

    public moveInfoInput infoInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveNameFight)
        {
            moveNameFight.text = infoInput.moveName.ToString();
        }

        if(moveNameSummary)
        {
            moveNameSummary.text = infoInput.moveName.ToString();
        }

        if(maxPP_Fight)
        {
            maxPP_Fight.text = infoInput.maxPP.ToString();
        }

        if(maxPP_Summary)
        {
            maxPP_Summary.text = infoInput.maxPP.ToString();
        }

        if(currPP_Fight)
        {
            currPP_Fight.text = infoInput.currentPP.ToString();
        }

        if(currPP_Summary)
        {
            currPP_Summary.text = infoInput.currentPP.ToString();
        }

        if(typeFight)
        {
            typeFight.sprite = infoInput.moveType;
        }
    }
}
