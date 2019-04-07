// Decompiled with JetBrains decompiler
// Type: Carnivores.Rsc
// Assembly: CCEMapPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F598567F-94C3-4D21-8DB0-0F5517E3D0D4
// Assembly location: C:\Users\adelp\Desktop\CCEMapPainter.exe

using System.Drawing;
using System.IO;

namespace Carnivores
{
  internal class Rsc
  {
    public int[,] FadeRGB = new int[3, 3];
    public int[,] TransRGB = new int[3, 3];
    public ushort[,] Textures = new ushort[128, 16384];
    public _ObjectModel[] Objects = new _ObjectModel[256];
    public ushort[,] SkyTextures = new ushort[3, 65536];
    public byte[] cloud_heightmap = new byte[16384];
    public _Fog[] Fogs = new _Fog[256];
    public _SoundFX[] RandomSoundData = new _SoundFX[256];
    public _TAmbient[] AmbientsData = new _TAmbient[256];
    public _Water[] Waters = new _Water[256];
    public Bitmap[] Texture_Bitmaps = new Bitmap[128];
    public Bitmap[] Object_Bitmaps_Sprite = new Bitmap[128];
    public Bitmap[] Object_Bitmaps = new Bitmap[128];
    public Bitmap[] Skies = new Bitmap[3];
    public Bitmap CloudMap = new Bitmap(128, 128);
    public int num_textures;
    public int num_objects;
    public int num_fogs;
    public int num_rsounds;
    public int num_ambsounds;
    public int num_water;

    public bool getBitmapForSky(int sky_index)
    {
      if (sky_index < 0 || sky_index > 2)
        return false;
      if (this.Skies[sky_index] != null)
        return true;
      Color black = Color.Black;
      this.Skies[sky_index] = new Bitmap(256, 256);
      for (int y = 0; y < 256; ++y)
      {
        for (int x = 0; x < 256; ++x)
        {
          int skyTexture = (int) this.SkyTextures[sky_index, y * 256 + x];
          Color color = Color.FromArgb((skyTexture >> 10 & 31) * 8, (skyTexture >> 5 & 31) * 8, (skyTexture & 31) * 8);
          this.Skies[sky_index].SetPixel(x, y, color);
        }
      }
      return true;
    }

    public bool LoadObjects()
    {
      for (int o_index = 0; o_index < this.num_objects; ++o_index)
        this.Object_Bitmaps[o_index] = this.getBitmapForObject(o_index);
      return true;
    }

    public Bitmap getBitmapForObject(int o_index)
    {
      if (o_index < 0 || o_index > this.num_objects)
        return (Bitmap) null;
      Color black = Color.Black;
      Bitmap bitmap = new Bitmap(128, 128);
      for (int y = 0; y < 128; ++y)
      {
        for (int x = 0; x < 128; ++x)
        {
          ushort num = this.Objects[o_index].bitmap_model_texture[y * 128 + x];
          Color color = Color.FromArgb(((int) num >> 10 & 31) * 8, ((int) num >> 5 & 31) * 8, ((int) num & 31) * 8);
          bitmap.SetPixel(x, y, color);
        }
      }
      return bitmap;
    }

    public bool LoadTextures()
    {
      for (int tex_index = 0; tex_index < this.num_textures; ++tex_index)
        this.Texture_Bitmaps[tex_index] = this.getBitmapForTexture(tex_index);
      return true;
    }

    public Bitmap getBitmapForTexture(int tex_index)
    {
      if (tex_index < 0 || tex_index > this.num_textures)
        return (Bitmap) null;
      Color black = Color.Black;
      Bitmap bitmap = new Bitmap(128, 128);
      for (int y = 0; y < 128; ++y)
      {
        for (int x = 0; x < 128; ++x)
        {
          ushort texture = this.Textures[tex_index, y * 128 + x];
          Color color = Color.FromArgb(((int) texture >> 10 & 31) * 8, ((int) texture >> 5 & 31) * 8, ((int) texture & 31) * 8);
          bitmap.SetPixel(x, y, color);
        }
      }
      return bitmap;
    }

