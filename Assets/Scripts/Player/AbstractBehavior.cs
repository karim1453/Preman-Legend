﻿using Assets.Scripts.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class AbstractBehavior:MonoBehaviour
    {
        [SerializeField]
        protected Buttons[] inputButtons;
        [SerializeField]
        protected MonoBehaviour[] disabledScripts;
        protected InputState inputState;
        protected Rigidbody2D body2D;
        
        void Awake()
        {
            inputState = GetComponent<InputState>();
            body2D = GetComponent<Rigidbody2D>();
        }
        protected void ToogleScript(bool value)
        {
            foreach (var script in disabledScripts)
            {
                script.enabled = value;
            }
        }
    }
}
