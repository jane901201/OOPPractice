using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class LocalizedTextWithFont : MonoBehaviour
{
    [Serializable]
    public class LocalizedFont : LocalizedAsset<Font> { }

    public LocalizedString localizedString;
    public LocalizedFont localizedFont;

    public Text uiText;

    void OnEnable()
    {
        localizedString.StringChanged += UpdateText;
        localizedFont.AssetChanged += FontChanged;
    }

    void OnDisable()
    {
        localizedString.StringChanged -= UpdateText;
        localizedFont.AssetChanged -= FontChanged;
    }

    void FontChanged(Font f)
    {
        uiText.font = f;
    }

    void UpdateText(string s)
    {
        uiText.text = s;
    }
}
