using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Events;
using Unreal.BaseClass;
using UnityEngine.UI;
using Ink.Runtime;

namespace Unreal.Dialogue
{
    public class DialogueSystem : IGameSystem
    {
        public TextAsset inkAsset;
        public Story m_TestStory;
        public LocalizedObject m_StoryLocal;
        private Story story;
        private ConverationData m_ConverationData;

        public DialogueSystem()
        {

        }

       

        private void Awake()
        {
            m_StoryLocal.SetReference("InkText", "1");
            inkAsset = m_StoryLocal.LoadAsset() as TextAsset;
            m_TestStory = new Story(inkAsset.text);
        }


        public void RefreshView()
        {
            while (story.canContinue)
            {
                string sentence = story.Continue();

                sentence.Trim();
            }

            if (story.currentChoices.Count > 0)
            {
                for (int i = 0; i < story.currentChoices.Count; i++)
                {
                    Choice choice = story.currentChoices[i];
                    Button temBtn = null;
                    /*switch (i)
                    {
                        case 0:
                            temBtn = m_DialogueUI.ButtonA;
                            break;
                        case 1:
                            temBtn = m_DialogueUI.ButtonB;
                            break;
                        case 2:
                            temBtn = m_DialogueUI.ButtonC;
                            break;
                        case 3:
                            temBtn = m_DialogueUI.ButtonD;
                            break;
                        default:
                            Debug.Log("story.currentChoices.Count Error");
                            break;
                    }*/
                    // Tell the button what to do when we press it
                    temBtn.onClick.AddListener(delegate {
                        OnClickChoiceButton(choice);
                    });
                }
            }
            else
            {
                //TODO:當文本讀取完畢，呼叫主程式消除對話跟恢復行動
            }
        }

        public void SetName(string sentence)
        {
            //TODO:把讀取名子的方式寫出來
            if (sentence.Contains(":"))
            {
                if (sentence.Contains("Player:"))
                {

                }
            }
            else
            {

            }


        }

        public void ShowButton()
        {

        }

        void OnClickChoiceButton(Choice choice)
        {
            story.ChooseChoiceIndex(choice.index);
            RefreshView();
        }

    }

}
