using System.Collections;
using UnityEngine;

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
            
          
        }

        private void Update()
        {
            SceneUpdate();
        }
    }

}