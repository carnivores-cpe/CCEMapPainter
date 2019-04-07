// Decompiled with JetBrains decompiler
// Type: Carnivores.Map
// Assembly: CCEMapPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F598567F-94C3-4D21-8DB0-0F5517E3D0D4
// Assembly location: C:\Users\adelp\Desktop\CCEMapPainter.exe

using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Carnivores
{
  internal class Map
  {
    public byte[,] Heightmap = new byte[1024, 1024];
    public ushort[,] Texturemap1 = new ushort[1024, 1024];
    public ushort[,] Texturemap2 = new ushort[1024, 1024];
    public byte[,] Objectmap = new byte[1024, 1024];
    public ushort[,] Flagmap = new ushort[1024, 1024];
    public byte[,] Lightmap_a = new byte[1024, 1024];
    public byte[,] Lightmap_b = new byte[1024, 1024];
    public byte[,] Lightmap_c = new byte[1024, 1024];
    public byte[,] Watermap = new byte[1024, 1024];
    public byte[,] Heightmap_objects = new byte[1024, 1024];
    public byte[,] Fogmap = new byte[512, 512];
    public byte[,] Ambmap = new byte[512, 512];
    public Bitmap heightmap_bmp;
    public Bitmap texturemap1_bmp;

    public bool UpdateTexturemap1Bmp()
    {
      Bitmap bitmap = new Bitmap(1024, 1024);
      Color.FromArgb(0, 0, 0);
      for (int x = 0; x < bitmap.Height; ++x)
      {
        for (int y = 0; y < bitmap.Width; ++y)
        {
          Color color = Color.FromArgb(0, 0, 0);
          bitmap.SetPixel(x, y, color);
        }
      }
      this.texturemap1_bmp = bitmap;
      return true;
    }

    public bool UpdateHeightbmp()
    {
      Bitmap bitmap = new Bitmap(1024, 1024);
      Color.FromArgb(0, 0, 0);
      for (int x = 0; x < bitmap.Height; ++x)
      {
        for (int y = 0; y < bitmap.Width; ++y)
        {
          Color color = Color.FromArgb((int) this.Heightmap[y, x], (int) this.Heightmap[y, x], (int) this.Heightmap[y, x]);
          bitmap.SetPixel(x, y, color);
        }
      }
      this.heightmap_bmp = bitmap;
      return true;
    }

    public bool ExportHeightmap(string fname)
    {
      Stream output = (Stream) new FileStream(fname, FileMode.Create);
      BinaryWriter binaryWriter = new BinaryWriter(output);
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Heightmap[index1, index2]);
      }
      binaryWriter.Close();
      output.Close();
      return true;
    }

    public bool ReplaceHeightmapFromRAW(string fname)
    {
      FileStream fileStream = File.OpenRead(fname);
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Heightmap[index1, index2] = binaryReader.ReadByte();
      }
      binaryReader.Close();
      fileStream.Close();
      this.UpdateHeightbmp();
      return true;
    }

    public bool ReplaceHeightmapFromC1(string fname)
    {
      FileStream fileStream = File.OpenRead(fname);
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      binaryReader.ReadBytes(1572864);
      byte num1 = byte.Parse(binaryReader.PeekChar().ToString());
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
        {
          int num2 = index1 <= (int) byte.MaxValue || index1 >= 768 || index2 <= (int) byte.MaxValue ? 1 : (index2 >= 768 ? 1 : 0);
          this.Heightmap[index1, index2] = num2 != 0 ? num1 : binaryReader.ReadByte();
        }
      }
      binaryReader.Close();
      fileStream.Close();
      this.UpdateHeightbmp();
      return true;
    }

    public bool ReplaceHeightmapFromBMP(string fname)
    {
      Bitmap bitmap = new Bitmap(Image.FromFile(fname));
      if (bitmap == null)
        return false;
      if (bitmap.Width != 1024 || bitmap.Height != 1024)
      {
        int num = (int) MessageBox.Show("Invalid Bitmap: Height and width are not 1024 x 1024. Please resize");
        return false;
      }
      for (int y = 0; y < 1024; ++y)
      {
        for (int x = 0; x < 1024; ++x)
          this.Heightmap[y, x] = bitmap.GetPixel(x, y).R;
      }
      this.UpdateHeightbmp();
      return true;
    }

    public bool ReplaceHeightmapFromHMP(string fname)
    {
      FileStream fileStream = File.OpenRead(fname);
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      binaryReader.ReadBytes(100);
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Heightmap[index1, index2] = binaryReader.ReadByte();
      }
      binaryReader.Close();
      fileStream.Close();
      this.UpdateHeightbmp();
      return true;
    }

    public bool SaveAs(string fname)
    {
      Stream output = (Stream) new FileStream(fname, FileMode.Create);
      BinaryWriter binaryWriter = new BinaryWriter(output);
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Heightmap[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Texturemap1[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Texturemap2[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Objectmap[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Flagmap[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Lightmap_a[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Lightmap_b[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Lightmap_c[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Watermap[index1, index2]);
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          binaryWriter.Write(this.Heightmap_objects[index1, index2]);
      }
      for (int index1 = 0; index1 < 512; ++index1)
      {
        for (int index2 = 0; index2 < 512; ++index2)
          binaryWriter.Write(this.Fogmap[index1, index2]);
      }
      for (int index1 = 0; index1 < 512; ++index1)
      {
        for (int index2 = 0; index2 < 512; ++index2)
          binaryWriter.Write(this.Ambmap[index1, index2]);
      }
      binaryWriter.Close();
      output.Close();
      return true;
    }

    public bool Load(string fname)
    {
      FileStream fileStream = File.OpenRead(fname);
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Heightmap[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Texturemap1[index1, index2] = binaryReader.ReadUInt16();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Texturemap2[index1, index2] = binaryReader.ReadUInt16();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Objectmap[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Flagmap[index1, index2] = binaryReader.ReadUInt16();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Lightmap_a[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Lightmap_b[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Lightmap_c[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Watermap[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 1024; ++index1)
      {
        for (int index2 = 0; index2 < 1024; ++index2)
          this.Heightmap_objects[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 512; ++index1)
      {
        for (int index2 = 0; index2 < 512; ++index2)
          this.Fogmap[index1, index2] = binaryReader.ReadByte();
      }
      for (int index1 = 0; index1 < 512; ++index1)
      {
        for (int index2 = 0; index2 < 512; ++index2)
          this.Ambmap[index1, index2] = binaryReader.ReadByte();
      }
      binaryReader.Close();
      fileStream.Close();
      return true;
    }
  }
}
