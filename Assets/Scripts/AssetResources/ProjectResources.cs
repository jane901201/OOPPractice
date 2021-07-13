using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ��o����
 */
public class ProjectResources : IResources
{

    public const string PlayerPath = "Characters/Player/";
    public const string EnemyPath = "Characters/Enemy/";
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

    public override void LoadEffect(string EffectName)
    {
        UnityEngine.Object res = LoadGameObjectFromResourcePath(EffectPath + EffectName);
    }

    public override Sprite LoadSprite(string SpriteName)
    {
        //Sprite res = Resources.Load<Sprite>(SpritePath + SpriteName);
        Sprite res = Resources.Load<Sprite>(SpritePath + SpriteName);

        if (res == null)
        {
            Debug.Log("�L�k���J���|" + SpritePath + SpriteName);
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


    // ����GameObject
    private GameObject InstantiateGameObject(string AssetName)
    {
        // �qResrouce�����J
        UnityEngine.Object res = LoadGameObjectFromResourcePath(AssetName);
        if (res == null)
            return null;
        return UnityEngine.Object.Instantiate(res) as GameObject;
    }

    // �qResrouce�����J
    public UnityEngine.Object LoadGameObjectFromResourcePath(string AssetPath)
    {
        UnityEngine.Object res = Resources.Load(AssetPath);
        if (res == null)
        {
            Debug.LogWarning("�L�k���J���|[" + AssetPath + "]�W��Asset");
            return null;
        }
        return res;
    }
}
