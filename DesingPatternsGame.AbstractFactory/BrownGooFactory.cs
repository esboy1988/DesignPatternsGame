﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.AbstractFactory
{
    public class BrownGooFactory : IEnemyFactory
    {
        public Common.GameSprite Create(ContentManager content, Vector2 spritePosition)
        {
            return new BrownGoo(content.Load<Texture2D>("MorphGoo"), spritePosition);
        }
    }
}