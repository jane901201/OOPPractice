using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unreal.BaseClass
{
    /// <summary>
    /// �C���t�ΥD�n�|�~�Ӫ����O
    /// TODO:���ӥi�঳�ǪF��|��IGameSystem�@�_���X��
    /// �@��|�HInitialize�������O����l�A���ݭn��L���O���ܴN��Delegate
    /// </summary>

    public abstract class IGameSystem //TODO:��IGameSystem�����n���W�r�A��GameSystem�|�X��
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

