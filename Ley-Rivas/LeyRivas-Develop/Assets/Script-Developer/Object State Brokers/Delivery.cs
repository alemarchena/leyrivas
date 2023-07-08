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
        /// Env�a un mensaje al publisher para que actualice el DataState
        /// El contexto actuar� en consecuencia y cargar� la escena
        /// </summary>
        public void SendMessageToPublisher()
        {
            Publisher.SetState(enumState);
        }
     
    }
}
