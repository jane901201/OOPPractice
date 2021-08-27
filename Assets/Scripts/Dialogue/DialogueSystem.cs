using Ink.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using Unreal.BaseClass;


namespace Unreal.Dialogue
{

    public class DialogueSystem : IGameSystem
    {
        //TODO:消除掉這邊所有的delegate
        public delegate void SetName(string name);
        public SetName m_MustBeRemove_SetName;
        public delegate void SetSentence(string sentence);
        public SetSentence m_MustBeRemove_SetSentence;
        public delegate void SetAvatar();
        public SetAvatar m_MustBeRemove_SetAvater;
        public delegate void SetChoiceBtn(int btnNum, Action OnClickChoiceBtn, string choiceText);
        public SetChoiceBtn m_MustBeRemove_SetChoiceBtn;
        public delegate void SetChoicePanel();
        public SetChoicePanel m_MustBeRemove_SetChoicePanel;

        private TextAsset m_InkAsset = null;
        private LocalizedString m_CharacterNameLocal;
        private Ink.Runtime.Story m_Story; //TODO:以防萬一，我暫時先加一下Ink的Story的namespace，我怕災難出現

        private Action<string> m_SetName;
        private Action<string> m_SetSentence;
        private Action m_SetAvatar;
        private Func<Dictionary<int, Action>> m_SetChoiceActionBtns;
        private Func<Dictionary<int, string>> m_SetBtnText;

        private string m_TmpName;
        private string m_TmpSentence;
        //private bool m_IsOnClick = false;
        private bool m_StoryEnd = false;


        public override void Initialize()
        {
            m_Story = new Story(m_InkAsset.text);
            m_StoryEnd = false;
            m_CharacterNameLocal = new LocalizedString();
            m_TmpName = "";
            m_TmpSentence = "";
            RefreshView();
            //TODO:m_DelegateInitialize();
        }



        public override void Update()
        {
            if(IsStoryEnd())
            {
                //TODO:結束對話系統
            }
        }

        public void GetName(Action<string> action)
        {
            m_SetName = action;
        }



        public void RefreshView()
        {
            
            if(m_Story.canContinue)
            {
                string sentence = m_Story.Continue();
                sentence.Trim();
                SplitSentenceAndSetSentenceandName(sentence);
            }
            else if (m_Story.currentChoices.Count > 0)
            {

                //TODO:產生出比較不會出事情的Btn系統
                for (int buttonNum = 0; buttonNum < m_Story.currentChoices.Count; buttonNum++)
                {
                    Choice choice = m_Story.currentChoices[buttonNum];
                    string choiceText = choice.text.Trim();
                    //TODO:與其一次設定一個Btn，不如一次記錄完所有的東西，再傳給DialgoueUI做設定
                    m_MustBeRemove_SetChoiceBtn(buttonNum, () => OnClickChoiceButton(choice), choiceText);
                }
                m_MustBeRemove_SetChoicePanel();
            }
           
            if(!m_Story.canContinue && m_Story.currentChoices.Count <= 0)
            {
                StoryEnd();
            }

        }

        public void SplitSentenceAndSetSentenceandName(string sentence)
        {
            if (sentence.Contains(":") || sentence.Contains("："))
            {
                
                string[] data = sentence.Split(':'); //TODO:全形跟半行的問題
                m_TmpName = data[0];
                m_TmpSentence = data[1];
                if (m_TmpName.Equals("Player"))
                {
                    m_CharacterNameLocal.SetReference("Name", "Default"); //TODO:之後研究名字輸入
                    m_MustBeRemove_SetName(m_CharacterNameLocal.GetLocalizedString());
                }
                else
                {
                    m_MustBeRemove_SetName(m_TmpName);
                }

                m_MustBeRemove_SetSentence(m_TmpSentence);

            }
            else
            {
                m_TmpName = "";
                m_TmpSentence = sentence;
                m_MustBeRemove_SetName(m_TmpName);
                m_MustBeRemove_SetSentence(m_TmpSentence);
            }
        }


        public void SetStoryTextAsset(TextAsset storyTextAsset)
        {
            m_InkAsset = storyTextAsset;
        }

        private void OnClickChoiceButton(Choice choice)
        {
            m_Story.ChooseChoiceIndex(choice.index);
            RefreshView();
        }

        private void StoryEnd()
        {
            m_StoryEnd = true;
            //TODO:當文本讀取完畢，呼叫主程式消除對話跟恢復行動

        }

        public bool IsStoryEnd()
        {
            return m_StoryEnd;
        }

        //public bool IsOnClick()
        //{
        //    return m_IsOnClick;
        //}
    }

}
