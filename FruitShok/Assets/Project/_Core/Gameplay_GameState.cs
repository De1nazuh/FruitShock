using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Project.Core
{
    public class Gameplay_GameState : GameStateBase
    {



        private Button _MM;
        private Button _GOMenuButton;
        public override void Enter()
        {
            SceneManager.LoadSceneAsync(2).completed += (Exit) =>
            {
                Button MM = Object.FindObjectOfType<Button>();
                MM.onClick.AddListener(() =>
                {
                    _gameStateChanger.ChangeState(new MainMenu_GameState());
                });
            };


        }
    }
}


