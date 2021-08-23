using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IUserInterface : MonoBehaviour
{

    private bool active = true;

    public virtual void Initialize(Action initialize)
    {
        initialize();
    }

    public virtual void UIUpdate(Action update)
    {
        update();
    }

    public virtual void Release(Action release)
    {
        release();
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

    public virtual void Release()
    {
        Destroy(gameObject); //TODO:直接消除會有BUG，要用List
    }

}
