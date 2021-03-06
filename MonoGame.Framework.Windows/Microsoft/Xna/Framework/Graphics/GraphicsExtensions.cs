﻿// Type: Microsoft.Xna.Framework.Graphics.GraphicsExtensions
// Assembly: MonoGame.Framework.Windows, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2107839-320D-467B-B82A-28CB452CC584
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.Windows.dll

using OpenTK.Graphics.OpenGL;
using System;
using System.Diagnostics;

namespace Microsoft.Xna.Framework.Graphics
{
  public static class GraphicsExtensions
  {
    public static All OpenGL11(CullMode cull)
    {
      switch (cull)
      {
        case CullMode.CullClockwiseFace:
          return All.Cw;
        case CullMode.CullCounterClockwiseFace:
          return All.Ccw;
        default:
          throw new NotImplementedException();
      }
    }

    public static int OpenGLNumberOfElements(this VertexElementFormat elementFormat)
    {
      switch (elementFormat)
      {
        case VertexElementFormat.Single:
          return 1;
        case VertexElementFormat.Vector2:
          return 2;
        case VertexElementFormat.Vector3:
          return 3;
        case VertexElementFormat.Vector4:
          return 4;
        case VertexElementFormat.Color:
          return 4;
        case VertexElementFormat.Byte4:
          return 4;
        case VertexElementFormat.Short2:
          return 2;
        case VertexElementFormat.Short4:
          return 2;
        case VertexElementFormat.NormalizedShort2:
          return 2;
        case VertexElementFormat.NormalizedShort4:
          return 4;
        case VertexElementFormat.HalfVector2:
          return 2;
        case VertexElementFormat.HalfVector4:
          return 4;
        default:
          throw new NotImplementedException();
      }
    }

    public static VertexPointerType OpenGLVertexPointerType(this VertexElementFormat elementFormat)
    {
      switch (elementFormat)
      {
        case VertexElementFormat.Single:
          return VertexPointerType.Float;
        case VertexElementFormat.Vector2:
          return VertexPointerType.Float;
        case VertexElementFormat.Vector3:
          return VertexPointerType.Float;
        case VertexElementFormat.Vector4:
          return VertexPointerType.Float;
        case VertexElementFormat.Color:
          return VertexPointerType.Short;
        case VertexElementFormat.Byte4:
          return VertexPointerType.Short;
        case VertexElementFormat.Short2:
          return VertexPointerType.Short;
        case VertexElementFormat.Short4:
          return VertexPointerType.Short;
        case VertexElementFormat.NormalizedShort2:
          return VertexPointerType.Short;
        case VertexElementFormat.NormalizedShort4:
          return VertexPointerType.Short;
        case VertexElementFormat.HalfVector2:
          return VertexPointerType.Float;
        case VertexElementFormat.HalfVector4:
          return VertexPointerType.Float;
        default:
          throw new NotImplementedException();
      }
    }

    public static VertexAttribPointerType OpenGLVertexAttribPointerType(this VertexElementFormat elementFormat)
    {
      switch (elementFormat)
      {
        case VertexElementFormat.Single:
          return VertexAttribPointerType.Float;
        case VertexElementFormat.Vector2:
          return VertexAttribPointerType.Float;
        case VertexElementFormat.Vector3:
          return VertexAttribPointerType.Float;
        case VertexElementFormat.Vector4:
          return VertexAttribPointerType.Float;
        case VertexElementFormat.Color:
          return VertexAttribPointerType.UnsignedByte;
        case VertexElementFormat.Byte4:
          return VertexAttribPointerType.UnsignedByte;
        case VertexElementFormat.Short2:
          return VertexAttribPointerType.Short;
        case VertexElementFormat.Short4:
          return VertexAttribPointerType.Short;
        case VertexElementFormat.NormalizedShort2:
          return VertexAttribPointerType.Short;
        case VertexElementFormat.NormalizedShort4:
          return VertexAttribPointerType.Short;
        case VertexElementFormat.HalfVector2:
          return VertexAttribPointerType.HalfFloat;
        case VertexElementFormat.HalfVector4:
          return VertexAttribPointerType.HalfFloat;
        default:
          throw new NotImplementedException();
      }
    }

    public static bool OpenGLVertexAttribNormalized(this VertexElement element)
    {
      if (element.VertexElementUsage == VertexElementUsage.Color)
        return true;
      switch (element.VertexElementFormat)
      {
        case VertexElementFormat.NormalizedShort2:
        case VertexElementFormat.NormalizedShort4:
          return true;
        default:
          return false;
      }
    }

