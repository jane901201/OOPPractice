using System.Collections;
using UnityEngine;
using Unreal.BaseClass;

namespace Unreal
{
    public partial class UnrealGame : MonoBehaviour
    {

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            UnrealAwake();
        }

        private void Start()
        {
            UnrealStart();       
        }

        private void Update()
        {
            UnrealUpdate();
            SceneUpdate();
        }
    }

}