    public bool Load(string fname)
    {
      FileStream fileStream = File.OpenRead(fname);
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      this.num_textures = binaryReader.ReadInt32();
      this.num_objects = binaryReader.ReadInt32();
      for (int index = 0; index < 3; ++index)
      {
        this.FadeRGB[index, 0] = binaryReader.ReadInt32();
        this.FadeRGB[index, 1] = binaryReader.ReadInt32();
        this.FadeRGB[index, 2] = binaryReader.ReadInt32();
      }
      for (int index = 0; index < 3; ++index)
      {
        this.TransRGB[index, 0] = binaryReader.ReadInt32();
        this.TransRGB[index, 1] = binaryReader.ReadInt32();
        this.TransRGB[index, 2] = binaryReader.ReadInt32();
      }
      for (int index1 = 0; index1 < this.num_textures; ++index1)
      {
        for (int index2 = 0; index2 < 16384; ++index2)
          this.Textures[index1, index2] = binaryReader.ReadUInt16();
      }
      for (int index1 = 0; index1 < this.num_objects; ++index1)
      {
        this.Objects[index1] = new _ObjectModel();
        this.Objects[index1].Header._data = binaryReader.ReadBytes(64);
        this.Objects[index1].VCount = binaryReader.ReadInt32();
        this.Objects[index1].FCount = binaryReader.ReadInt32();
        this.Objects[index1].OCount = binaryReader.ReadInt32();
        this.Objects[index1].Texture_Size = binaryReader.ReadInt32();
        for (int index2 = 0; index2 < this.Objects[index1].FCount; ++index2)
        {
          this.Objects[index1].gFace[index2] = new _Face();
          this.Objects[index1].gFace[index2].v1 = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].v2 = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].v3 = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].tax = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].tbx = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].tcx = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].tay = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].tby = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].tcy = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].Flags = binaryReader.ReadUInt16();
          this.Objects[index1].gFace[index2].DMask = binaryReader.ReadUInt16();
          this.Objects[index1].gFace[index2].Distant = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].Next = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].group = binaryReader.ReadInt32();
          this.Objects[index1].gFace[index2].reserved = binaryReader.ReadChars(12);
        }
        for (int index2 = 0; index2 < this.Objects[index1].VCount; ++index2)
        {
          this.Objects[index1].gVertex[index2] = new _Vertex();
          this.Objects[index1].gVertex[index2].x = binaryReader.ReadSingle();
          this.Objects[index1].gVertex[index2].y = binaryReader.ReadSingle();
          this.Objects[index1].gVertex[index2].z = binaryReader.ReadSingle();
          this.Objects[index1].gVertex[index2].owner = binaryReader.ReadInt16();
          this.Objects[index1].gVertex[index2].hide = binaryReader.ReadInt16();
        }
        for (int index2 = 0; index2 < this.Objects[index1].OCount; ++index2)
        {
          this.Objects[index1].sub_objects[index2] = new _Object();
          this.Objects[index1].sub_objects[index2]._data = binaryReader.ReadBytes(48);
        }
        for (int index2 = 0; index2 < this.Objects[index1].Texture_Size / 2; ++index2)
          this.Objects[index1].texture_data[index2] = binaryReader.ReadUInt16();
        for (int index2 = 0; index2 < 16384; ++index2)
          this.Objects[index1].bitmap_model_texture[index2] = binaryReader.ReadUInt16();
      }
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 65536; ++index2)
          this.SkyTextures[index1, index2] = binaryReader.ReadUInt16();
      }
      this.cloud_heightmap = binaryReader.ReadBytes(16384);
      this.num_fogs = binaryReader.ReadInt32();
      for (int index = 1; index <= this.num_fogs; ++index)
      {
        this.Fogs[index] = new _Fog();
        this.Fogs[index].RGB = binaryReader.ReadInt32();
        this.Fogs[index].y = binaryReader.ReadSingle();
        this.Fogs[index].isMortal = binaryReader.ReadInt32();
        this.Fogs[index].opacity = binaryReader.ReadSingle();
        this.Fogs[index].FLimit = binaryReader.ReadSingle();
      }
      this.num_rsounds = binaryReader.ReadInt32();
      for (int index1 = 0; index1 < this.num_rsounds; ++index1)
      {
        this.RandomSoundData[index1] = new _SoundFX();
        this.RandomSoundData[index1].length = binaryReader.ReadInt32();
        this.RandomSoundData[index1].sndData = new ushort[this.RandomSoundData[index1].length];
        for (int index2 = 0; index2 < this.RandomSoundData[index1].length / 2; ++index2)
          this.RandomSoundData[index1].sndData[index2] = binaryReader.ReadUInt16();
      }
      this.num_ambsounds = binaryReader.ReadInt32();
      for (int index1 = 0; index1 < this.num_ambsounds; ++index1)
      {
        this.AmbientsData[index1] = new _TAmbient();
        this.AmbientsData[index1].sfx = new _SoundFX();
        this.AmbientsData[index1].sfx.length = binaryReader.ReadInt32();
        this.AmbientsData[index1].sfx.sndData = new ushort[this.AmbientsData[index1].sfx.length];
        for (int index2 = 0; index2 < this.AmbientsData[index1].sfx.length / 2; ++index2)
          this.AmbientsData[index1].sfx.sndData[index2] = binaryReader.ReadUInt16();
        for (int index2 = 0; index2 < 16; ++index2)
        {
          this.AmbientsData[index1].rdata[index2] = new _TRD();
          this.AmbientsData[index1].rdata[index2].RNumber = binaryReader.ReadInt32();
          this.AmbientsData[index1].rdata[index2].RVolume = binaryReader.ReadInt32();
          this.AmbientsData[index1].rdata[index2].RFreq = binaryReader.ReadInt32();
          this.AmbientsData[index1].rdata[index2].REnvir = binaryReader.ReadUInt16();
          this.AmbientsData[index1].rdata[index2].Flags = binaryReader.ReadUInt16();
        }
        this.AmbientsData[index1].RSFXCount = binaryReader.ReadInt32();
        this.AmbientsData[index1].AVolume = binaryReader.ReadInt32();
      }
      this.num_water = binaryReader.ReadInt32();
      for (int index = 0; index < this.num_water; ++index)
      {
        this.Waters[index] = new _Water();
        this.Waters[index].texture_index = binaryReader.ReadInt32();
        this.Waters[index].water_level = binaryReader.ReadInt32();
        this.Waters[index].transp = binaryReader.ReadSingle();
        this.Waters[index].RGB = binaryReader.ReadInt32();
      }
      binaryReader.Close();
      fileStream.Close();
      return true;
    }
  }
}
