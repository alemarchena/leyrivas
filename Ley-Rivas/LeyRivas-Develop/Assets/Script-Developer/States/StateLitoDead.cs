using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class StateLitoDead : State, IState
    {

        public void InitState(string nameScene, IState iState, DataState dataState)
        {
            enumState = EnumState.StateLitoDead;

            Publisher.SetIState(iState);
            Publisher.SetDataState(dataState);

            SceneManager.LoadScene(nameScene);
        }

    }
}