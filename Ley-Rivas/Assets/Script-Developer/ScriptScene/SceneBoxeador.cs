using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class SceneBoxeador : State, IState
    {

        public void InitState(string nameScene, IState iState, DataState dataState)
        {
            enumState = EnumState.SceneBoxeador;

            Publisher.SetIState(iState);
            Publisher.SetDataState(dataState);

            SceneManager.LoadScene(nameScene);
        }

    }
}