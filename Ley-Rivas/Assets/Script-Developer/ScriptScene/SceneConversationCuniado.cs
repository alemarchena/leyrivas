using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class SceneConversationCuniado : State, IState
    {
        private int money;

        public void InitState(string nameScene, IState iState, DataState dataState)
        {
            enumState = EnumState.SceneConversationCuniado;

            Publisher.SetIState(iState);
            Publisher.SetDataState(dataState);

            SceneManager.LoadScene(nameScene);
        }
        public int GetMoney() { return money; }

    }
}