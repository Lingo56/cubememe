﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleControl : MonoBehaviour
{
    public GameObject obsticle;
    public GameObject gameManager;
    private Vector3 moveDirection = Vector3.zero;
    private float forwardForce;
    public int rotationAmount = 0;
    public bool movementEnabled = true;

    private void Start()
    {
        forwardForce = gameManager.GetComponent<GameManager>().objectSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (movementEnabled)
        {
            obsticleMovement();
        }
    }

    void obsticleMovement() {
        moveDirection = new Vector3(0.0f, 0.0f, forwardForce);

        transform.Translate(moveDirection * Time.deltaTime);

        obsticle.transform.Rotate(0, rotationAmount, 0);
    }
}
