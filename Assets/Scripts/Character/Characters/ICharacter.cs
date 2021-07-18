using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICharacter
{
    protected string name = "";
    protected GameObject gameObject = null;
    protected AudioSource audio = null;
    protected IWeapon weapon = null;
    protected ICharacterAttr attribute = null;
    protected IRole role = null;
    private IArmor armor = null;

    protected bool killed = false;
    protected bool canRemove = false;

    public ICharacter()
    {

    }

    public void SetGameObject(GameObject theGameObject)
    {
        gameObject = theGameObject;
        audio = gameObject.GetComponent<AudioSource>();
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void Release()
    {
        if(gameObject != null)
        {
            GameObject.Destroy(gameObject);
        }
    }

    public string GetName()
    {
        return name;
    }

    public IRole Role
    {
        get { return role; }
        set { role = value; }
    }

    public IArmor Armor { get => armor; set => armor = value; }
}
