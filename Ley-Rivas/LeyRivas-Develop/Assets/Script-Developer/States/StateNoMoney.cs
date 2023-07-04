

namespace Leyrivas
{
    public class StateNoMoney : State, IState
    {
        private int money;
        public bool InitState()
        {
            activedState = true;
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
    }
}