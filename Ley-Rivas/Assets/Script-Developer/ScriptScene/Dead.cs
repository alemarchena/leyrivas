using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class Dead : State, IState
    {

        public void InitState(string nameScene, IState iState, DataState dataState)
        {
            enumState = EnumState.SceneCuniado;

            Publisher.SetIState(iState);
            Publisher.SetDataState(dataState);

            SceneManager.LoadScene(nameScene);
        }

    }
}