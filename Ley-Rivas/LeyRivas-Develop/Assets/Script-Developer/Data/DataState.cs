using UnityEngine;

namespace Leyrivas
{
    /* Diagrama de clases
     https://drive.google.com/file/d/1wKqvEkm-JsbIsHk0RHzHvlB_Kk5Vh1rZ/view?usp=sharing 
    */

    [CreateAssetMenu(fileName = "DataState", menuName = "Data/state", order = 1)]
    public class DataState : ScriptableObject
    {
        [SerializeField]
        private EnumState lastState;

        /// <summary>
        /// Devuelve la �ltima escena cargada.
        /// </summary>
        /// <returns></returns>
        public EnumState GetDataState()
        {
            return lastState;
        }

        public void SetState( EnumState state)
        {
            lastState = state;
        }

    }
}