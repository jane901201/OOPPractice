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

        public void Initinal() //TODO:�Ȯɤ��~�ӡA���g�X�Ӧb�~��
        {

        }

        public void UIUpdate()
        {

        }

        public override void Release()
        {
            //TODO:List������
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

        public void 

        public Button ButtonA { get => m_ButtonA; set => m_ButtonA = value; }
        public Button ButtonB { get => m_ButtonB; set => m_ButtonB = value; }
        public Button ButtonC { get => m_ButtonC; set => m_ButtonC = value; }
        public Button ButtonD { get => m_ButtonD; set => m_ButtonD = value; }

        public void SetAllBtnState(int btnNum, Action OnClickChoiceBtn, Text btnText)
        {
            switch (btnNum) //TODO:���Ӭ�s��H�u�t���g�k
            {
                case 0:
                    m_ButtonA.onClick.AddListener(() => OnClickChoiceBtn());
                    ShowButtonA();
                    break;
                case 1:
                    m_ButtonB.onClick.AddListener(() => OnClickChoiceBtn());
                    ShowButtonB();
                    break;
                case 2:
                    m_ButtonC.onClick.AddListener(() => OnClickChoiceBtn());
                    ShowButtonC();
                    break;
                case 3:
                    m_ButtonD.onClick.AddListener(() => OnClickChoiceBtn());
                    ShowButtonD();
                    break;
                default:
                    Debug.Log("Something error happen in DialogueUI's button"); //TODO:�n�ܦ��ҥ~��X
                    break;
            }
        }



        #endregion

      


    }
}

