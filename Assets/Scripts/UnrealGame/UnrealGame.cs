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
           
            SetMainMenuScene(); //TODO:看來這裡的視窗就有點問題了......
            //SetTempleScene();          
        }

        private void Update()
        {
            SceneUpdate();
        }
    }

}