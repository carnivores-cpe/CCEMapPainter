// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Program
// Assembly: CCEMapPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F598567F-94C3-4D21-8DB0-0F5517E3D0D4
// Assembly location: C:\Users\adelp\Desktop\CCEMapPainter.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Constants constants = new Constants();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Form1 form1 = new Form1();
      form1.Show();
      while (form1.Created)
      {
        Application.DoEvents();
        form1.UpdateForm();
      }
    }
  }
}
