using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class SceneAlmacen : State, IState
    {
        public void InitState(string nameScene, IState iState, DataState dataState)
        {
            enumState = EnumState.SceneAlmacen;

            Publisher.SetIState(iState);
            Publisher.SetDataState(dataState);

            SceneManager.LoadScene(nameScene);
        }
    }
}