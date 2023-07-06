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

        public EnumState GetDataState()
        {
            return lastState;
        }


    }
}