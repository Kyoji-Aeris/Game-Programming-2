using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokemonButton : MonoBehaviour
{
    public TextMeshProUGUI pokemonNameTxt;
    public Image pokemonPfp;
    public TextMeshProUGUI lvlText;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI defenseText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI agilityText;
    public TextMeshProUGUI luckText;

    public void SetPokemonData(Pokemon unit)
    {
        pokemonNameTxt.text = unit.pokemonName;
        pokemonPfp.sprite = unit.pfpSprite;
        lvlText.text = ("Level: ") + unit.level.ToString();
        hpText.text = ("HP: ") + unit.hp.ToString();
        strengthText.text = ("STR: ") + unit.strength.ToString();
        defenseText.text = ("DEF: ") + unit.defense.ToString();
        speedText.text = ("SPD: ") + unit.speed.ToString();
        agilityText.text = ("AGL: ") + unit.agility.ToString();
        luckText.text = ("LUCK: ") + unit.luck.ToString();
    }
}
