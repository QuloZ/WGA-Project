﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Skills : MonoBehaviour
{
    public string _name;
    protected int cooldown;
    public int cooldownTimer = 0;
    public int cooldownTimerBASE = 0;
    internal bool isCurrent = false;

    public int duration;
    public int durationTimer;
    

    protected Unit unit;
    internal double mf;
    public Sprite spriteON;
    public Sprite spriteOFF;

    protected string trigger;
    protected string triggerEffect;

    public abstract int[] Attack();
    public abstract int[] Effect(Transform transform);
    public abstract void Init(Unit unit);
    public virtual void EffectAnimation(Transform transform) {
        if (particle != null)
        {
            print("создаем анимацию эффекта");
            GameObject anim = Instantiate(particle, transform.position, Quaternion.identity);
        }
        else { print("нет партикла"); }
    }

    public void StartCoolDown()
    {
        cooldownTimer = cooldownTimerBASE + cooldown;
    }

    public GameObject particle;

    public void DecreaseCoolDown()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer--;
        }

    }
    public int GetCooldown() {
        return cooldown;
    }
    public string GetTrigger()
    {
        return trigger;
    }
    public string GetTriggerEffect()
    {
        return triggerEffect;
    }
}
