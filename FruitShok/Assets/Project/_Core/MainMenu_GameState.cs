using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Project.Core
{
    public class MainMenu_GameState : GameStateBase
    {
        private Button _startButton;
        public override void Enter()
        {
            SceneManager.LoadSceneAsync(1).completed += (process) =>
            {
                _startButton = Object.FindObjectOfType<Button>();
                _startButton.onClick.AddListener(GoTOGameplay);
            }

            
        }
        
        private void GoTOGameplay()
        {
            _gameStateChanger.ChangeState(new GamePlay_GameState());
        }
    }
}


