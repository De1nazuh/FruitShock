namespace Project.Core
{
    public abstract class GameStateBase
    {
        public GameStateChanger _gameStateChanger;

        public void SetGameStateChanger
            (GameStateChanger gameStateChanger)
        {
            _gameStateChanger = gameStateChanger;
        }

        public virtual void Enter()
        {

        }

        public virtual void Process()
        {

        }
        public virtual void Exit()
        {

        }
    }

}
