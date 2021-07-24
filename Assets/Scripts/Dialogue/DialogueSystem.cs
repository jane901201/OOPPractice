using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Events;
using Unreal.BaseClass;

namespace Unreal.Dialogue
{
    public class DialogueSystem : IGameSystem
    {
        private LocalizedString m_Name;


        public DialogueSystem()
        {

        }


        public void UpdateSentence()//
        {
            string table = "Begin";
            string entry = "2";
            m_Name.SetReference(table, entry);
        }



    }

}
