using Leyrivas;
using System.Collections;
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
            LookDataState();
        }

        public EnumState DetermineState(EnumState lastEnumState)
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

                    iState.InitState(itemDicState.nameScene,iState,dataState);

                    return itemDicState.enumState;
                }
            }

            return EnumState.StateNone;
        }

        public void LookDataState()
        {
            if (dataState == null || dataScene == null)
            {
                Debug.LogError("Verifique las clases DataState y DataScene que estén asociadas en la clase Context");
            }
            else
            {
                EnumState lastEnumState = DetermineState(dataState.GetDataState());
                StartCoroutine(ObserverChangeScene(lastEnumState));
            }
        }

        IEnumerator ObserverChangeScene(EnumState lastEnumState)
        {
            yield return new WaitWhile( () => dataState.GetDataState() == lastEnumState);
            LookDataState();
        }

       
    }
}
