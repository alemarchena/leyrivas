
using UnityEngine;


namespace Leyrivas
{
    public class SceneAdmin : MonoBehaviour
    {

        public IState ReturnInterface(DictionaryStateScene itemDicState)
        {
            GameObject go = new();
            GameObject contextGameObject = Instantiate(go, this.transform) as GameObject;
            try
            {
                contextGameObject.name = "ChildOfContext";
            }
            catch { }

            IState iState = null;

            if (itemDicState.enumState == EnumState.ScenePresentacion)  { iState = contextGameObject.AddComponent<StateCredits>(); }
            if (itemDicState.enumState == EnumState.SceneAlmacen) { iState = contextGameObject.AddComponent<SceneAlmacen>(); }
            if (itemDicState.enumState == EnumState.SceneBoxeador) { iState = contextGameObject.AddComponent<SceneBoxeador>(); }
            if (itemDicState.enumState == EnumState.SceneCuniado) { iState = contextGameObject.AddComponent<SceneCuniado>(); }
            if (itemDicState.enumState == EnumState.SceneConversationCuniado) { iState = contextGameObject.AddComponent<SceneConversationCuniado>(); }
            if (itemDicState.enumState == EnumState.SceneRivas) { iState = contextGameObject.AddComponent<SceneRivas>(); }
            if (itemDicState.enumState == EnumState.SceneConversationRivas) { iState = contextGameObject.AddComponent<SceneConversationRivas>(); }
            if (itemDicState.enumState == EnumState.SceneViasDelTren) { iState = contextGameObject.AddComponent<SceneViasDelTren>(); }
            if (itemDicState.enumState == EnumState.ScenePolicia) { iState = contextGameObject.AddComponent<ScenePolicia>(); }
            if (itemDicState.enumState == EnumState.SceneConversationPolicia) { iState = contextGameObject.AddComponent<SceneConversationPolicia>(); }
            if (itemDicState.enumState == EnumState.SceneBaldio) { iState = contextGameObject.AddComponent<SceneBaldio>(); }
            if (itemDicState.enumState == EnumState.SceneMapa) { iState = contextGameObject.AddComponent<SceneMapa>(); }
            if (itemDicState.enumState == EnumState.StateCredits) { iState = contextGameObject.AddComponent<StateCredits>(); }
            if (itemDicState.enumState == EnumState.Dead) { iState = contextGameObject.AddComponent<Dead>(); }


            return iState;
        }
    }
}
