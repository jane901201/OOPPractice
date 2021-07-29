using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 莉眔ン
 */
public class ProjectResources : IResources
{

    public const string PlayerPath = "Characters/Player/";
    public const string EnemyPath = "Characters/Enemy/";
    public const string CharacterAvatarTestPath = "CharacterAvatar/CharacterAvatarTest";
    public const string UIPath = "UI/";
    public const string WeaponPath = "Weapons/";
    public const string EffectPath = "Effects/";
    public const string AudioPath = "Audios/";
    public const string SpritePath = "Sprites/";

    public override AudioClip LoadAudioClip(string AudioClipName)
    {
        AudioClip res = Resources.Load<AudioClip>(AudioPath + AudioClipName);
        if (res == null)
            return null;
        return res;
    }

    public override GameObject LoadPlayer(string PlayerName)
    {
        UnityEngine.Object res = LoadGameObjectFromResourcePath(PlayerPath + PlayerName);
        if (res == null)
            return null;
        return res as GameObject;
    }


    public override Sprite LoadCharacterAvatar(string CharacterAvatarName)
    {
        Sprite res = Resources.Load<Sprite>(SpritePath + CharacterAvatarName);

        if (res == null)
        {
            Debug.Log("礚猭更隔畖" + SpritePath + CharacterAvatarName);
            return null;
        }
        return res;
    }
    public override void LoadEffect(string EffectName)
    {
        UnityEngine.Object res = LoadGameObjectFromResourcePath(EffectPath + EffectName);
    }

    public override GameObject LoadUI(string UIName)
    {
        UnityEngine.Object res = LoadGameObjectFromResourcePath(UIPath + UIName);
        if (res == null)
            return null;
        return res as GameObject;
    }

    public override Sprite LoadSprite(string SpriteName)
    {
        //Sprite res = Resources.Load<Sprite>(SpritePath + SpriteName);
        Sprite res = Resources.Load<Sprite>(SpritePath + SpriteName);

        if (res == null)
        {
            Debug.Log("礚猭更隔畖" + SpritePath + SpriteName);
            return null;
        }
        return res;
    }

    public override GameObject LoadWeapon(string WeaponName)
    {
        UnityEngine.Object res = LoadGameObjectFromResourcePath(SpritePath + WeaponName);
        if (res == null)
            return null;
        return res as GameObject;
    }

   

    // 眖Resrouceい更
    public UnityEngine.Object LoadGameObjectFromResourcePath(string AssetPath)
    {
        UnityEngine.Object res = Resources.Load(AssetPath);
        if (res == null)
        {
            Debug.LogWarning("礚猭更隔畖[" + AssetPath + "]Asset");
            return null;
        }
        return res;
    }

   
}
