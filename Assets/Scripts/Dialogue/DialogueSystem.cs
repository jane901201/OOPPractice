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

        public Action ActionButton { get => setButton; set => setButton = value; } //TODO:之後要改ActionName跟以下兩個的名字
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

            if (story.currentChoices.Count > 0) //如果有選項，就會停在這裡
            {
                for (int i = 0; i < story.currentChoices.Count; i++)
                {
                    Choice choice = story.currentChoices[i];

                    ActionButton();//TODO:呼叫DialogueUI的Button做文字設定
                }
            }
            else
            {
                //TODO:當文本讀取完畢，呼叫主程式消除對話跟恢復行動
            }
        }

        private void CreateContentView(string sentence)
        {
            ActionSentence(); //TODO:設定ActionSentence()的行動
        }

        public void SetName(string sentence)
        {
            //TODO:把讀取名字的方式寫出來，還有要去掉名字的部分，字串裡只剩下句子
            if (sentence.Contains(":"))
            {
                if (sentence.Contains("Player:"))
                {
                    ActionName();//TODO:讀取DialogueUI的m_Name，將名字改成Localization的設定
                }
                else
                {
                    ActionName();//TODO:讀取DialogueUI的m_Name，將名字改成冒號前的字
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
