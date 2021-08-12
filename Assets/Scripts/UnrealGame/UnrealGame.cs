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
           
            SetMainMenuScene();
            //SetTempleScene();          
        }

        private void Update()
        {
            SceneUpdate();
        }
    }

}