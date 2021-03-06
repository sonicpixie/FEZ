﻿// Type: Microsoft.Xna.Framework.IDrawable
// Assembly: MonoGame.Framework.Windows, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2107839-320D-467B-B82A-28CB452CC584
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.Windows.dll

using System;

namespace Microsoft.Xna.Framework
{
  public interface IDrawable
  {
    int DrawOrder { get; }

    bool Visible { get; }

    event EventHandler<EventArgs> DrawOrderChanged;

    event EventHandler<EventArgs> VisibleChanged;

    void Draw(GameTime gameTime);
  }
}
