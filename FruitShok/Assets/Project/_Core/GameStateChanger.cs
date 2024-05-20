using Project.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project
{
    public enum DayType { Normal, Halloween, NewYear }


    public class GameStateChanger : MonoBehaviour
    {

        public bool IsHalloween;
        public DayType dayType = DayType.Normal;


        private void Start()
        {
            ChangeState(new MainMenu_GameState());
            DontDestroyOnLoad(gameObject);
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
}
