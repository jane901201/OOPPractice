using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI類別的繼承
/// TODO:未來可能有些東西會跟IGameSystem一起提出來
/// 一般會以Initialize等等類別做初始，有需要其他類別的話就用Delegate
/// TODO:未來Initialize要強制override
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
        Destroy(gameObject); //TODO:直接消除會有BUG，要用List
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
