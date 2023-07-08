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

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        private void Start()
        {
            GetDataState();
        }

        public void DetermineState(EnumState lastEnumState)
        {
            
            foreach (DictionaryStateScene itemDicState in dataScene.ListDictionary)
            {
                if(itemDicState.enumState == lastEnumState)
                {
                    IState iState = gameObject.AddComponent<StateNoMoney>();

                    if(itemDicState.enumState == EnumState.StateNone)           { iState = gameObject.AddComponent<StateNoMoney>(); }
                    if(itemDicState.enumState == EnumState.StateNoMoney)        { iState = gameObject.AddComponent<StateNoMoney>(); }
                    if(itemDicState.enumState == EnumState.StateStealBackPack)  { iState = gameObject.AddComponent<StateStealBackPack>(); }
                    if(itemDicState.enumState == EnumState.StateFamilyDead)     { iState = gameObject.AddComponent<StateFamilyDead>(); }
                    if(itemDicState.enumState == EnumState.StateLitoDead)       { iState = gameObject.AddComponent<StateLitoDead>(); }

                    iState.InitState(itemDicState.nameScene);

                    return;
                }
            }
        }

        public void GetDataState()
        {
            if (dataState == null || dataScene == null)
            {
                Debug.LogError("Verifique las clases DataState y DataScene que estén asociadas en la clase Context");
            }
            else
            {
                DetermineState(dataState.GetDataState());
            }
        }
    }
}
