using System.Collections;
using UnityEngine;

namespace Unreal
{
    public partial class UnrealGame
    {
        public void SaveSceneName()
        {
            string name = m_SceneController.GetCurrectSceneName();
            m_SaveDataManager.SetSceneName(name);
        }



    }
}