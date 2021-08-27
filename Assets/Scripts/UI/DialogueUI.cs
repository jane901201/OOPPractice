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
    public class DialogueUI : IUserInterface
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

        public override void Initialize()
        {
            base.Initialize();
            //m_DelegateInitialize();
        }

        public override void UIUpdate()
        {
            base.UIUpdate();
        }

        public override void Release()
        {
            base.Release();
        }

        public void ShowChoicesAndHideSentences()
        {
            ShowChoicePanel();
            HideSentencePanel();
        }

        public void ShowSentencesAndHideChoices()
        {
            ShowSentencePanel();
            HideChoicePanel();
        }

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

        public void SetAllurBtnHiding()
        {
            HideButtonA();
            HideButtonB();
            HideButtonC();
            HideButtonD();
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

        public void SetBtnAddListener(Action OnClickChoiceBtn) //TODO:Delegate要設定的東西，之後要調整
        {
            OnClickChoiceBtn();
            ShowSentencesAndHideChoices();
        }

        public void SetAllBtnState(int btnNum, Action OnClickChoiceBtn, string btnText)
        {
            ShowChoicesAndHideSentences();

            switch (btnNum) //TODO:未來研究抽象工廠的寫法
            {
                case 0:
                    m_ButtonA.GetComponentInChildren<Text>().text = btnText;
                    m_ButtonA.onClick.AddListener(() => SetBtnAddListener(OnClickChoiceBtn));
                    ShowButtonA();
                    break;
                case 1:
                    m_ButtonB.GetComponentInChildren<Text>().text = btnText;
                    m_ButtonB.onClick.AddListener(() => SetBtnAddListener(OnClickChoiceBtn));
                    ShowButtonB();
                    break;
                case 2:
                    m_ButtonC.GetComponentInChildren<Text>().text = btnText;
                    m_ButtonC.onClick.AddListener(() => SetBtnAddListener(OnClickChoiceBtn));
                    ShowButtonC();
                    break;
                case 3:
                    m_ButtonD.GetComponentInChildren<Text>().text = btnText;
                    m_ButtonD.onClick.AddListener(() => SetBtnAddListener(OnClickChoiceBtn));
                    ShowButtonD();
                    break;
                default:
                    Debug.Log("Something error happen in DialogueUI's button"); //TODO:要變成例外丟出
                    break;
            }
        }



        #endregion

    }
}

