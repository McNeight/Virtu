﻿using System;

namespace Jellyfish.Virtu.Services
{
    public abstract class VideoService
    {
        public abstract void SetPixel(int x, int y, uint color);
        public abstract void Update();

        public void ToggleFullScreen()
        {
            IsFullScreen ^= true;
        }

        public bool IsFullScreen { get; private set; }
    }
}