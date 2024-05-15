using UnityEngine.SceneManagement;

namespace Project.Core
{
    public class Gameplay_GameState : GameStateBase
    {
        public override void Enter()
        {
            SceneManager.LoadScene(2);
        }
    }
}


