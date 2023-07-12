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

    if (itemDicState.enumState == EnumState.ScenePresentacion)  { iState = contextGameObject.AddComponent<StateCredits>(); }
    if(itemDicState.enumState == EnumState.SceneAlmacen)        { iState = contextGameObject.AddComponent<SceneAlmacen>(); }
    if(itemDicState.enumState == EnumState.SceneBoxeador)       { iState = contextGameObject.AddComponent<SceneBoxeador>(); }
    if(itemDicState.enumState == EnumState.SceneCuniado)        { iState = contextGameObject.AddComponent<SceneCuniado>(); }
    if(itemDicState.enumState == EnumState.SceneConversationCuniado){ iState = contextGameObject.AddComponent<SceneConversationCuniado>(); }
    if(itemDicState.enumState == EnumState.SceneRivas)          { iState = contextGameObject.AddComponent<SceneRivas>(); }
    if(itemDicState.enumState == EnumState.SceneConversationRivas) { iState = contextGameObject.AddComponent<SceneConversationRivas>(); }
    if(itemDicState.enumState == EnumState.SceneViasDelTren)    { iState = contextGameObject.AddComponent<SceneViasDelTren>(); }
    if(itemDicState.enumState == EnumState.ScenePolicia)        { iState = contextGameObject.AddComponent<ScenePolicia>(); }
    if(itemDicState.enumState == EnumState.SceneConversationPolicia) { iState = contextGameObject.AddComponent<SceneConversationPolicia>(); }
    if(itemDicState.enumState == EnumState.SceneBaldio)         { iState = contextGameObject.AddComponent<SceneBaldio>(); }
    if(itemDicState.enumState == EnumState.SceneMapa)           { iState = contextGameObject.AddComponent<SceneMapa>(); }
    if(itemDicState.enumState == EnumState.StateCredits)        { iState = contextGameObject.AddComponent<StateCredits>(); }

                    iState.InitState(itemDicState.nameScene,iState,dataState);

                    return itemDicState.enumState;
                }
            }

            return EnumState.ScenePresentacion;
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
