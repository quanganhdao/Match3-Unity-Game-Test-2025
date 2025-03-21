﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }
    public override void SetView()
    {
        if (View != null)
        {
            //Debug.Log("view of normal: " + View.name);
            View.gameObject.SetActive(true);
            return;
        }
        base.SetView();
    }
    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    protected override string GetPrefabName()
    {
        return Constants.PREFAB_NORMAL_TYPE_ONE;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }

    public void SetSkin(NormalSkinConfig config)
    {
        // Debug.Log("SetSkin " + config.name);
        View.GetComponent<SpriteRenderer>().sprite = config.GetSprite(ItemType);
    }
}
