using System.Collections;
using System.Collections.Generic;
using UnityEngine.Localization.Components;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Localization.Events;

public class Converation : MonoBehaviour
{
    [SerializeField] private LocalizeStringEvent topic;
    [SerializeField] private LocalizeStringEvent name;
    [SerializeField] private LocalizeSpriteEvent avatar;
    private UnityEventString updateString;

    Text text;
    public void ClickToContinue()
    {
        topic.StringReference.StringChanged += StringReference_StringChanged;
    }

    private void StringReference_StringChanged(string value)
    {
        throw new NotImplementedException();
    }
}

[Serializable]
public class ConverationList
{
    public List<Converation> converations = new List<Converation>();
}
