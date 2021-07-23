using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unreal.BaseClass
{
    public abstract class IGameSystem
    {

        public delegate void InitializeDeleagte();

        private InitializeDeleagte InitializeFunc;
       
        public virtual void Initinalize()
        {
            
        }

        protected virtual void Update()
        {
        
        }


        public virtual void Release()
        {

        }

        public virtual void SetinitializeDeleagte(InitializeDeleagte initialize)
        {
            this.InitializeFunc += initialize;
        }
    }
}

