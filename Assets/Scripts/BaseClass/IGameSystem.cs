using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unreal.BaseClass
{
    /// <summary>
    /// 遊戲系統主要會繼承的類別
    /// </summary>

    public abstract class IGameSystem //TODO:把IGameSystem改比較好的名字，改GameSystem會出事
    {

        public delegate void Register();
        private Register InitializeFunc;

        public Action initialize;
        public Action release;
        public Action gsUpdate;

        public virtual void RegisterGameEvent(Register initialize)
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

