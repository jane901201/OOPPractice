using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Tables;
namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/DialogueUI")]
    public class DialogueUI : LocalizedMonoBehaviour
    {
        [SerializeField] private LocalizedString m_NameLocal;
        [SerializeField] private LocalizedString m_SentenceLocal;
        [SerializeField] private LocalizedSprite m_AvaterLocal;
        [SerializeField] private Text m_NameText;
        [SerializeField] private Text m_SentenceText;
        [SerializeField] private Image m_Avatar;

        public void UpdateNameText(string entry)
        {

        }

        public void UpdateNameLocal()//
        {
            string table = "Begin";
            string entry = "2";
            m_NameLocal.SetReference(table, entry);
            SetNameText(m_NameLocal.GetLocalizedString());
        }

        public void SetNameText(string name)
        {
            m_NameText.text = name;
        }


        public void SetSentenceText(string sentence)
        {
            m_SentenceText.text = sentence;
        }

        public void SetAvatar(Image avater)
        {
            m_Avatar = avater;
        }

    }
}

