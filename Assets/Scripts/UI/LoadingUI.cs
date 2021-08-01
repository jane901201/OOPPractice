using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unreal.UI
{
    [AddComponentMenu("UnrealUI/LoadingUI")]
    public class LoadingUI : UserInterface
    {
        [SerializeField] private GameObject loadingScreen;
        [SerializeField] private Slider slider;
        [SerializeField] private Text progressText;

        public GameObject LoadingScreen { get => loadingScreen; set => loadingScreen = value; }
        public Slider Slider { get => slider; set => slider = value; }
        public Text ProgressText { get => progressText; set => progressText = value; }
    }
}

