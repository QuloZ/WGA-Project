﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneryShield : Skills
{
    void Start()
    {
        _name = "Энергетический щит";
        cooldown = 6;
        duration = 3;
        mf = 0;

    }

    public int Effect()
    {

        return 0;
    }
}