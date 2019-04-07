// Decompiled with JetBrains decompiler
// Type: Carnivores.Car
// Assembly: CCEMapPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F598567F-94C3-4D21-8DB0-0F5517E3D0D4
// Assembly location: C:\Users\adelp\Desktop\CCEMapPainter.exe

using System.Drawing;
using System.IO;

namespace Carnivores
{
  internal class Car
  {
    public char[] name = new char[32];
    public int[] AniFXTable = new int[64];
    public _Face[] gFace = new _Face[1024];
    public _Vertex[] gVertex = new _Vertex[1024];
    public byte[] texture_data_bytes = new byte[250000];
    public _Animation[] gAnimations = new _Animation[64];
    public _SoundFX[] gSounds = new _SoundFX[64];
    public int animation_count;
    private int sound_count;
    public int VCount;
    public int FCount;
    private int TextureSize;

    public Bitmap getSkin()
    {
      return (Bitmap) null;
    }

    public bool Load(string fname)
    {
      FileStream fileStream = File.OpenRead(fname);
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      this.name = binaryReader.ReadChars(32);
      this.animation_count = binaryReader.ReadInt32();
      this.sound_count = binaryReader.ReadInt32();
      this.VCount = binaryReader.ReadInt32();
      this.FCount = binaryReader.ReadInt32();
      this.TextureSize = binaryReader.ReadInt32();
      for (int index = 0; index < this.FCount; ++index)
      {
        this.gFace[index] = new _Face();
        this.gFace[index].v1 = binaryReader.ReadInt32();
        this.gFace[index].v2 = binaryReader.ReadInt32();
        this.gFace[index].v3 = binaryReader.ReadInt32();
        this.gFace[index].tax = binaryReader.ReadInt32();
        this.gFace[index].tbx = binaryReader.ReadInt32();
        this.gFace[index].tcx = binaryReader.ReadInt32();
        this.gFace[index].tay = binaryReader.ReadInt32();
        this.gFace[index].tby = binaryReader.ReadInt32();
        this.gFace[index].tcy = binaryReader.ReadInt32();
        this.gFace[index].Flags = binaryReader.ReadUInt16();
        this.gFace[index].DMask = binaryReader.ReadUInt16();
        this.gFace[index].Distant = binaryReader.ReadInt32();
        this.gFace[index].Next = binaryReader.ReadInt32();
        this.gFace[index].group = binaryReader.ReadInt32();
        this.gFace[index].reserved = binaryReader.ReadChars(12);
      }
      for (int index = 0; index < this.VCount; ++index)
      {
        this.gVertex[index] = new _Vertex();
        this.gVertex[index].x = binaryReader.ReadSingle();
        this.gVertex[index].y = binaryReader.ReadSingle();
        this.gVertex[index].z = binaryReader.ReadSingle();
        this.gVertex[index].owner = binaryReader.ReadInt16();
        this.gVertex[index].hide = binaryReader.ReadInt16();
      }
      this.texture_data_bytes = binaryReader.ReadBytes(this.TextureSize);
      for (int index1 = 0; index1 < this.animation_count; ++index1)
      {
        this.gAnimations[index1] = new _Animation();
        this.gAnimations[index1].aniName = binaryReader.ReadChars(32);
        this.gAnimations[index1].aniKPS = binaryReader.ReadInt32();
        this.gAnimations[index1].FramesCount = binaryReader.ReadInt32();
        this.gAnimations[index1].AniTime = this.gAnimations[index1].FramesCount * 1000 / this.gAnimations[index1].aniKPS;
        this.gAnimations[index1].aniData = new short[393216];
        int index2 = 0;
        for (int index3 = 0; index3 < this.VCount * this.gAnimations[index1].FramesCount; ++index3)
        {
          this.gAnimations[index1].aniData[index2] = binaryReader.ReadInt16();
          this.gAnimations[index1].aniData[index2 + 1] = binaryReader.ReadInt16();
          this.gAnimations[index1].aniData[index2 + 2] = binaryReader.ReadInt16();
          index2 += 3;
        }
      }
      for (int index1 = 0; index1 < this.sound_count; ++index1)
      {
        this.gSounds[index1] = new _SoundFX();
        this.gSounds[index1].sndName = binaryReader.ReadChars(32);
        this.gSounds[index1].length = binaryReader.ReadInt32();
        this.gSounds[index1].sndData = new ushort[this.gSounds[index1].length];
        for (int index2 = 0; index2 < this.gSounds[index1].length / 2; ++index2)
          this.gSounds[index1].sndData[index2] = binaryReader.ReadUInt16();
      }
      for (int index = 0; index < 64; ++index)
      {
        this.AniFXTable[index] = 0;
        this.AniFXTable[index] = binaryReader.ReadInt32();
      }
      binaryReader.Close();
      fileStream.Close();
      return true;
    }
  }
}
