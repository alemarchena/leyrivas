using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class StateStealBackPack : State, IState
    {
        private int money;

        public void InitState(string nameScene, IState iState, DataState dataState)
        {
            enumState = EnumState.StateStealBackPack;

            Publisher.SetIState(iState);
            Publisher.SetDataState(dataState);

            SceneManager.LoadScene(nameScene);
        }
        public int GetMoney() { return money; }

    }
}