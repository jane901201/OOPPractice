using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Events;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

public class LoclaizationTest :MonoBehaviour
{

    public LocalizeStringEvent localizeStringEvent;

    // Start is called before the first frame update
    void Start()
    {
        localizeStringEvent.StringReference.SetReference("Begin", "2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
