using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PokemonInfoView : MonoBehaviour
{
    public Pokemon pokemon;
    public GameObject panelInfo;

    [Header("UI Headers")]
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI genderTMP;
    public TextMeshProUGUI descTMP;

    [Header("Profile Images")]
    public Image pokemonPfp;

    public void OnEnable()
    {
        DisplayPokemon(pokemon);
    }
    public void DisplayPokemon(Pokemon pokemon)
    {
        nameTMP.text = "Name: " + pokemon.pokemonName;
        pokemonPfp.sprite = pokemon.pfpSprite;
        genderTMP.text = ("Gender: ") + pokemon.gender.ToString();
        descTMP.text = ("Description: ") + pokemon.description.ToString();
    }

    public void ClearView()
    {
        pokemon = null;
        pokemonPfp.sprite = null;
        nameTMP.text = null;
        genderTMP.text = null;
        descTMP.text = null;
    }
    public void OnDisable()
    {
        ClearView();
        panelInfo.gameObject.SetActive(false);
    }
}
