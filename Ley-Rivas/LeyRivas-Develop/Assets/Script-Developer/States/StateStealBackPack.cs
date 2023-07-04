
namespace Leyrivas
{
    public class StateStealBackPack : State, IState
    {
        private int money;

        public bool InitState()
        {
            throw new System.NotImplementedException();
        }
        public int GetMoney() { return money; }

    }
}