﻿// Type: FezEngine.Effects.Structures.SemanticMappedBoolean
// Assembly: FezEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 11F00D13-0150-47CC-B906-98B362969219
// Assembly location: F:\Program Files (x86)\FEZ\FezEngine.dll

using Microsoft.Xna.Framework.Graphics;

namespace FezEngine.Effects.Structures
{
  public class SemanticMappedBoolean : SemanticMappedParameter<bool>
  {
    public SemanticMappedBoolean(EffectParameterCollection parent, string semanticName)
      : base(parent, semanticName)
    {
    }

    protected override void DoSet(bool value)
    {
      this.parameter.SetValue(value ? 1f : 0.0f);
      this.currentValue = value;
    }
  }
}
