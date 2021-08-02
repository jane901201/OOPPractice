using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;
using Unreal.BaseClass;

namespace Unreal.Dialogue
{
    public class DialogueSystem : IGameSystem
    {
        private TextAsset inkAsset;
        private LocalizedObject storyLocal;
        private Story story;
        private Action setButton;
        private Action setName;
        private Action setSentence;

        public Action ActionButton { get => setButton; set => setButton = value; } //TODO:����n��ActionName��H�U��Ӫ��W�r
        public Action ActionName { get => setName; set => setName = value; }
        public Action ActionSentence { get => setSentence; set => setSentence = value; }

        public DialogueSystem()
        {

        }

        public void Initialize()
        {
            inkAsset = storyLocal.LoadAsset() as TextAsset;
            story = new Story(inkAsset.text);
            
        }

        public void SetButton(Button button)
        {

        }

        public void RefreshView()
        {
            while (story.canContinue)
            {
                string sentence = story.Continue();
                sentence.Trim();
                CreateContentView(sentence);
            }

            if (story.currentChoices.Count > 0) //�p�G���ﶵ�A�N�|���b�o��
            {
                for (int i = 0; i < story.currentChoices.Count; i++)
                {
                    Choice choice = story.currentChoices[i];

                    ActionButton();//TODO:�I�sDialogueUI��Button����r�]�w
                }
            }
            else
            {
                //TODO:��奻Ū�������A�I�s�D�{��������ܸ��_���
            }
        }

        private void CreateContentView(string sentence)
        {
            ActionSentence(); //TODO:�]�wActionSentence()�����
        }

        public void SetName(string sentence)
        {
            //TODO:��Ū���W�r���覡�g�X�ӡA�٦��n�h���W�r�������A�r��̥u�ѤU�y�l
            if (sentence.Contains(":"))
            {
                if (sentence.Contains("Player:"))
                {
                    ActionName();//TODO:Ū��DialogueUI��m_Name�A�N�W�r�令Localization���]�w
                }
                else
                {
                    ActionName();//TODO:Ū��DialogueUI��m_Name�A�N�W�r�令�_���e���r
                }
            }
        }

        public void SetStoryLocal(LocalizedObject storyLocal)
        {
            this.storyLocal = storyLocal;
        }

        private void OnClickChoiceButton(Choice choice)
        {
            story.ChooseChoiceIndex(choice.index);
            RefreshView();
        }




    }

}
