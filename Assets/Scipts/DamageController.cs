using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    public PokemonDataHolder Squirtle;
    public PokemonDataHolder Charmander;
    public ArrowControl moves;
    public moveInfoInput move1;
    public moveInfoInput move2;
    public moveInfoInput move3;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return))
        {
            if(moves.topLeft.gameObject.activeSelf)
            {
                dealDamage(Squirtle, Charmander, move1);
            }

            else if (moves.topRight.gameObject.activeSelf)
            {
                dealDamage(Squirtle, Charmander, move2);
            }

            else if (moves.bottomLeft.gameObject.activeSelf)
            {
                dealDamage(Squirtle, Charmander, move3);
            }
        }
    }

    void dealDamage(PokemonDataHolder attacker, PokemonDataHolder defender, moveInfoInput move)
    {
        damage = ((2 * attacker.lvl / 5 + 2));
    }
}
