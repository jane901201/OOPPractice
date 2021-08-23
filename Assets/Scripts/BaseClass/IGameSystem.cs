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

        public Action release;
        public Action gsUpdate;

        public virtual void Initialize() //TODO:之後要刪掉
        {

        }

        public virtual void Initialize(Action initialize) //TODO:跟IUserInterface有重複function，之後要改
        {

        }

        public virtual void Update(Action update)
        {

        }

        public virtual void Release(Action release)
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

