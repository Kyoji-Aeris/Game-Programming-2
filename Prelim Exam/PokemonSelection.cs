using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelection : MonoBehaviour
{
    public PokemonManager pokemonManager;
    public Transform parentPos;
    public GameObject pokemonButtonPrefab;
    public PokemonInfoView pokemonInfoView;
    public GameObject panelInfo;
    public void OnClick()
    {
        Debug.Log(pokemonManager.pokemons.Count());
        foreach (Pokemon p in pokemonManager.pokemons)
        {
            GameObject buttonPrefab = Instantiate(pokemonButtonPrefab, parentPos);
            PokemonButton pokemonButton = buttonPrefab.GetComponent<PokemonButton>();
            pokemonButton.SetPokemonData(p);
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => pokemonInfoView.DisplayPokemon(p));
            button.onClick.AddListener(() => panelInfo.gameObject.SetActive(true));
        }
    }
}
