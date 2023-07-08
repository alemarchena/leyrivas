using Unity.VisualScripting;
using UnityEngine;

namespace Leyrivas
{
    public static class Publisher
    {
        private static DataState dataState;
        private static IState istate;

        public static void SetDataState(DataState dataStateReceived)
        {
            dataState = dataStateReceived;
        }

        public static void SetState(EnumState enumState)
        {
            try
            {
                dataState.SetState(enumState);
            }
            catch
            {
                Debug.LogError("La escena debe ser cargada solo por el Context");
            }
        }

        public static void SetIState(IState stateRecibed)
        {
            istate = stateRecibed;
        }

        public static IState GetIState()
        {
            return istate;
        }
    }
}
