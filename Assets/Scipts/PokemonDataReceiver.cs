using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonDataReceiver : MonoBehaviour
{
    [SerializeField] int currentHealth;
    [SerializeField] Text pokemonNumber;
    [SerializeField] Text lvl_txt;
    [SerializeField] Text currentHealth_txt;
    [SerializeField] Text maxHealth_txt;
    [SerializeField] Text attack;
    [SerializeField] Text defense;
    [SerializeField] Text specialAttack;
    [SerializeField] Text specialDefense;
    [SerializeField] Text speed;
    [SerializeField] Text pokemonName;

    public PokemonDataHolder _pokemonData;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = _pokemonData.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(pokemonNumber)
        {
            pokemonNumber.text = _pokemonData.pokemonNumber.ToString();
        }

        if(lvl_txt)
        {
            lvl_txt.text = _pokemonData.lvl.ToString();
        }

        if(currentHealth_txt)
        {
            currentHealth_txt.text = currentHealth.ToString();
        }

        if(maxHealth_txt)
        {
            maxHealth_txt.text = _pokemonData.maxHealth.ToString();
        }

        if(attack)
        {
            attack.text = _pokemonData.attack.ToString();
        }

        if(defense)
        {
            defense.text = _pokemonData.defense.ToString();
        }

        if(specialAttack)
        {
            specialAttack.text = _pokemonData.specialAttack.ToString();
        }

        if(specialDefense)
        {
            specialDefense.text = _pokemonData.specialDefense.ToString();
        }

        if(speed)
        {
            speed.text = _pokemonData.speed.ToString();
        }

        if(pokemonName)
        {
            pokemonName.text = _pokemonData.pokemonName.ToString();
        }
    }
}
