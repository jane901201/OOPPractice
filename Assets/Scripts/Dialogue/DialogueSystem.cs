using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Events;
using UnityEngine.UI;

namespace Unreal.Dialogue
{
    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField] private Converation converation;
        private UnityEventString updateString;
    
        [SerializeField] private Text sentenceText;
        [SerializeField] private Text name;
        [SerializeField] private Image avatar;
    

        public DialogueSystem(Converation converation)
        {

        }
    
    }

}
