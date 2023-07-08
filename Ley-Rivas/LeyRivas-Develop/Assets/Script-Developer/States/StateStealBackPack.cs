
using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class StateStealBackPack : State, IState,IScene
    {
        private int money;

        public bool InitState(string nameScene)
        {
            activedState = true;
            SceneManager.LoadScene(nameScene);
            return activedState;
        }
        public int GetMoney() { return money; }

        public void LoadFuntionalityScene()
        {

        }
    }
}