    public static ColorPointerType OpenGLColorPointerType(this VertexElementFormat elementFormat)
    {
      switch (elementFormat)
      {
        case VertexElementFormat.Single:
          return ColorPointerType.Float;
        case VertexElementFormat.Vector2:
          return ColorPointerType.Float;
        case VertexElementFormat.Vector3:
          return ColorPointerType.Float;
        case VertexElementFormat.Vector4:
          return ColorPointerType.Float;
        case VertexElementFormat.Color:
          return ColorPointerType.UnsignedByte;
        case VertexElementFormat.Byte4:
          return ColorPointerType.UnsignedByte;
        case VertexElementFormat.Short2:
          return ColorPointerType.Short;
        case VertexElementFormat.Short4:
          return ColorPointerType.Short;
        case VertexElementFormat.NormalizedShort2:
          return ColorPointerType.UnsignedShort;
        case VertexElementFormat.NormalizedShort4:
          return ColorPointerType.UnsignedShort;
        default:
          throw new NotImplementedException();
      }
    }

    public static NormalPointerType OpenGLNormalPointerType(this VertexElementFormat elementFormat)
    {
      switch (elementFormat)
      {
        case VertexElementFormat.Single:
          return NormalPointerType.Float;
        case VertexElementFormat.Vector2:
          return NormalPointerType.Float;
        case VertexElementFormat.Vector3:
          return NormalPointerType.Float;
        case VertexElementFormat.Vector4:
          return NormalPointerType.Float;
        case VertexElementFormat.Color:
          return NormalPointerType.Byte;
        case VertexElementFormat.Byte4:
          return NormalPointerType.Byte;
        case VertexElementFormat.Short2:
          return NormalPointerType.Short;
        case VertexElementFormat.Short4:
          return NormalPointerType.Short;
        case VertexElementFormat.NormalizedShort2:
          return NormalPointerType.Short;
        case VertexElementFormat.NormalizedShort4:
          return NormalPointerType.Short;
        default:
          throw new NotImplementedException();
      }
    }

    public static TexCoordPointerType OpenGLTexCoordPointerType(this VertexElementFormat elementFormat)
    {
      switch (elementFormat)
      {
        case VertexElementFormat.Single:
          return TexCoordPointerType.Float;
        case VertexElementFormat.Vector2:
          return TexCoordPointerType.Float;
        case VertexElementFormat.Vector3:
          return TexCoordPointerType.Float;
        case VertexElementFormat.Vector4:
          return TexCoordPointerType.Float;
        case VertexElementFormat.Color:
          return TexCoordPointerType.Float;
        case VertexElementFormat.Byte4:
          return TexCoordPointerType.Float;
        case VertexElementFormat.Short2:
          return TexCoordPointerType.Short;
        case VertexElementFormat.Short4:
          return TexCoordPointerType.Short;
        case VertexElementFormat.NormalizedShort2:
          return TexCoordPointerType.Short;
        case VertexElementFormat.NormalizedShort4:
          return TexCoordPointerType.Short;
        default:
          throw new NotImplementedException();
      }
    }

    public static BlendEquationMode GetBlendEquationMode(this BlendFunction function)
    {
      switch (function)
      {
        case BlendFunction.Add:
          return BlendEquationMode.FuncAdd;
        case BlendFunction.Max:
          return BlendEquationMode.Max;
        case BlendFunction.Min:
          return BlendEquationMode.Min;
        case BlendFunction.ReverseSubtract:
          return BlendEquationMode.FuncReverseSubtract;
        case BlendFunction.Subtract:
          return BlendEquationMode.FuncSubtract;
        default:
          throw new NotImplementedException();
      }
    }

    public static BlendingFactorSrc GetBlendFactorSrc(this Blend blend)
    {
      switch (blend)
      {
        case Blend.Zero:
          return BlendingFactorSrc.Zero;
        case Blend.One:
          return BlendingFactorSrc.One;
        case Blend.SourceColor:
          return (BlendingFactorSrc) 768;
        case Blend.InverseSourceColor:
          return (BlendingFactorSrc) 769;
        case Blend.SourceAlpha:
          return BlendingFactorSrc.SrcAlpha;
        case Blend.InverseSourceAlpha:
          return BlendingFactorSrc.OneMinusSrcAlpha;
        case Blend.DestinationAlpha:
          return BlendingFactorSrc.DstAlpha;
        case Blend.InverseDestinationAlpha:
          return BlendingFactorSrc.OneMinusDstAlpha;
        case Blend.DestinationColor:
          return BlendingFactorSrc.DstColor;
        case Blend.InverseDestinationColor:
          return BlendingFactorSrc.OneMinusDstColor;
        case Blend.SourceAlphaSaturation:
          return BlendingFactorSrc.SrcAlphaSaturate;
        default:
          return BlendingFactorSrc.One;
      }
    }

