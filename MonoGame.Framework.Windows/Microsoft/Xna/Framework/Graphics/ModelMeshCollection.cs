﻿// Type: Microsoft.Xna.Framework.Graphics.ModelMeshCollection
// Assembly: MonoGame.Framework.Windows, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2107839-320D-467B-B82A-28CB452CC584
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.Windows.dll

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class ModelMeshCollection : ReadOnlyCollection<ModelMesh>
  {
    public ModelMesh this[string meshName]
    {
      get
      {
        ModelMesh modelMesh;
        if (!this.TryGetValue(meshName, out modelMesh))
          throw new KeyNotFoundException();
        else
          return modelMesh;
      }
    }

    internal ModelMeshCollection(IList<ModelMesh> list)
      : base(list)
    {
    }

    public bool TryGetValue(string meshName, out ModelMesh value)
    {
      if (string.IsNullOrEmpty(meshName))
        throw new ArgumentNullException("meshName");
      foreach (ModelMesh modelMesh in (ReadOnlyCollection<ModelMesh>) this)
      {
        if (string.Compare(modelMesh.Name, meshName, StringComparison.Ordinal) == 0)
        {
          value = modelMesh;
          return true;
        }
      }
      value = (ModelMesh) null;
      return false;
    }
  }
}
