using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/DialogueUI")]
    public class DialogueUI : IUserInterface
    {
        [SerializeField] private LocalizeStringEvent m_LocalizeStringEvent;
        [SerializeField] private Text m_NameText;
        [SerializeField] private Text m_SentenceText;
    }
}

