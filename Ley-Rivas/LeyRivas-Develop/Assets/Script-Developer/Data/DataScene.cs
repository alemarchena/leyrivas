using UnityEngine;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Leyrivas
{
    /* Diagrama de clases
     https://drive.google.com/file/d/1wKqvEkm-JsbIsHk0RHzHvlB_Kk5Vh1rZ/view?usp=sharing 
    */

    [CreateAssetMenu(fileName = "DataScene", menuName = "Data/scene", order = 2)]
    public class DataScene : ScriptableObject
    {
        [SerializeField] List<DictionaryStateScene> listDictionary;

        public List<DictionaryStateScene> ListDictionary
        {
            get{
                return listDictionary;
            }
        }
        
    }

    [System.Serializable]
    public class DictionaryStateScene
    {
        public EnumState enumState;
        public string nameScene;
    }
}