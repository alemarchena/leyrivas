using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Leyrivas
{
    public class Delivery : MonoBehaviour
    {
        [SerializeField] EnumState enumState = EnumState.StateStealBackPack;

        /// <summary>
        /// Envía un mensaje al publisher para que actualice el DataState
        /// El contexto actuará en consecuencia y cargará la escena
        /// </summary>
        public void SendMessageToPublisher()
        {
            Publisher.SetState(enumState);
        }
     
    }
}
