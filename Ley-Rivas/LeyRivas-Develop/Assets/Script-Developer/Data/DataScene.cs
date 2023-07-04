using UnityEngine;

namespace Leyrivas
{
    /* Diagrama de clases
     https://drive.google.com/file/d/1wKqvEkm-JsbIsHk0RHzHvlB_Kk5Vh1rZ/view?usp=sharing 
    */

    [CreateAssetMenu(fileName = "DataScene", menuName = "Data/scene", order = 2)]
    public class DataScene : ScriptableObject
    {
        [SerializeField]
        string nameNoMoneyStateScene, nameStealBackPackStateScene, nameFamilyDeadStateScene, nameLitoDeadStateScene;
        public string GetNameNoMoneyScene(){ return nameNoMoneyStateScene; }
        public string GetNameStealBackPackScene(){return nameStealBackPackStateScene; }
        public string GetNameFamilyDeadScene(){return nameFamilyDeadStateScene; }
        public string GetNameLitoDeadScene(){return nameLitoDeadStateScene; }
    }
}