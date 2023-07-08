

using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class StateLitoDead : State, IState, IScene
    {

        public bool InitState(string nameScene)
        {
            activedState = true;
            SceneManager.LoadScene(nameScene);
            return activedState;
        }


        public void LoadFuntionalityScene()
        {

        }
    }
}