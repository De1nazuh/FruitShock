using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Project.Core
{
    public class MainMenu_GameState : GameStateBase
    {
        private UIBase _mainMenu;
        private Button _playButton;

        public override void Enter()
        {
            SceneManager.LoadSceneAsync(1).completed += (process) =>
            {
                UIBase mainMenuPrefab = null;
                if (_gameStateChanger.dayType == DayType.Halloween)
                {
                    mainMenuPrefab = Resources.Load<UIBase>("UI/MainMenu_Halloween");

                }
                else if (_gameStateChanger.dayType == DayType.Usual)
                {
                    mainMenuPrefab = Resources.Load<UIBase>("UI/MainMenuUI");

                }
                else if (_gameStateChanger.dayType == DayType.NewYear)
                {
                    mainMenuPrefab = Resources.Load<UIBase>("UI/MainMenuNewYear");

                }
                _mainMenu = Object.Instantiate(mainMenuPrefab); 
                

                _playButton = _mainMenu.GetComponentInChildren<Button>();
                _playButton.onClick.AddListener(GoToGamepleay);


                /*Button startButton = Object.FindObjectOfType<Button>();
                startButton.onClick.AddListener(() =>
                {
                    _gameStateChanger.ChangeState(new Gameplay_GameState());}*/
            };


        }
        private void GoToGamepleay()
        {
            _gameStateChanger.ChangeState(new Gameplay_GameState());
        }

    }


}


