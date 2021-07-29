using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/MainMenuUI")]
    public class MainMenuUI : MonoBehaviour
    {
        [SerializeField] private Button m_BeginBtn;
        [SerializeField] private Button m_ContinureBtn;
        [SerializeField] private Button m_LeaveBtn;

        private void Awake()
        {
            
        }


    }
}

