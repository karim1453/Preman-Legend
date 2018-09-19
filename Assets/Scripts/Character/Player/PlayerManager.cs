﻿using Assets.Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Character
{
    public class PlayerManager:MonoBehaviour
    {
        private CollisionState collisionState;
        private PlayerMovement playerMovement;
        private PlayerShoot playerShoot;
        private PlayerMelee playerMeele;
        private Animator animator;
        private PlayerJump playerJump;
        void Awake()
        {
            playerJump = GetComponent<PlayerJump>();
            animator = GetComponent<Animator>();
            playerMovement = GetComponent<PlayerMovement>();
            playerShoot = GetComponent<PlayerShoot>();
            playerMeele = GetComponent<PlayerMelee>();
            collisionState = GetComponent<CollisionState>();
        }
        void Update()
        {
            if (collisionState.Standing)
                ChangeAnimation(0);
            if (playerMovement.AbsvelX>0)
                ChangeAnimation(1);
            if (playerMeele.IsAttack)
                ChangeAnimation(2);
            if (playerShoot.IsAttack)
                ChangeAnimation(3);
            if (playerMovement.absVelY > 0)
                ChangeAnimation(6);
        }
        void ChangeAnimation(int value)
        {
            animator.SetInteger("playerAnimState", value);
        }
    }
}