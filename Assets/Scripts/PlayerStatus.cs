﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerStats")]
public class PlayerStatus : ScriptableObject
{
    public int score;
    public int playerFullHealth = 3;
    public int playerCurrentHealth;
    public float speed = 0.01f;
    public float maxSpeed = 50;
    public float maxAcc = 10;
    public float decelerate = 10;
    public float forwardForce = 100;
    public float jumpSpeed = 100;

    private void OnEnable()
    {
        score = 0;
    }
}
