using Project.Core;
using Ptoject.UI;
using SO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Project {
    public class Shop_GameState : GameStateBase
    {
        private UIContainer _uiContainer;
        private UIBase _shopUI;

        private Button _backButton;

        public override void Enter()
        {
            _uiContainer = Resources.Load<UIContainer>
                ("Configurations/UIContainer_" + _gameStateChanger.dayType.ToString());

            SceneManager.LoadSceneAsync(3).completed += (_) =>
            {
                _shopUI = Object.Instantiate(_uiContainer.GetUI("Shop"));

                _backButton = _shopUI.transform.Find("BackButton").GetComponent<Button>();
                _backButton.onClick.AddListener(GoBack);
            };

            
        }
        private void GoBack()
        {
            _gameStateChanger.ChangeState(new MainMenu_GameState());
        }
    }
}