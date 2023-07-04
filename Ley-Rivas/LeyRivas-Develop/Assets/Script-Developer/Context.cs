using Leyrivas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leyrivas
{
    public class Context : MonoBehaviour
    {
        [SerializeField] DataState dataState;
        EnumState lastEnumState;

        private void Start()
        {
            GetDataState();
        }

        public EnumState GetLastState()
        {
            return lastEnumState;
        }

        public bool DetermineState(IState iState)
        {
            return iState.InitState();
        }

        public void GetDataState()
        {
            if (dataState == null)
            {
                //Determina el estado actual del juego
                
                if (!dataState.GetNoMoneyState())
                {
                    StateNoMoney stateNoMoney = gameObject.AddComponent<StateNoMoney>();
                    dataState.SetNoMoneyState(DetermineState(stateNoMoney));
                }
                else
                {lastEnumState = EnumState.StateNoMoney; }

                if (!dataState.GetStealBackPackState())
                {
                    StateStealBackPack stateStealBackPack= gameObject.AddComponent<StateStealBackPack>();
                    dataState.SetStealBackPackState(DetermineState(stateStealBackPack));
                }
                else
                {lastEnumState = EnumState.StateStealBackPack;}

                if (!dataState.GetFamilyDeadState())
                {
                    StateFamilyDead stateFamilyDead = gameObject.AddComponent<StateFamilyDead>();
                    dataState.SetFamilyDeadState(DetermineState(stateFamilyDead));
                }
                else
                {lastEnumState = EnumState.StateFamilyDead;}
                
                if (!dataState.GetLitoDeadState())
                {
                    StateLitoDead stateLitoDead = gameObject.AddComponent<StateLitoDead>();
                    dataState.SetLitoDeadState(DetermineState(stateLitoDead));
                }
                else
                {lastEnumState = EnumState.StateLitoDead;}


            }
            else
            {
                Debug.LogError("Falta asociar la clase DataState a la clase Context");
            }
        }

        
    }
}
