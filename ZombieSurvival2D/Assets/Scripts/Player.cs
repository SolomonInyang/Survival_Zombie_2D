﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    [SerializeField]
    private float healthValue;
    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private Statistics stamina;
    [SerializeField]
    private float staminaValue;
    [SerializeField]
    private float maxStamina;


    [SerializeField]
    private Statistics armor;
    [SerializeField]
    private float armorValue;
    [SerializeField]
    private float maxArmor;

    protected override void Start()
    {
      //  health.Initialize(healthValue,maxHealth);
        //stamina.Initialize(staminaValue, maxStamina);
        //armor.Initialize(armorValue, maxArmor);
        base.Start();
    }

    protected override void Update()
    {
        InputKeys();
        //health.CurrentValue = 100;
        base.Update();
    }

    private void InputKeys()
    {
        Direction = Vector2.zero;

        if(Input.GetKey(KeyCode.W))
        {
            Direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Direction += Vector2.down; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            Direction += Vector2.right;
        }
    }
    
}
