

using UnityEngine.SceneManagement;

namespace Leyrivas
{
    public class StateNoMoney : State, IState, IScene
    {
        private int money;
        public bool InitState(string nameScene)
        {
            activedState = true;
            SceneManager.LoadScene(nameScene);
            return activedState;
        }

        public int GetMoney(){return money;}

        /// <summary>
        /// Retorna "true" si pudo agregar dinero sino retorna "false"
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool AddMoney(int amount){
            if(amount>0)
            {
                money+=amount;
                return true;
            }
            else{return false;}
        }

        /// <summary>
        /// Retorna "true" si pudo restar dinero sino retorna "false"
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool SustractMoney(int amount)
        {
            if (amount > 0)
            {
                money -= amount;
                return true;
            }
            else{return false;}
        }

        public void LoadFuntionalityScene()
        {

        }

    }
}