using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unreal.BaseClass
{
    public abstract class IGameSystem //TODO:��IGameSystem�����n���W�r�A��GameSystem�|�X��
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
    }
}

