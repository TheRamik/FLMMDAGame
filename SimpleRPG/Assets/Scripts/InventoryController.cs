﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public static InventoryController Instance { get; set; }
    public ConsumableController consumeableController;

    private void Start()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;
        consumeableController = GetComponent<ConsumableController>();

    }

}
