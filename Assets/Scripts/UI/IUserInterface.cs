using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI���O���~��
/// TODO:���ӥi�঳�ǪF��|��IGameSystem�@�_���X��
/// �@��|�HInitialize�������O����l�A���ݭn��L���O���ܴN��Delegate
/// TODO:����Initialize�n�j��override
/// </summary>
public abstract class IUserInterface : MonoBehaviour
{

    public Action m_DelegateInitialize;
    public Action m_DelegateUpdate;
    public Action m_DegegateRelease;

    private bool active = true;

    public virtual void Initialize()
    {

    }

    public virtual void UIUpdate()
    {

    }

    public virtual void Release()
    {
        Destroy(gameObject); //TODO:���������|��BUG�A�n��List
    }

    public bool IsVisible()
    {
       
        return this.active;
    }

    public virtual void Show()
    {
        gameObject.SetActive(true);
        this.active = true;
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

 

}
