 Vector2 position;
        Texture2D texture;
        Vector2 center;
        float angle = 0;

        public Fiende(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.center = position;
        }
        public void Update()
        {
            angle+= .1f;
            position.X = center.X + (float)Math.Sin(angle)* 700;
            position.Y = center.Y + (float)Math.Cos(angle);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.ToPoint(), new Point(200, 200)), Color.White);
        }
