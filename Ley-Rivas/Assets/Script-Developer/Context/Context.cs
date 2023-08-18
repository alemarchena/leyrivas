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
            RecursiveLookDataState();
        }

        public void RecursiveLookDataState()
        {
            if (dataState == null || dataScene == null)
            {
                Debug.LogError("Verifique las clases DataState y DataScene que estén asociadas en la clase Context");
            }
            else
            {
                EnumState lastEnumState = DetermineState(dataState.GetDataState());
                StopCoroutine(ObserverChangeScene(lastEnumState));
                StartCoroutine(ObserverChangeScene(lastEnumState));
            }
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
                    
                    IState iState = null;

                    GameObject gao = new();
                    gao.AddComponent<SceneAdmin>();
                    iState = gao.GetComponent< SceneAdmin>().ReturnInterface(itemDicState);

                    if(iState != null)
                    {
                        iState.InitState(itemDicState.nameScene,iState,dataState);
                    }

                    return itemDicState.enumState;
                }
            }

            return EnumState.ScenePresentacion;
        }

       

        IEnumerator ObserverChangeScene(EnumState lastEnumState)
        {
            yield return new WaitWhile( () => dataState.GetDataState() == lastEnumState);
            RecursiveLookDataState();
        }

       
    }
}
