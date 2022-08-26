using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Gamestate State;
    public static event Action<Gamestate> GameStateChanged;
    private void Start()
    {
        UpdateGameState(Gamestate.Playerturn);
    }
    void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(Gamestate newState)
    {
        State = newState;
        switch (newState)
        {
            case Gamestate.Playerturn:
                break;
            case Gamestate.Enemyturn:
                break;
            case Gamestate.Victory:
                break;
            case Gamestate.Defeat:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        GameStateChanged?.Invoke(newState);
    }
    private void Playerturn()
    {

    }
    private void Enemyturn()
    {

    }
    private void Victory()
    {

    }
    private void Defeat()
    {

    }
}
public enum Gamestate
{
    Playerturn,
    Enemyturn,
    Victory,
    Defeat
}
