using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unreal.BaseClass;
/// <summary>
/// 暫時將IGameSystem的Delegate的宣告放在這裡
/// </summary>
namespace Unreal
{
    public partial class UnrealGame
    {

        List<IGameSystem> m_GameSystems = new List<IGameSystem>();

        public void AddGameSystem(IGameSystem gameSystem) //還是需要先Release在做移除吧
        {
            m_GameSystems.Add(gameSystem);
        }

        public void RemoveGameSystem(IGameSystem gameSystem) //還是需要先Release在做移除吧..?
        {
            if(m_GameSystems.Contains(gameSystem))
            {
                m_GameSystems.Remove(gameSystem);
            }
        }

        public void SetSaveDataManagerDelegateInitialize()
        {
            m_SaveDataManager.m_DelegateInitialize = delegate ()
            {
                m_SaveDataManager.SetResources(m_Resources);
            };
        }

        public void SetSceneControllerDelegateInitialize()
        {
            m_SceneController.m_DelegateInitialize = delegate ()
            {
                m_SceneController.SetLoadingUI(CreateLoadingUI);
            };
        }
    }
}