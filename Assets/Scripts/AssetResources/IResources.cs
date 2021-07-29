using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class IResources
{
    public abstract GameObject LoadPlayer(string PlayerName);
    public abstract GameObject LoadWeapon(string WeaponName);

    public abstract Sprite LoadCharacterAvatar(string CharacterAvatarName);
    public abstract AudioClip LoadAudioClip(string AudioClipName);
    public abstract void LoadEffect(string EffectName);
    public abstract Sprite LoadSprite(string SpriteName);

    public abstract GameObject LoadUI(string UIName);
   
}
