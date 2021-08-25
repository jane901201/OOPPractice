using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unreal.BaseClass
{
    /// <summary>
    /// 遊戲系統主要會繼承的類別
    /// TODO:未來可能有些東西會跟IGameSystem一起提出來
    /// 一般會以Initialize等等類別做初始，有需要其他類別的話就用Delegate
    /// </summary>

    public abstract class IGameSystem //TODO:把IGameSystem改比較好的名字，改GameSystem會出事
    {

        public delegate void Register();
        private Register InitializeFunc;

        public Action m_DelegateInitialize;
        public Action m_DelegateGameSystemUpdate;
        public Action m_DegegateRelease;

        public virtual void Initialize()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Release()
        {

        }

        public virtual void RegisterGameEvent(Register initialize) //TODO:之後要刪掉
        {
            this.InitializeFunc += initialize;
        }

        //TODO:存檔系統的讀入
        public virtual void SaveData()
        {

        }

        public virtual void LoadData()
        {

        }
    }
}

