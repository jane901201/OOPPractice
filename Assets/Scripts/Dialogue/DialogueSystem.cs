using Ink.Runtime;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Localization;
using Unreal.BaseClass;


namespace Unreal.Dialogue
{

    public class DialogueSystem : IGameSystem
    {
        private TextAsset m_InkAsset = null;
        private LocalizedTextAsset m_StoryLocal = null;
        private LocalizedString m_CharacterNameLocal;
        private Story m_Story;


        public delegate void SetName(string name);
        public SetName m_SetName;
        public delegate void SetSentence(string sentence);
        public SetSentence m_SetSentence;
        public delegate void SetChoiceBtn(Action OnClickChoiceBtn, int i, Choice choice);
        public SetChoiceBtn m_SetChoiceBtn;


        private string m_TmpName;
        private string m_TmpSentence;
        private bool m_IsOnClick = false;
        private bool m_StoryEnd = false;

        public void Initialize()
        {
            m_InkAsset = m_StoryLocal.LoadAsset();
            m_Story = new Story(m_InkAsset.text);
            m_StoryEnd = false;
            m_CharacterNameLocal = new LocalizedString();
            m_TmpName = "";
            m_TmpSentence = "";
            RefreshView();
        }


        public void RefreshView()
        {
            
            if(m_Story.canContinue)
            {
                string sentence = m_Story.Continue();
                Debug.Log(sentence);
                sentence.Trim();
                SplitSentenceAndSetSentenceandName(sentence);
            }
            else if (m_Story.currentChoices.Count > 0) //�p�G���ﶵ�A�N�|���b�o��
            {
                for (int buttonNum = 0; buttonNum < m_Story.currentChoices.Count; buttonNum++)
                {
                    Choice choice = m_Story.currentChoices[buttonNum];
                    string text = choice.text.Trim();
                    m_SetChoiceBtn(() => OnClickChoiceButton(choice), buttonNum, choice);
                }
                //TODO:SetChoicePanel
            }
           
            if(!m_Story.canContinue && m_Story.currentChoices.Count <= 0)
            {
                StoryEnd();
            }

        }

        public void SplitSentenceAndSetSentenceandName(string sentence)
        {
            //TODO:��Ū���W�r���覡�g�X�ӡA�٦��n�h���W�r�������A�r��̥u�ѤU�y�l
            if (sentence.Contains(":"))
            {
                
                string[] data = sentence.Split(':'); //TODO:���θ�b�檺���D
                m_TmpName = data[0];
                m_TmpSentence = data[1];
                if (m_TmpName.Equals("Player"))
                {
                    m_CharacterNameLocal.SetReference("Name", "Default"); //TODO:�����s�W�r��J
                    m_SetName(m_CharacterNameLocal.GetLocalizedString());
                    //TODO:Ū��DialogueUI��m_Name�A�N�W�r�令Localization���]�w
                }
                else
                {
                    m_SetName(m_TmpName); //TODO:Ū��DialogueUI��m_Name�A�N�W�r�令�_���e���r
                }

                m_SetSentence(m_TmpSentence);

            }
            else
            {
                m_TmpName = "";
                m_TmpSentence = sentence;
                m_SetName(m_TmpName);
                m_SetSentence(m_TmpSentence);
            }
        }


        public void SetStoryLocal(LocalizedTextAsset storyLocal)
        {
            this.m_StoryLocal = storyLocal;
        }

        private void OnClickChoiceButton(Choice choice)
        {
            m_Story.ChooseChoiceIndex(choice.index);
            RefreshView();
        }

        private void StoryEnd()
        {
            m_StoryEnd = true;
            //TODO:��奻Ū�������A�I�s�D�{��������ܸ��_���
            //���ܵ����ɡA����DialogueUI

        }

        public bool IsStoryEnd()
        {
            return m_StoryEnd;
        }

        public bool IsOnClick()
        {
            return m_IsOnClick;
        }
    }

}
