﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackMagic
{
    internal class BasicDemonAI : Trait
    {
        static Lamb player;
        TDMovement movement;

        const string name = "BasicDemonAI";
        public BasicDemonAI(Entity parent, TDMovement movement) : base(name, parent)
        {
            player = Globals.MainEntityBatch.player;

            this.movement = movement;
        }

        public override void Update(GameTime gameTime)
        {
            if (gameTime.TotalGameTime.TotalSeconds < 1) 
                return;

            float angleToPlayer = MathF.Atan2(player.Y - parent.Y, player.X - parent.X);
            movement.Move(gameTime, angleToPlayer);
        }
    }
}
