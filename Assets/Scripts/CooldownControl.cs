﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownControl : MonoBehaviour
{
    public InteractablesStats interactablesStats;
    public PlayerStats playerStats;
    public GameObject overheatControl;
    float initialSpeed;
    float initialSpawnRate;
    public bool cooldownEnabled = false;
    public bool statsSet = false;

    // Update is called once per frame
    void Update()
    {
        if (cooldownEnabled)
        {
            Cooldown();
        }
    }

    void Cooldown()
    {
        if (statsSet == false)
        {
            initialSpeed = interactablesStats.interactableSpeed;
            interactablesStats.interactableSpeed *= playerStats.cooldownSpeedMultiplier;
            overheatControl.GetComponent<OverheatControl>().overheatEnabled = false;
            statsSet = true;
        }

        if (overheatControl.GetComponent<OverheatControl>().timeLeft < overheatControl.GetComponent<OverheatControl>().overheatTime)
        {
            overheatControl.GetComponent<OverheatControl>().timeLeft += Time.deltaTime * playerStats.cooldownRateMultiplier;
        }
    }

    public void ResetStats() {
        interactablesStats.interactableSpeed = initialSpeed;
        overheatControl.GetComponent<OverheatControl>().overheatEnabled = true;
    }
}
