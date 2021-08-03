using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace Unreal.Dialogue
{
    [AddComponentMenu("Localization/Asset/Localize Text Asset")]
    public class LocalizeTextAssetEvent : LocalizedAssetEvent<TextAsset, LocalizedTextAsset, UnityEventTextAsset>
    {

    }
}