    public static BlendingFactorDest GetBlendFactorDest(this Blend blend)
    {
      switch (blend)
      {
        case Blend.Zero:
          return BlendingFactorDest.Zero;
        case Blend.One:
          return BlendingFactorDest.One;
        case Blend.SourceColor:
          return BlendingFactorDest.SrcColor;
        case Blend.InverseSourceColor:
          return BlendingFactorDest.OneMinusSrcColor;
        case Blend.SourceAlpha:
          return BlendingFactorDest.SrcAlpha;
        case Blend.InverseSourceAlpha:
          return BlendingFactorDest.OneMinusSrcAlpha;
        case Blend.DestinationAlpha:
          return BlendingFactorDest.DstAlpha;
        case Blend.InverseDestinationAlpha:
          return BlendingFactorDest.OneMinusDstAlpha;
        default:
          return BlendingFactorDest.One;
      }
    }

    internal static void GetGLFormat(this SurfaceFormat format, out PixelInternalFormat glInternalFormat, out PixelFormat glFormat, out PixelType glType)
    {
      glInternalFormat = PixelInternalFormat.Rgba;
      glFormat = PixelFormat.Rgba;
      glType = PixelType.UnsignedByte;
      switch (format)
      {
        case SurfaceFormat.Color:
          glInternalFormat = PixelInternalFormat.Rgba;
          glFormat = PixelFormat.Rgba;
          glType = PixelType.UnsignedByte;
          break;
        case SurfaceFormat.Bgr565:
          glInternalFormat = PixelInternalFormat.Rgb;
          glFormat = PixelFormat.Rgb;
          glType = PixelType.UnsignedShort565;
          break;
        case SurfaceFormat.Bgra5551:
          glInternalFormat = PixelInternalFormat.Rgba;
          glFormat = PixelFormat.Rgba;
          glType = PixelType.UnsignedShort5551;
          break;
        case SurfaceFormat.Bgra4444:
          glInternalFormat = PixelInternalFormat.Rgba4;
          glFormat = PixelFormat.Rgba;
          glType = PixelType.UnsignedShort4444;
          break;
        case SurfaceFormat.Dxt1:
          glInternalFormat = PixelInternalFormat.CompressedRgbaS3tcDxt1Ext;
          glFormat = (PixelFormat) 34467;
          break;
        case SurfaceFormat.Dxt3:
          glInternalFormat = PixelInternalFormat.CompressedRgbaS3tcDxt3Ext;
          glFormat = (PixelFormat) 34467;
          break;
        case SurfaceFormat.Dxt5:
          glInternalFormat = PixelInternalFormat.CompressedRgbaS3tcDxt5Ext;
          glFormat = (PixelFormat) 34467;
          break;
        case SurfaceFormat.Alpha8:
          glInternalFormat = PixelInternalFormat.Luminance;
          glFormat = PixelFormat.Luminance;
          glType = PixelType.UnsignedByte;
          break;
        case SurfaceFormat.Single:
          glInternalFormat = PixelInternalFormat.R32f;
          glFormat = PixelFormat.Red;
          glType = PixelType.Float;
          break;
        default:
          throw new NotSupportedException();
      }
    }

    public static int Size(this SurfaceFormat surfaceFormat)
    {
      switch (surfaceFormat)
      {
        case SurfaceFormat.Color:
          return 4;
        case SurfaceFormat.Bgra5551:
          return 2;
        case SurfaceFormat.Bgra4444:
          return 2;
        case SurfaceFormat.Dxt3:
          return 4;
        case SurfaceFormat.NormalizedByte4:
          return 4;
        case SurfaceFormat.Alpha8:
          return 1;
        default:
          throw new NotImplementedException();
      }
    }

    public static int GetTypeSize(this VertexElementFormat elementFormat)
    {
      switch (elementFormat)
      {
        case VertexElementFormat.Single:
          return 4;
        case VertexElementFormat.Vector2:
          return 8;
        case VertexElementFormat.Vector3:
          return 12;
        case VertexElementFormat.Vector4:
          return 16;
        case VertexElementFormat.Color:
          return 4;
        case VertexElementFormat.Byte4:
          return 4;
        case VertexElementFormat.Short2:
          return 4;
        case VertexElementFormat.Short4:
          return 8;
        case VertexElementFormat.NormalizedShort2:
          return 4;
        case VertexElementFormat.NormalizedShort4:
          return 8;
        case VertexElementFormat.HalfVector2:
          return 4;
        case VertexElementFormat.HalfVector4:
          return 8;
        default:
          return 0;
      }
    }

    public static int GetBoundTexture2D()
    {
      int @params = 0;
      GL.GetInteger(GetPName.TextureBinding2D, out @params);
      return @params;
    }

    [Conditional("DEBUG")]
    public static void CheckGLError()
    {
      ErrorCode error = GL.GetError();
      if (error != ErrorCode.NoError)
        throw new MonoGameGLException("GL.GetError() returned " + ((object) error).ToString());
    }

    [Conditional("DEBUG")]
    public static void LogGLError(string location)
    {
      try
      {
      }
      catch (MonoGameGLException ex)
      {
      }
    }
  }
}
