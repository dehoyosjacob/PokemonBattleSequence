using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonInfo : MonoBehaviour
{
    [SerializeField] int lvl;
    [SerializeField] int currentHealth;
    [SerializeField] int maxHealth;
    [SerializeField] int speed;
    [SerializeField] Text lvl_txt;
    [SerializeField] Text currentHealth_txt;
    [SerializeField] Text maxHealth_txt;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        lvl_txt.text = lvl.ToString();
        currentHealth_txt.text = currentHealth.ToString();
        maxHealth_txt.text = maxHealth.ToString();
    }
}
