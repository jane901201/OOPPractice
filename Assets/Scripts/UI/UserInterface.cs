using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UserInterface : MonoBehaviour
{

    private Action initialize;
    private Action uiUpdate;
    private Action release;

    private bool active = true;

    public Action Initialize { get => initialize; set => initialize = value; }
    public Action UIUpdate { get => uiUpdate; set => uiUpdate = value; }
    public Action Release { get => release; set => release = value; }

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
