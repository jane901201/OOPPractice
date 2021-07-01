using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerAttrTest
{
    [Test]
    public void GetDamage()
    {
        int str = PlayerAttr.Damage(10, 1);
        Assert.AreEqual(9, str);
    }
}
