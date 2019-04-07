// Decompiled with JetBrains decompiler
// Type: Carnivores._ObjectModel
// Assembly: CCEMapPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F598567F-94C3-4D21-8DB0-0F5517E3D0D4
// Assembly location: C:\Users\adelp\Desktop\CCEMapPainter.exe

using System.Drawing;
using System.IO;

namespace Carnivores
{
  internal class _ObjectModel
  {
    public _ObjectHeader Header = new _ObjectHeader();
    public _Face[] gFace = new _Face[1024];
    public _Vertex[] gVertex = new _Vertex[1024];
    public _Object[] sub_objects = new _Object[1024];
    public ushort[] texture_data = new ushort[102400];
    public ushort[] bitmap_model_texture = new ushort[32768];
    public int VCount;
    public int FCount;
    public int OCount;
    public int Texture_Size;
    public int TextureHeight;

    public Bitmap getMainBitmap()
    {
      this.TextureHeight = this.Texture_Size >> 9;
      Color black = Color.Black;
      Bitmap bitmap = new Bitmap(256, this.TextureHeight);
      for (int y = 0; y < this.TextureHeight; ++y)
      {
        for (int x = 0; x < 256; ++x)
        {
          ushort num = this.texture_data[y * 256 + x];
          Color color = Color.FromArgb(((int) num >> 10 & 31) * 8, ((int) num >> 5 & 31) * 8, ((int) num & 31) * 8);
          bitmap.SetPixel(x, y, color);
        }
      }
      return bitmap;
    }

    public bool SaveAsObj(string fname)
    {
      Stream stream = (Stream) new FileStream(fname, FileMode.Create);
      TextWriter textWriter = (TextWriter) new StreamWriter(stream);
      for (int index = 0; index < this.VCount; ++index)
        textWriter.WriteLine("v " + this.gVertex[index].x.ToString() + " " + this.gVertex[index].y.ToString() + " " + this.gVertex[index].z.ToString());
      for (int index = 0; index < this.FCount; ++index)
      {
        textWriter.WriteLine("vt " + this.gFace[index].tax.ToString() + " " + this.gFace[index].tay.ToString());
        textWriter.WriteLine("vt " + this.gFace[index].tbx.ToString() + " " + this.gFace[index].tby.ToString());
        textWriter.WriteLine("vt " + this.gFace[index].tcx.ToString() + " " + this.gFace[index].tcy.ToString());
      }
      for (int index = 0; index < this.FCount; ++index)
      {
        int num1 = this.gFace[index].v1 + 1;
        int num2 = index + 1;
        int num3 = this.gFace[index].v2 + 1;
        int num4 = index + 2;
        int num5 = this.gFace[index].v3 + 1;
        int num6 = index + 3;
        textWriter.WriteLine("f " + num1.ToString() + "/" + num2.ToString() + " " + num3.ToString() + "/" + num4.ToString() + " " + num5.ToString() + "/" + num6.ToString());
      }
      this.TextureHeight = this.Texture_Size >> 9;
      this.getMainBitmap().Save(fname + ".bmp");
      textWriter.Close();
      stream.Close();
      return true;
    }

    public bool SaveAs(string fname)
    {
      Stream output = (Stream) new FileStream(fname, FileMode.Create);
      BinaryWriter binaryWriter = new BinaryWriter(output);
      binaryWriter.Write(this.Header._data);
      binaryWriter.Write(this.VCount);
      binaryWriter.Write(this.FCount);
      binaryWriter.Write(this.OCount);
      binaryWriter.Write(this.Texture_Size);
      for (int index = 0; index < this.FCount; ++index)
      {
        binaryWriter.Write(this.gFace[index].v1);
        binaryWriter.Write(this.gFace[index].v2);
        binaryWriter.Write(this.gFace[index].v3);
        binaryWriter.Write(this.gFace[index].tax);
        binaryWriter.Write(this.gFace[index].tbx);
        binaryWriter.Write(this.gFace[index].tcx);
        binaryWriter.Write(this.gFace[index].tay);
        binaryWriter.Write(this.gFace[index].tby);
        binaryWriter.Write(this.gFace[index].tcy);
        binaryWriter.Write(this.gFace[index].Flags);
        binaryWriter.Write(this.gFace[index].DMask);
        binaryWriter.Write(this.gFace[index].Distant);
        binaryWriter.Write(this.gFace[index].Next);
        binaryWriter.Write(this.gFace[index].group);
        binaryWriter.Write(this.gFace[index].reserved);
      }
      for (int index = 0; index < this.VCount; ++index)
      {
        binaryWriter.Write(this.gVertex[index].x);
        binaryWriter.Write(this.gVertex[index].y);
        binaryWriter.Write(this.gVertex[index].z);
        binaryWriter.Write(this.gVertex[index].owner);
        binaryWriter.Write(this.gVertex[index].hide);
      }
      for (int index = 0; index < this.OCount; ++index)
        binaryWriter.Write(this.sub_objects[index]._data);
      for (int index = 0; index < this.Texture_Size / 2; ++index)
        binaryWriter.Write(this.texture_data[index]);
      for (int index = 0; index < 16384; ++index)
        binaryWriter.Write(this.bitmap_model_texture[index]);
      binaryWriter.Close();
      output.Close();
      return true;
    }
  }
}
