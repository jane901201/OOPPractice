using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/LoadingUI")]
    public class LoadingUI : IUserInterface
    {
        [SerializeField] private GameObject loadingScreen;
        [SerializeField] private Slider slider;
        [SerializeField] private Text progressText;


    }
}

