

using System.Diagnostics;
using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class StateFamilyDead : State, IState,IScene
    {
        public bool InitState(string nameScene)
        {
            activedState = true;
            SceneManager.LoadScene(nameScene);
            return true;
        }

        public void LoadFuntionalityScene()
        {
            
        }
    }
}