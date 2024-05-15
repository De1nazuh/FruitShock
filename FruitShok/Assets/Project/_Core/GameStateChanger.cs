using Project.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateChanger : MonoBehaviour
{
    private void Start()
    {
        ChangeState(new MainMenu_GameState());
    }


    private GameStateBase _currentGameState;

    private void Update()
    {
        _currentGameState?.Process();
    }

    public void ChangeState(GameStateBase newGameState)
    {
        _currentGameState?.Exit();

        _currentGameState = newGameState;
        _currentGameState.SetGameStateChanger(this);
        _currentGameState.Enter();
    }

}
