using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Tables;
using Unreal.Dialogue;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/DialogueUI")]
    public class DialogueUI : LocalizedMonoBehaviour
    {
        [SerializeField] private GameObject m_SentencePanel;
        [SerializeField] private Text m_NameText;
        [SerializeField] private Text m_Sentence;
        [SerializeField] private Image m_Avatar;

        [SerializeField] private GameObject m_ChoicePanel;
        [SerializeField] private Button m_ButtonA;
        [SerializeField] private Button m_ButtonB;
        [SerializeField] private Button m_ButtonC;
        [SerializeField] private Button m_ButtonD;


        #region Sentence
        public void ShowSentence()
        {
            m_SentencePanel.SetActive(true);
        }

        public void HideSentence()
        {
            m_SentencePanel.SetActive(false);
        }

        public void SetNameText(string name)
        {
            m_NameText.text = name;
        }


        public void SetSentenceText(string sentence)
        {
            m_Sentence.text = sentence;
        }

        public void SetAvatar(Image avater)
        {
            m_Avatar = avater;
        }

        #endregion

        #region Choice
        public void ShowChoice()
        {
            m_ChoicePanel.SetActive(true);
        }

        public void HideChoice()
        {
            m_ChoicePanel.SetActive(false);
        }

        #endregion




    }
}

