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

        public Button BeginBtn { get => m_BeginBtn; set => m_BeginBtn = value; }
        public Button ContinureBtn { get => m_ContinureBtn; set => m_ContinureBtn = value; }
        public Button LeaveBtn { get => m_LeaveBtn; set => m_LeaveBtn = value; }
    }
}

