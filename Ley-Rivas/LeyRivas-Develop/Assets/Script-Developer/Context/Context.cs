using Leyrivas;
using System.Collections;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
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
                    try
                    {
                        Destroy(GameObject.Find("ChildOfContext"));
                    }
                    catch { }

                    GameObject go = new();
                    GameObject contextGameObject = Instantiate(go, this.transform) as GameObject;
                    try
                    {
                        contextGameObject.name = "ChildOfContext";
                    }
                    catch { }

                    IState iState = null;

                    if(itemDicState.enumState == EnumState.StateNone)           { iState = contextGameObject.AddComponent<StateNoMoney>(); }
                    if(itemDicState.enumState == EnumState.StateNoMoney)        { iState = contextGameObject.AddComponent<StateNoMoney>(); }
                    if(itemDicState.enumState == EnumState.StateStealBackPack)  { iState = contextGameObject.AddComponent<StateStealBackPack>(); }
                    if(itemDicState.enumState == EnumState.StateFamilyDead)     { iState = contextGameObject.AddComponent<StateFamilyDead>(); }
                    if(itemDicState.enumState == EnumState.StateLitoDead)       { iState = contextGameObject.AddComponent<StateLitoDead>(); }


                    

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
