
namespace Leyrivas
{
    public class StateStealBackPack : State, IState, IScene
    {
        private int money;

        public bool InitState(string nameScene)
        {
            throw new System.NotImplementedException();
        }
        public int GetMoney() { return money; }

        public void LoadSceneState(string sceneName)
        {
            throw new System.NotImplementedException();
        }
    }
}