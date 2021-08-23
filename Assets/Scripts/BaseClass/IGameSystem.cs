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

        public Action release;
        public Action gsUpdate;

        public virtual void Initialize() //TODO:����n�R��
        {

        }

        public virtual void Initialize(Action initialize) //TODO:��IUserInterface������function�A����n��
        {

        }

        public virtual void Update(Action update)
        {

        }

        public virtual void Release(Action release)
        {

        }

        public virtual void RegisterGameEvent(Register initialize) //TODO:����n�R��
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

