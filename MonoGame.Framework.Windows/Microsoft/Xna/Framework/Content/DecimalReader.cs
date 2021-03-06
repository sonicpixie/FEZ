﻿// Type: Microsoft.Xna.Framework.Content.DecimalReader
// Assembly: MonoGame.Framework.Windows, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2107839-320D-467B-B82A-28CB452CC584
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.Windows.dll

using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class DecimalReader : ContentTypeReader<Decimal>
  {
    internal DecimalReader()
    {
    }

    protected internal override Decimal Read(ContentReader input, Decimal existingInstance)
    {
      return input.ReadDecimal();
    }
  }
}
