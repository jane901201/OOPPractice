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
        [SerializeField] private GameObject sentencePanel; 
        [SerializeField] private Text m_NameText; //TODO:name會跟Object.name衝突，要取其他名字
        [SerializeField] private Text sentence;
        [SerializeField] private Image avatar;
        [SerializeField] private Button continueButton;

        [SerializeField] private GameObject choicePanel;
        [SerializeField] private Button buttonA;
        [SerializeField] private Button buttonB;
        [SerializeField] private Button buttonC;
        [SerializeField] private Button buttonD;



        #region Sentence
        public void ShowSentence()
        {
            sentencePanel.SetActive(true);
        }

        public void HideSentence()
        {
            sentencePanel.SetActive(false);
        }

        public void SetNameText(string name)
        {
            this.m_NameText.text = name;
        }

        public void SetSentenceText(string sentence)
        {
            this.sentence.text = sentence;
        }

        public void SetAvatar(Image avater)
        {
            this.avatar = avater;
        }

        public Button ContinueButton { get => continueButton; set => continueButton = value; }
      

        #endregion

        #region Choice
        public void ShowChoices()
        {
            choicePanel.SetActive(true);
        }

        public void HideChoices()
        {
            choicePanel.SetActive(false);
        }

        public void ShowChoicePanel()
        {
            choicePanel.SetActive(true);
        }

        public void HideChoicePanel()
        {
            choicePanel.SetActive(false);
        }

        public void ShowButtonA()
        {
            buttonA.gameObject.SetActive(true);
        }

        public void HideButtonA()
        {
            buttonA.gameObject.SetActive(false);
        }

        public void ShowButtonB()
        {
            buttonB.gameObject.SetActive(true);
        }

        public void HideButtonB()
        {
            buttonB.gameObject.SetActive(false);
        }

        public void ShowButtonC()
        {
            buttonC.gameObject.SetActive(true);
        }

        public void HideButtonC()
        {
            buttonC.gameObject.SetActive(false);
        }

        public void ShowButtonD()
        {
            buttonD.gameObject.SetActive(true);
        }

        public void HideButtonD()
        {
            buttonD.gameObject.SetActive(false);
        }

        public Button ButtonA { get => buttonA; set => buttonA = value; }
        public Button ButtonB { get => buttonB; set => buttonB = value; }
        public Button ButtonC { get => buttonC; set => buttonC = value; }
        public Button ButtonD { get => buttonD; set => buttonD = value; }

        #endregion




    }
}

