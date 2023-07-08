

using Unity.VisualScripting;
using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class StateFamilyDead : State, IState
    {
        public void InitState(string nameScene, IState iState, DataState dataState)
        {
            enumState = EnumState.StateFamilyDead;

            Publisher.SetIState(iState);
            Publisher.SetDataState(dataState);

            SceneManager.LoadScene(nameScene);
        }

   
    }
}