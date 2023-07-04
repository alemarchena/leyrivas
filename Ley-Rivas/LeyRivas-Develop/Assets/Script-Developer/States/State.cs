
using UnityEngine;

namespace Leyrivas
{
    public class State : MonoBehaviour
    {
        protected EnumState enumState;
        protected bool activedState;

        protected bool GetActivedState{ get { return activedState; } }
    }
}