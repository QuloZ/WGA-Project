﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneryShield : Skills, Mate, Poison
{
    int heal;
    public override void Init(Unit unit)
    {
        this.unit = unit;

        _name = "Регенерация";
        cooldown = 6;
        duration = 3;
        durationTimer = 0;
        mf = 0;

    }

    public override int[] Effect()
    {
        // result[0] - count, result[1] - stats:
        // 0 - HP
        // 1 - strenght
        // 2 - agility
        // 3 - vitality
        // 4 - dmg (mf)
        int[] result = new int[2];
        if (heal < 1)
        {
            heal = 1;
        }

        result[0] = heal;
        result[0] *= -1;
        result[1] = 0;
        
        return result;
    }
    public override int Attack()
    {
        EffectInit();
        StartCoolDown();
        return 0;
    }
    public void EffectInit()
    {
        durationTimer = duration;
        heal = (int)(BattleManager.target.GetComponent<Unit>().hitPoint * 0.05);
    }


}
