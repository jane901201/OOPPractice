using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Tables;
using Unreal.Dialogue;
using System;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/DialogueUI")]
    public class DialogueUI : UserInterface
    {
        [SerializeField] private GameObject m_SentencePanel; 
        [SerializeField] private Text m_CharacterName;
        [SerializeField] private Text m_Sentence;
        [SerializeField] private Image m_Avatar;
        [SerializeField] private Button m_ContinueButton;

        [SerializeField] private GameObject m_ChoicePanel;
        [SerializeField] private Button m_ButtonA;
        [SerializeField] private Button m_ButtonB;
        [SerializeField] private Button m_ButtonC;
        [SerializeField] private Button m_ButtonD;



        #region Sentence
        public void ShowSentencePanel()
        {
            m_SentencePanel.SetActive(true);
        }

        public void HideSentencePanel()
        {
            m_SentencePanel.SetActive(false);
        }

        public void SetNameText(string name)
        {
            this.m_CharacterName.text = name;
        }

        public void SetSentenceText(string sentence)
        {
            this.m_Sentence.text = sentence;
        }

        public void SetAvatar(Image avater)
        {
            this.m_Avatar = avater;
        }

        public Button ContinueButton { get => m_ContinueButton; set => m_ContinueButton = value; }
      

        #endregion

        #region Choice
        public void ShowChoices()
        {
            m_ChoicePanel.SetActive(true);
        }

        public void HideChoices()
        {
            m_ChoicePanel.SetActive(false);
        }

        public void ShowChoicePanel()
        {
            m_ChoicePanel.SetActive(true);
        }

        public void HideChoicePanel()
        {
            m_ChoicePanel.SetActive(false);
        }

        public void ShowButtonA()
        {
            m_ButtonA.gameObject.SetActive(true);
        }

        public void HideButtonA()
        {
            m_ButtonA.gameObject.SetActive(false);
        }

        public void ShowButtonB()
        {
            m_ButtonB.gameObject.SetActive(true);
        }

        public void HideButtonB()
        {
            m_ButtonB.gameObject.SetActive(false);
        }

        public void ShowButtonC()
        {
            m_ButtonC.gameObject.SetActive(true);
        }

        public void HideButtonC()
        {
            m_ButtonC.gameObject.SetActive(false);
        }

        public void ShowButtonD()
        {
            m_ButtonD.gameObject.SetActive(true);
        }

        public void HideButtonD()
        {
            m_ButtonD.gameObject.SetActive(false);
        }

        public Button ButtonA { get => m_ButtonA; set => m_ButtonA = value; }
        public Button ButtonB { get => m_ButtonB; set => m_ButtonB = value; }
        public Button ButtonC { get => m_ButtonC; set => m_ButtonC = value; }
        public Button ButtonD { get => m_ButtonD; set => m_ButtonD = value; }

        #endregion

        public override void Release()
        {
            base.Release();
        }


    }
}

