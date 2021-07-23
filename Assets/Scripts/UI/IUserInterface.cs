using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IUserInterface : MonoBehaviour
{
    private bool m_bActive = true;

    public bool IsVisible()
    {
        return m_bActive;
    }

    public virtual void Show()
    {
        gameObject.SetActive(true);
        m_bActive = true;
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

    public virtual void Initialize()
    {

    }

    public virtual void Release()
    {

    }

    public virtual void UIUpdate()
    {

    }
}
