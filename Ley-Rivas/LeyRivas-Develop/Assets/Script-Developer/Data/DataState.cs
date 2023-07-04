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
        bool activatedNoMoneyState, activatedStealBackPackState, activatedFamilyDeadState, activatedLitoDeadState;

        public bool GetNoMoneyState(){ return activatedNoMoneyState; }
        public void SetNoMoneyState(bool value){ activatedNoMoneyState = value; }

        public bool GetStealBackPackState(){return activatedStealBackPackState;}
        public void SetStealBackPackState(bool value){ activatedStealBackPackState=value; }

        public bool GetFamilyDeadState(){return  activatedFamilyDeadState;}
        public void SetFamilyDeadState(bool value){ activatedFamilyDeadState = value; }

        public bool GetLitoDeadState(){return activatedLitoDeadState;}
        public void SetLitoDeadState(bool value){ activatedLitoDeadState = value; }

    }
}