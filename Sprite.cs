using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    public class Sprite
    {
        private Texture2D _texture;
        public Vector2 Position;

        public float Speed = 5f;

        public Sprite (Texture2D texture)
        {
            _texture = texture;
        }

        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                //up
                Position.Y -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                //left
                Position.X -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                //down
                Position.Y += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                //right
                Position.X += Speed;
            }
        }

        public void Draw (SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, Color.Aquamarine);
        }
    }
}
