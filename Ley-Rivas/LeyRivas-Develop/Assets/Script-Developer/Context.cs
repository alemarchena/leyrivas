using Leyrivas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leyrivas
{
    public class Context : MonoBehaviour
    {
        [SerializeField] DataState dataState;
        [SerializeField] DataScene dataScene;
        EnumState lastEnumState;

        private void Start()
        {
            GetDataState();
        }

        public EnumState GetLastState()
        {
            return lastEnumState;
        }

        public bool DetermineState(IState iState, string nameScene)
        {
            return  iState.InitState(nameScene);
        }

        public void GetDataState()
        {
            if (dataState == null)
            {
                //Determina el estado actual del juego
                lastEnumState = dataState.GetDataState();

                

            }
            else
            {
                Debug.LogError("Falta asociar la clase DataState a la clase Context");
            }
        }

        
    }
}
