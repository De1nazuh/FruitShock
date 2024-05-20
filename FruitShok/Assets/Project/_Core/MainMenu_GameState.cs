using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using SO;
using Ptoject.UI;
using Project.Core;

namespace Project
{
    public class MainMenu_GameState : GameStateBase
    {

        private UIContainer _uiContainer;

        private UIBase _mainMenu;
        private Button _playButton;
        private Button _shopButton;

        public override void Enter()
        {
            //получение UIConteiner из папки Resources 
            _uiContainer = Resources.Load<UIContainer>
                ("Configurations/UIContainer_" + _gameStateChanger.dayType.ToString());
            //ожидание зaгрузки Shop
            SceneManager.LoadSceneAsync(1).completed += (process) =>
            {
                //спавн префаба майнменю
                UIBase mainMenuPrefab = _uiContainer.GetUI("MainMenu");
                _mainMenu = Object.Instantiate(mainMenuPrefab); 
                
                //когда нажимаешь Плей баттон открывается готуГеймплей
                _playButton = _mainMenu.transform.Find("PlayButton").GetComponent<Button>();
                _playButton.onClick.AddListener(GoToGamepleay);
                //когда нажимаешь Шоп баттон открывается готуШоп
                _shopButton = _mainMenu.transform.Find("ShopButton").GetComponent<Button>();
                _shopButton.onClick.AddListener(GoToShop);


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

        private void GoToShop()
        {
            _gameStateChanger.ChangeState(new Shop_GameState());
        }

    }


}


