using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unreal.BaseClass
{
    /// <summary>
    /// �C���t�ΥD�n�|�~�Ӫ����O
    /// </summary>

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

        //TODO:�s�ɨt�Ϊ�Ū�J
        public virtual void SaveData()
        {

        }

        public virtual void LoadData()
        {

        }
    }
}

