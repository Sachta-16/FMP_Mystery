﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (mySpriteRenderer != null)
            {
                mySpriteRenderer.flipX = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            mySpriteRenderer.flipX = false;
        }
    }
}
