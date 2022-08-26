using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManger : MonoBehaviour
{
    private void Awake()
    {
        GameManager.GameStateChanged += GameManagerOnGameStateChanged;
    }
    //This bascially does stuff need for each game state such as when it is the playerr turn, they will be able to move their units
    //The first thing to do with this is make a unit move at least one tile
    private void GameManagerOnGameStateChanged(Gamestate state)
    {
        throw new System.NotImplementedException();
    }
    private void OnDestroy()
    {
        GameManager.GameStateChanged -= GameManagerOnGameStateChanged;
    }
}
