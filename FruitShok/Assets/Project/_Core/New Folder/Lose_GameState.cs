using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using SO;
using Ptoject.UI;
using Project.Core;


namespace Project
{
    public class Lose_GameState : GameStateBase
    {

        

        private UIBase _mainMenu;
        private Button _playButton;
        private Button _MenuButton;

        public override void Enter()
        {
            if (ItemBase.score > -8)
            {
                SceneManager.LoadSceneAsync(4).completed += (process) =>
                {

                    //когда нажимаешь Плей баттон открывается готуГеймплей
                    _playButton = _mainMenu.transform.Find("Restart_Button").GetComponent<Button>();
                    _playButton.onClick.AddListener(GoToGamepleay);
                    //когда нажимаешь Шоп баттон открывается готуMenu
                    _MenuButton = _mainMenu.transform.Find("Menu_Button").GetComponent<Button>();
                    _MenuButton.onClick.AddListener(GoToMenu);


                    /*Button startButton = Object.FindObjectOfType<Button>();
                    startButton.onClick.AddListener(() =>
                    {
                        _gameStateChanger.ChangeState(new Gameplay_GameState());}*/
                };
            }


        }
        private void GoToGamepleay()
        {
            _gameStateChanger.ChangeState(new Gameplay_GameState());
        }

        private void GoToMenu()
        {
            _gameStateChanger.ChangeState(new MainMenu_GameState());
        }

    }


}


