// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form1
// Assembly: CCEMapPainter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F598567F-94C3-4D21-8DB0-0F5517E3D0D4
// Assembly location: C:\Users\adelp\Desktop\CCEMapPainter.exe

using Carnivores;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Constants appConst = new Constants();
    private Panel panelInfo;
    private OpenFileDialog openc2MapDialog;
    private OpenFileDialog openHeightRawDialog;
    private SaveFileDialog saveMapDialog;
    private Label mapLoadedTxt;
    private TabControl tabs;
    private TabPage tabHeightmap;
    private TabPage tabTextures;
    private TabPage tabObjects;
    private Button heightExportBttn;
    private Button heightImportBttn;
    private TabPage tabMDetail;
    private Button saveCIAMapBttn;
    private Button loadCIAMapBttn;
    private GroupBox groupBoxMDetailsA;
    private PictureBox vid_panel;
    private SaveFileDialog exportHeightRaw;
    private BackgroundWorker backgroundLoadC2Map;
    private ProgressBar progressBarMapLoad;
    private Button heightImportHmpBttn;
    private OpenFileDialog openHeightHMPDialog;
    private Button texmapGenerate;
    private GroupBox groupBoxRsc;
    private Button loadRscBttn;
    private OpenFileDialog openC2RSC;
    private PictureBox pictureBoxTexPre;
    private Label labelLoadRSC;
    private BackgroundWorker backgroundWorkerLoadRSC;
    private ListBox listTextures;
    private Panel panel1;
    private CheckBox checkBoxViewMini;
    private Button textureExportBttn;
    private Button textureExportAllBttn;
    private Button heightmapExportBMPBttn;
    private SaveFileDialog exportHeightBMPDialog;
    private Button heightImportBMPBttn;
    private OpenFileDialog openHeightBMPDialog;
    private Button heightImportC1Bttn;
    private OpenFileDialog openHeightC1Dialog;
    private SaveFileDialog exportTextureDialog;
    private FolderBrowserDialog exportAllTexturesDialog;
    private PictureBox pictureBoxObPre;
    private ListBox listObjects;
    private Button objectExportBttn;
    private TabControl mapTabs;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private PictureBox rsc_panel;
    private SaveFileDialog savec2ObjectDialog;
    private TabPage tabSky;
    private TabPage tabFogs;
    private TabPage tabSounds;
    private TabPage tabWater;
    private Button buttonSkiesLoadBitBMP;
    private ListBox comboBoxSkies;
    private CheckBox checkBoxFogMortal;
    private ListBox listBoxFogs;
    private PictureBox pictureBoxFogPre;
    private Label labelFogHeight;
    private TrackBar trackBarFogHeight;
    private TrackBar trackBarFogYLimit;
    private Label labelFogYLimit;
    private TrackBar trackBarFogTrans;
    private Label labelFogTrans;
    private Button buttonFogMakePreview;
    private Button buttonGenTextureBlend;
    private Button buttonObjExportObj;
    private SaveFileDialog saveCObjObjectDialog;
    private PictureBox pictureBoxWaterPreview;
    private Label labelWaterTexIndex;
    private ComboBox comboBoxWaterTextureIndex;
    private ListBox listBoxWaters;
    private Label labelWaterHeight;
    private TrackBar trackBarWaterHeight;
    private Label labelWaterTrans;
    private TrackBar trackBarWaterTransp;
    private Map LoadedMap;
    private Rsc LoadedRsc;
    private Bitmap MapPreview;
    private Bitmap FogPreview;
    private int ActiveTab;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelInfo = new Panel();
      this.labelLoadRSC = new Label();
      this.mapLoadedTxt = new Label();
      this.openc2MapDialog = new OpenFileDialog();
      this.openHeightRawDialog = new OpenFileDialog();
      this.saveMapDialog = new SaveFileDialog();
      this.tabs = new TabControl();
      this.tabMDetail = new TabPage();
      this.groupBoxRsc = new GroupBox();
      this.loadRscBttn = new Button();
      this.groupBoxMDetailsA = new GroupBox();
      this.saveCIAMapBttn = new Button();
      this.loadCIAMapBttn = new Button();
      this.tabHeightmap = new TabPage();
      this.heightImportC1Bttn = new Button();
      this.heightImportBMPBttn = new Button();
      this.heightmapExportBMPBttn = new Button();
      this.heightImportHmpBttn = new Button();
      this.heightExportBttn = new Button();
      this.heightImportBttn = new Button();
      this.tabTextures = new TabPage();
      this.buttonGenTextureBlend = new Button();
      this.textureExportAllBttn = new Button();
      this.textureExportBttn = new Button();
      this.listTextures = new ListBox();
      this.pictureBoxTexPre = new PictureBox();
      this.texmapGenerate = new Button();
      this.tabObjects = new TabPage();
      this.buttonObjExportObj = new Button();
      this.objectExportBttn = new Button();
      this.pictureBoxObPre = new PictureBox();
      this.listObjects = new ListBox();
      this.tabSky = new TabPage();
      this.comboBoxSkies = new ListBox();
      this.buttonSkiesLoadBitBMP = new Button();
      this.tabFogs = new TabPage();
      this.buttonFogMakePreview = new Button();
      this.labelFogTrans = new Label();
      this.trackBarFogTrans = new TrackBar();
      this.labelFogYLimit = new Label();
      this.trackBarFogYLimit = new TrackBar();
      this.labelFogHeight = new Label();
      this.trackBarFogHeight = new TrackBar();
      this.pictureBoxFogPre = new PictureBox();
      this.listBoxFogs = new ListBox();
      this.checkBoxFogMortal = new CheckBox();
      this.tabSounds = new TabPage();
      this.tabWater = new TabPage();
      this.vid_panel = new PictureBox();
      this.exportHeightRaw = new SaveFileDialog();
      this.backgroundLoadC2Map = new BackgroundWorker();
      this.progressBarMapLoad = new ProgressBar();
      this.openHeightHMPDialog = new OpenFileDialog();
      this.openC2RSC = new OpenFileDialog();
      this.backgroundWorkerLoadRSC = new BackgroundWorker();
      this.panel1 = new Panel();
      this.mapTabs = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.rsc_panel = new PictureBox();
      this.checkBoxViewMini = new CheckBox();
      this.exportHeightBMPDialog = new SaveFileDialog();
      this.openHeightBMPDialog = new OpenFileDialog();
      this.openHeightC1Dialog = new OpenFileDialog();
      this.exportTextureDialog = new SaveFileDialog();
      this.exportAllTexturesDialog = new FolderBrowserDialog();
      this.savec2ObjectDialog = new SaveFileDialog();
      this.saveCObjObjectDialog = new SaveFileDialog();
      this.pictureBoxWaterPreview = new PictureBox();
      this.labelWaterTexIndex = new Label();
      this.comboBoxWaterTextureIndex = new ComboBox();
      this.listBoxWaters = new ListBox();
      this.labelWaterHeight = new Label();
      this.trackBarWaterHeight = new TrackBar();
      this.labelWaterTrans = new Label();
      this.trackBarWaterTransp = new TrackBar();
      this.panelInfo.SuspendLayout();
      this.tabs.SuspendLayout();
      this.tabMDetail.SuspendLayout();
      this.groupBoxRsc.SuspendLayout();
      this.groupBoxMDetailsA.SuspendLayout();
      this.tabHeightmap.SuspendLayout();
      this.tabTextures.SuspendLayout();
      ((ISupportInitialize) this.pictureBoxTexPre).BeginInit();
      this.tabObjects.SuspendLayout();
      ((ISupportInitialize) this.pictureBoxObPre).BeginInit();
      this.tabSky.SuspendLayout();
      this.tabFogs.SuspendLayout();
      this.trackBarFogTrans.BeginInit();
      this.trackBarFogYLimit.BeginInit();
      this.trackBarFogHeight.BeginInit();
      ((ISupportInitialize) this.pictureBoxFogPre).BeginInit();
      this.tabWater.SuspendLayout();
      ((ISupportInitialize) this.vid_panel).BeginInit();
      this.panel1.SuspendLayout();
      this.mapTabs.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((ISupportInitialize) this.rsc_panel).BeginInit();
      ((ISupportInitialize) this.pictureBoxWaterPreview).BeginInit();
      this.trackBarWaterHeight.BeginInit();
      this.trackBarWaterTransp.BeginInit();
      this.SuspendLayout();
      this.panelInfo.AutoSize = true;
      this.panelInfo.BackColor = Color.FromArgb(34, 47, 61);
      this.panelInfo.Controls.Add((Control) this.labelLoadRSC);
      this.panelInfo.Controls.Add((Control) this.mapLoadedTxt);
      this.panelInfo.Location = new Point(615, 15);
      this.panelInfo.Name = "panelInfo";
      this.panelInfo.Size = new Size(256, 48);
      this.panelInfo.TabIndex = 3;
      this.labelLoadRSC.AutoSize = true;
      this.labelLoadRSC.ForeColor = SystemColors.ActiveCaptionText;
      this.labelLoadRSC.Location = new Point(86, 23);
      this.labelLoadRSC.Name = "labelLoadRSC";
      this.labelLoadRSC.Size = new Size(111, 13);
      this.labelLoadRSC.TabIndex = 2;
      this.labelLoadRSC.Text = "Please load resources";
      this.mapLoadedTxt.AutoSize = true;
      this.mapLoadedTxt.ForeColor = Color.FromArgb(137, 175, 197);
      this.mapLoadedTxt.Location = new Point(86, 10);
      this.mapLoadedTxt.Name = "mapLoadedTxt";
      this.mapLoadedTxt.Size = new Size(94, 13);
      this.mapLoadedTxt.TabIndex = 1;
      this.mapLoadedTxt.Text = "Please load a map";
      this.mapLoadedTxt.TextAlign = ContentAlignment.TopCenter;
      this.openc2MapDialog.DefaultExt = "map";
      this.openc2MapDialog.Filter = "C2 Map|*.map";
      this.openc2MapDialog.FileOk += new CancelEventHandler(this.openc2MapDialog_FileOk);
      this.openHeightRawDialog.DefaultExt = "raw";
      this.openHeightRawDialog.Filter = "RAW files|*.raw";
      this.openHeightRawDialog.FileOk += new CancelEventHandler(this.openHeightRawDialog_FileOk);
      this.saveMapDialog.DefaultExt = "map";
      this.saveMapDialog.Filter = "C2 Map|*.map";
      this.saveMapDialog.FileOk += new CancelEventHandler(this.saveMapDialog_FileOk);
      this.tabs.Controls.Add((Control) this.tabMDetail);
      this.tabs.Controls.Add((Control) this.tabHeightmap);
      this.tabs.Controls.Add((Control) this.tabTextures);
      this.tabs.Controls.Add((Control) this.tabObjects);
      this.tabs.Controls.Add((Control) this.tabSky);
      this.tabs.Controls.Add((Control) this.tabFogs);
      this.tabs.Controls.Add((Control) this.tabSounds);
      this.tabs.Controls.Add((Control) this.tabWater);
      this.tabs.ImeMode = ImeMode.NoControl;
      this.tabs.Location = new Point(615, 69);
      this.tabs.Multiline = true;
      this.tabs.Name = "tabs";
      this.tabs.SelectedIndex = 0;
      this.tabs.Size = new Size(252, 586);
      this.tabs.SizeMode = TabSizeMode.FillToRight;
      this.tabs.TabIndex = 7;
      this.tabMDetail.BackColor = Color.Transparent;
      this.tabMDetail.Controls.Add((Control) this.groupBoxRsc);
      this.tabMDetail.Controls.Add((Control) this.groupBoxMDetailsA);
      this.tabMDetail.Location = new Point(4, 40);
      this.tabMDetail.Name = "tabMDetail";
      this.tabMDetail.Padding = new Padding(3);
      this.tabMDetail.Size = new Size(244, 542);
      this.tabMDetail.TabIndex = 3;
      this.tabMDetail.Text = "Map Details";
      this.groupBoxRsc.Controls.Add((Control) this.loadRscBttn);
      this.groupBoxRsc.Location = new Point(3, 114);
      this.groupBoxRsc.Name = "groupBoxRsc";
      this.groupBoxRsc.Size = new Size(232, 86);
      this.groupBoxRsc.TabIndex = 3;
      this.groupBoxRsc.TabStop = false;
      this.groupBoxRsc.Text = "Resources";
      this.loadRscBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.loadRscBttn.Location = new Point(53, 19);
      this.loadRscBttn.Name = "loadRscBttn";
      this.loadRscBttn.Size = new Size(147, 23);
      this.loadRscBttn.TabIndex = 0;
      this.loadRscBttn.Text = "Load C2/IA RSC...";
      this.loadRscBttn.UseVisualStyleBackColor = true;
      this.loadRscBttn.Click += new EventHandler(this.loadRscBttn_Click);
      this.groupBoxMDetailsA.Controls.Add((Control) this.saveCIAMapBttn);
      this.groupBoxMDetailsA.Controls.Add((Control) this.loadCIAMapBttn);
      this.groupBoxMDetailsA.Location = new Point(6, 6);
      this.groupBoxMDetailsA.Name = "groupBoxMDetailsA";
      this.groupBoxMDetailsA.Size = new Size(232, 102);
      this.groupBoxMDetailsA.TabIndex = 2;
      this.groupBoxMDetailsA.TabStop = false;
      this.groupBoxMDetailsA.Text = "Map";
      this.saveCIAMapBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.saveCIAMapBttn.Location = new Point(50, 48);
      this.saveCIAMapBttn.Name = "saveCIAMapBttn";
      this.saveCIAMapBttn.Size = new Size(147, 23);
      this.saveCIAMapBttn.TabIndex = 1;
      this.saveCIAMapBttn.Text = "Save as C2 Map...";
      this.saveCIAMapBttn.UseVisualStyleBackColor = true;
      this.saveCIAMapBttn.Click += new EventHandler(this.saveCIAMapBttn_Click);
      this.loadCIAMapBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.loadCIAMapBttn.Location = new Point(50, 19);
      this.loadCIAMapBttn.Name = "loadCIAMapBttn";
      this.loadCIAMapBttn.Size = new Size(147, 23);
      this.loadCIAMapBttn.TabIndex = 0;
      this.loadCIAMapBttn.Text = "Load C2/IA Map...";
      this.loadCIAMapBttn.UseVisualStyleBackColor = true;
      this.loadCIAMapBttn.Click += new EventHandler(this.loadCIAMapBttn_Click);
      this.tabHeightmap.BackColor = Color.Transparent;
      this.tabHeightmap.Controls.Add((Control) this.heightImportC1Bttn);
      this.tabHeightmap.Controls.Add((Control) this.heightImportBMPBttn);
      this.tabHeightmap.Controls.Add((Control) this.heightmapExportBMPBttn);
      this.tabHeightmap.Controls.Add((Control) this.heightImportHmpBttn);
      this.tabHeightmap.Controls.Add((Control) this.heightExportBttn);
      this.tabHeightmap.Controls.Add((Control) this.heightImportBttn);
      this.tabHeightmap.Location = new Point(4, 40);
      this.tabHeightmap.Name = "tabHeightmap";
      this.tabHeightmap.Padding = new Padding(3);
      this.tabHeightmap.Size = new Size(244, 542);
      this.tabHeightmap.TabIndex = 0;
      this.tabHeightmap.Text = "Heightmap";
      this.heightImportC1Bttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.heightImportC1Bttn.Location = new Point(7, 95);
      this.heightImportC1Bttn.Name = "heightImportC1Bttn";
      this.heightImportC1Bttn.Size = new Size(75, 23);
      this.heightImportC1Bttn.TabIndex = 5;
      this.heightImportC1Bttn.Text = "Import C1";
      this.heightImportC1Bttn.UseVisualStyleBackColor = true;
      this.heightImportC1Bttn.Click += new EventHandler(this.heightImportC1Bttn_Click);
      this.heightImportBMPBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.heightImportBMPBttn.Location = new Point(7, 65);
      this.heightImportBMPBttn.Name = "heightImportBMPBttn";
      this.heightImportBMPBttn.Size = new Size(75, 23);
      this.heightImportBMPBttn.TabIndex = 4;
      this.heightImportBMPBttn.Text = "Import BMP";
      this.heightImportBMPBttn.UseVisualStyleBackColor = true;
      this.heightImportBMPBttn.Click += new EventHandler(this.heightImportBMPBttn_Click);
      this.heightmapExportBMPBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.heightmapExportBMPBttn.Location = new Point(163, 65);
      this.heightmapExportBMPBttn.Name = "heightmapExportBMPBttn";
      this.heightmapExportBMPBttn.Size = new Size(75, 23);
      this.heightmapExportBMPBttn.TabIndex = 3;
      this.heightmapExportBMPBttn.Text = "Export BMP";
      this.heightmapExportBMPBttn.UseVisualStyleBackColor = true;
      this.heightmapExportBMPBttn.Click += new EventHandler(this.heightmapExportBMPBttn_Click);
      this.heightImportHmpBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.heightImportHmpBttn.Location = new Point(6, 35);
      this.heightImportHmpBttn.Name = "heightImportHmpBttn";
      this.heightImportHmpBttn.Size = new Size(75, 23);
      this.heightImportHmpBttn.TabIndex = 2;
      this.heightImportHmpBttn.Text = "Import HMP";
      this.heightImportHmpBttn.UseVisualStyleBackColor = true;
      this.heightImportHmpBttn.Click += new EventHandler(this.heightImportHmpBttn_Click);
      this.heightExportBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.heightExportBttn.Location = new Point(163, 6);
      this.heightExportBttn.Name = "heightExportBttn";
      this.heightExportBttn.Size = new Size(75, 23);
      this.heightExportBttn.TabIndex = 1;
      this.heightExportBttn.Text = "Export RAW";
      this.heightExportBttn.UseVisualStyleBackColor = true;
      this.heightExportBttn.Click += new EventHandler(this.heightExportBttn_Click);
      this.heightImportBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.heightImportBttn.Location = new Point(6, 6);
      this.heightImportBttn.Name = "heightImportBttn";
      this.heightImportBttn.Size = new Size(75, 23);
      this.heightImportBttn.TabIndex = 0;
      this.heightImportBttn.Text = "Import RAW";
      this.heightImportBttn.UseVisualStyleBackColor = true;
      this.heightImportBttn.Click += new EventHandler(this.heightImportBttn_Click);
      this.tabTextures.Controls.Add((Control) this.buttonGenTextureBlend);
      this.tabTextures.Controls.Add((Control) this.textureExportAllBttn);
      this.tabTextures.Controls.Add((Control) this.textureExportBttn);
      this.tabTextures.Controls.Add((Control) this.listTextures);
      this.tabTextures.Controls.Add((Control) this.pictureBoxTexPre);
      this.tabTextures.Controls.Add((Control) this.texmapGenerate);
      this.tabTextures.Location = new Point(4, 40);
      this.tabTextures.Name = "tabTextures";
      this.tabTextures.Padding = new Padding(3);
      this.tabTextures.Size = new Size(244, 542);
      this.tabTextures.TabIndex = 1;
      this.tabTextures.Text = "Textures";
      this.tabTextures.UseVisualStyleBackColor = true;
      this.buttonGenTextureBlend.Enabled = false;
      this.buttonGenTextureBlend.ForeColor = Color.FromArgb(64, 64, 64);
      this.buttonGenTextureBlend.Location = new Point(65, 475);
      this.buttonGenTextureBlend.Name = "buttonGenTextureBlend";
      this.buttonGenTextureBlend.Size = new Size(128, 23);
      this.buttonGenTextureBlend.TabIndex = 8;
      this.buttonGenTextureBlend.Text = "Blend Textures...";
      this.buttonGenTextureBlend.UseVisualStyleBackColor = true;
      this.buttonGenTextureBlend.Click += new EventHandler(this.buttonGenTextureBlend_Click);
      this.textureExportAllBttn.Enabled = false;
      this.textureExportAllBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.textureExportAllBttn.Location = new Point(151, 35);
      this.textureExportAllBttn.Name = "textureExportAllBttn";
      this.textureExportAllBttn.Size = new Size(75, 23);
      this.textureExportAllBttn.TabIndex = 7;
      this.textureExportAllBttn.Text = "Export All...";
      this.textureExportAllBttn.UseVisualStyleBackColor = true;
      this.textureExportAllBttn.Click += new EventHandler(this.textureExportAllBttn_Click);
      this.textureExportBttn.Enabled = false;
      this.textureExportBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.textureExportBttn.Location = new Point(151, 6);
      this.textureExportBttn.Name = "textureExportBttn";
      this.textureExportBttn.Size = new Size(75, 23);
      this.textureExportBttn.TabIndex = 6;
      this.textureExportBttn.Text = "Export...";
      this.textureExportBttn.UseVisualStyleBackColor = true;
      this.textureExportBttn.Click += new EventHandler(this.textureExportBttn_Click);
      this.listTextures.FormattingEnabled = true;
      this.listTextures.Location = new Point(7, 149);
      this.listTextures.Name = "listTextures";
      this.listTextures.Size = new Size(231, 225);
      this.listTextures.TabIndex = 5;
      this.listTextures.SelectedIndexChanged += new EventHandler(this.listTextures_SelectedIndexChanged_1);
      this.pictureBoxTexPre.BackColor = Color.Black;
      this.pictureBoxTexPre.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBoxTexPre.Location = new Point(7, 6);
      this.pictureBoxTexPre.Name = "pictureBoxTexPre";
      this.pictureBoxTexPre.Size = new Size(128, 128);
      this.pictureBoxTexPre.TabIndex = 4;
      this.pictureBoxTexPre.TabStop = false;
      this.texmapGenerate.Enabled = false;
      this.texmapGenerate.ForeColor = Color.FromArgb(64, 64, 64);
      this.texmapGenerate.Location = new Point(65, 513);
      this.texmapGenerate.Name = "texmapGenerate";
      this.texmapGenerate.Size = new Size(128, 23);
      this.texmapGenerate.TabIndex = 0;
      this.texmapGenerate.Text = "Generate Preview...";
      this.texmapGenerate.UseVisualStyleBackColor = true;
      this.texmapGenerate.Click += new EventHandler(this.texmapGenerate_Click);
      this.tabObjects.Controls.Add((Control) this.buttonObjExportObj);
      this.tabObjects.Controls.Add((Control) this.objectExportBttn);
      this.tabObjects.Controls.Add((Control) this.pictureBoxObPre);
      this.tabObjects.Controls.Add((Control) this.listObjects);
      this.tabObjects.Location = new Point(4, 40);
      this.tabObjects.Name = "tabObjects";
      this.tabObjects.Padding = new Padding(3);
      this.tabObjects.Size = new Size(244, 542);
      this.tabObjects.TabIndex = 2;
      this.tabObjects.Text = "Objects";
      this.tabObjects.UseVisualStyleBackColor = true;
      this.buttonObjExportObj.Enabled = false;
      this.buttonObjExportObj.ForeColor = Color.FromArgb(64, 64, 64);
      this.buttonObjExportObj.Location = new Point(151, 36);
      this.buttonObjExportObj.Name = "buttonObjExportObj";
      this.buttonObjExportObj.Size = new Size(87, 23);
      this.buttonObjExportObj.TabIndex = 3;
      this.buttonObjExportObj.Text = "Export OBJ...";
      this.buttonObjExportObj.UseVisualStyleBackColor = true;
      this.buttonObjExportObj.Click += new EventHandler(this.buttonObjExportObj_Click);
      this.objectExportBttn.Enabled = false;
      this.objectExportBttn.ForeColor = Color.FromArgb(64, 64, 64);
      this.objectExportBttn.Location = new Point(151, 6);
      this.objectExportBttn.Name = "objectExportBttn";
      this.objectExportBttn.Size = new Size(87, 23);
      this.objectExportBttn.TabIndex = 2;
      this.objectExportBttn.Text = "Export...";
      this.objectExportBttn.UseVisualStyleBackColor = true;
      this.objectExportBttn.Click += new EventHandler(this.objectExportBttn_Click);
      this.pictureBoxObPre.BackColor = Color.Black;
      this.pictureBoxObPre.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBoxObPre.Location = new Point(7, 6);
      this.pictureBoxObPre.Name = "pictureBoxObPre";
      this.pictureBoxObPre.Size = new Size(128, 128);
      this.pictureBoxObPre.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBoxObPre.TabIndex = 1;
      this.pictureBoxObPre.TabStop = false;
      this.listObjects.FormattingEnabled = true;
      this.listObjects.Location = new Point(7, 149);
      this.listObjects.Name = "listObjects";
      this.listObjects.Size = new Size(231, 225);
      this.listObjects.TabIndex = 0;
      this.listObjects.SelectedIndexChanged += new EventHandler(this.listObjects_SelectedIndexChanged);
      this.tabSky.Controls.Add((Control) this.comboBoxSkies);
      this.tabSky.Controls.Add((Control) this.buttonSkiesLoadBitBMP);
      this.tabSky.Location = new Point(4, 40);
      this.tabSky.Name = "tabSky";
      this.tabSky.Padding = new Padding(3);
      this.tabSky.Size = new Size(244, 542);
      this.tabSky.TabIndex = 4;
      this.tabSky.Text = "Sky";
      this.tabSky.UseVisualStyleBackColor = true;
      this.tabSky.Click += new EventHandler(this.tabSky_Click);
      this.comboBoxSkies.Enabled = false;
      this.comboBoxSkies.FormattingEnabled = true;
      this.comboBoxSkies.Items.AddRange(new object[3]
      {
        (object) "Dawn",
        (object) "Day",
        (object) "Night"
      });
      this.comboBoxSkies.Location = new Point(7, 149);
      this.comboBoxSkies.Name = "comboBoxSkies";
      this.comboBoxSkies.Size = new Size(231, 225);
      this.comboBoxSkies.TabIndex = 2;
      this.comboBoxSkies.SelectedIndexChanged += new EventHandler(this.comboBoxSkies_SelectedIndexChanged_1);
      this.buttonSkiesLoadBitBMP.Enabled = false;
      this.buttonSkiesLoadBitBMP.ForeColor = Color.FromArgb(64, 64, 64);
      this.buttonSkiesLoadBitBMP.Location = new Point(55, 495);
      this.buttonSkiesLoadBitBMP.Name = "buttonSkiesLoadBitBMP";
      this.buttonSkiesLoadBitBMP.Size = new Size(125, 23);
      this.buttonSkiesLoadBitBMP.TabIndex = 1;
      this.buttonSkiesLoadBitBMP.Text = "Reload Previews...";
      this.buttonSkiesLoadBitBMP.UseVisualStyleBackColor = true;
      this.buttonSkiesLoadBitBMP.Click += new EventHandler(this.buttonSkiesLoadBitBMP_Click);
      this.tabFogs.Controls.Add((Control) this.buttonFogMakePreview);
      this.tabFogs.Controls.Add((Control) this.labelFogTrans);
      this.tabFogs.Controls.Add((Control) this.trackBarFogTrans);
      this.tabFogs.Controls.Add((Control) this.labelFogYLimit);
      this.tabFogs.Controls.Add((Control) this.trackBarFogYLimit);
      this.tabFogs.Controls.Add((Control) this.labelFogHeight);
      this.tabFogs.Controls.Add((Control) this.trackBarFogHeight);
      this.tabFogs.Controls.Add((Control) this.pictureBoxFogPre);
      this.tabFogs.Controls.Add((Control) this.listBoxFogs);
      this.tabFogs.Controls.Add((Control) this.checkBoxFogMortal);
      this.tabFogs.Location = new Point(4, 40);
      this.tabFogs.Name = "tabFogs";
      this.tabFogs.Padding = new Padding(3);
      this.tabFogs.Size = new Size(244, 542);
      this.tabFogs.TabIndex = 5;
      this.tabFogs.Text = "Fogs";
      this.tabFogs.UseVisualStyleBackColor = true;
      this.tabFogs.Click += new EventHandler(this.tabFogs_Click);
      this.buttonFogMakePreview.Enabled = false;
      this.buttonFogMakePreview.ForeColor = Color.Black;
      this.buttonFogMakePreview.Location = new Point(60, 513);
      this.buttonFogMakePreview.Name = "buttonFogMakePreview";
      this.buttonFogMakePreview.Size = new Size(116, 23);
      this.buttonFogMakePreview.TabIndex = 9;
      this.buttonFogMakePreview.Text = "Generate Preview...";
      this.buttonFogMakePreview.UseVisualStyleBackColor = true;
      this.buttonFogMakePreview.Click += new EventHandler(this.buttonFogMakePreview_Click);
      this.labelFogTrans.AutoSize = true;
      this.labelFogTrans.ForeColor = Color.Black;
      this.labelFogTrans.Location = new Point(74, 410);
      this.labelFogTrans.Name = "labelFogTrans";
      this.labelFogTrans.Size = new Size(98, 13);
      this.labelFogTrans.TabIndex = 8;
      this.labelFogTrans.Text = "Fog Opacity: NULL";
      this.trackBarFogTrans.Enabled = false;
      this.trackBarFogTrans.Location = new Point(7, 391);
      this.trackBarFogTrans.Maximum = 100;
      this.trackBarFogTrans.Name = "trackBarFogTrans";
      this.trackBarFogTrans.Size = new Size(231, 45);
      this.trackBarFogTrans.TabIndex = 7;
      this.trackBarFogTrans.TickStyle = TickStyle.None;
      this.labelFogYLimit.AutoSize = true;
      this.labelFogYLimit.ForeColor = Color.Black;
      this.labelFogYLimit.Location = new Point(74, 361);
      this.labelFogYLimit.Name = "labelFogYLimit";
      this.labelFogYLimit.Size = new Size(117, 13);
      this.labelFogYLimit.TabIndex = 6;
      this.labelFogYLimit.Text = "Fog Height Limit: NULL";
      this.trackBarFogYLimit.Enabled = false;
      this.trackBarFogYLimit.LargeChange = 16;
      this.trackBarFogYLimit.Location = new Point(7, 340);
      this.trackBarFogYLimit.Maximum = (int) byte.MaxValue;
      this.trackBarFogYLimit.Name = "trackBarFogYLimit";
      this.trackBarFogYLimit.Size = new Size(231, 45);
      this.trackBarFogYLimit.TabIndex = 5;
      this.trackBarFogYLimit.TickStyle = TickStyle.None;
      this.labelFogHeight.AutoSize = true;
      this.labelFogHeight.ForeColor = Color.Black;
      this.labelFogHeight.Location = new Point(74, 310);
      this.labelFogHeight.Name = "labelFogHeight";
      this.labelFogHeight.Size = new Size(118, 13);
      this.labelFogHeight.TabIndex = 4;
      this.labelFogHeight.Text = "Fog Start Height: NULL";
      this.trackBarFogHeight.Enabled = false;
      this.trackBarFogHeight.LargeChange = 16;
      this.trackBarFogHeight.Location = new Point(7, 289);
      this.trackBarFogHeight.Maximum = (int) byte.MaxValue;
      this.trackBarFogHeight.Name = "trackBarFogHeight";
      this.trackBarFogHeight.RightToLeft = RightToLeft.No;
      this.trackBarFogHeight.Size = new Size(231, 45);
      this.trackBarFogHeight.TabIndex = 3;
      this.trackBarFogHeight.TickStyle = TickStyle.None;
      this.pictureBoxFogPre.Location = new Point(7, 6);
      this.pictureBoxFogPre.Name = "pictureBoxFogPre";
      this.pictureBoxFogPre.Size = new Size(128, 128);
      this.pictureBoxFogPre.TabIndex = 2;
      this.pictureBoxFogPre.TabStop = false;
      this.listBoxFogs.FormattingEnabled = true;
      this.listBoxFogs.Location = new Point(7, 149);
      this.listBoxFogs.Name = "listBoxFogs";
      this.listBoxFogs.Size = new Size(231, 134);
      this.listBoxFogs.TabIndex = 1;
      this.listBoxFogs.SelectedIndexChanged += new EventHandler(this.listBoxFogs_SelectedIndexChanged);
      this.checkBoxFogMortal.AutoSize = true;
      this.checkBoxFogMortal.CheckAlign = ContentAlignment.MiddleRight;
      this.checkBoxFogMortal.Enabled = false;
      this.checkBoxFogMortal.ForeColor = Color.FromArgb(64, 64, 64);
      this.checkBoxFogMortal.Location = new Point(151, 6);
      this.checkBoxFogMortal.Name = "checkBoxFogMortal";
      this.checkBoxFogMortal.Size = new Size(55, 17);
      this.checkBoxFogMortal.TabIndex = 0;
      this.checkBoxFogMortal.Text = "Lethal";
      this.checkBoxFogMortal.UseVisualStyleBackColor = true;
      this.tabSounds.Location = new Point(4, 40);
      this.tabSounds.Name = "tabSounds";
      this.tabSounds.Padding = new Padding(3);
      this.tabSounds.Size = new Size(244, 542);
      this.tabSounds.TabIndex = 6;
      this.tabSounds.Text = "Sounds";
      this.tabSounds.UseVisualStyleBackColor = true;
      this.tabWater.Controls.Add((Control) this.labelWaterTrans);
      this.tabWater.Controls.Add((Control) this.trackBarWaterTransp);
      this.tabWater.Controls.Add((Control) this.labelWaterHeight);
      this.tabWater.Controls.Add((Control) this.trackBarWaterHeight);
      this.tabWater.Controls.Add((Control) this.listBoxWaters);
      this.tabWater.Controls.Add((Control) this.comboBoxWaterTextureIndex);
      this.tabWater.Controls.Add((Control) this.labelWaterTexIndex);
      this.tabWater.Controls.Add((Control) this.pictureBoxWaterPreview);
      this.tabWater.Location = new Point(4, 40);
      this.tabWater.Name = "tabWater";
      this.tabWater.Padding = new Padding(3);
      this.tabWater.Size = new Size(244, 542);
      this.tabWater.TabIndex = 7;
      this.tabWater.Text = "Water";
      this.tabWater.UseVisualStyleBackColor = true;
      this.vid_panel.BackColor = Color.FromArgb(34, 47, 61);
      this.vid_panel.BackgroundImageLayout = ImageLayout.Stretch;
      this.vid_panel.BorderStyle = BorderStyle.FixedSingle;
      this.vid_panel.Location = new Point(-4, 0);
      this.vid_panel.Name = "vid_panel";
      this.vid_panel.Size = new Size(512, 512);
      this.vid_panel.SizeMode = PictureBoxSizeMode.StretchImage;
      this.vid_panel.TabIndex = 8;
      this.vid_panel.TabStop = false;
      this.vid_panel.MouseUp += new MouseEventHandler(this.vid_panel_MouseUp);
      this.exportHeightRaw.DefaultExt = "raw";
      this.exportHeightRaw.Filter = "RAW |*.raw";
      this.exportHeightRaw.FileOk += new CancelEventHandler(this.exportHeightRaw_FileOk);
      this.backgroundLoadC2Map.WorkerReportsProgress = true;
      this.backgroundLoadC2Map.DoWork += new DoWorkEventHandler(this.backgroundLoadC2Map_DoWork);
      this.progressBarMapLoad.Location = new Point(1, 661);
      this.progressBarMapLoad.Name = "progressBarMapLoad";
      this.progressBarMapLoad.Size = new Size(870, 13);
      this.progressBarMapLoad.TabIndex = 9;
      this.openHeightHMPDialog.Filter = "HMP Exported Heightmap|*.hmp";
      this.openHeightHMPDialog.FileOk += new CancelEventHandler(this.openHeightHMPDialog_FileOk);
      this.openC2RSC.DefaultExt = "rsc";
      this.openC2RSC.Filter = "Carnivores 2 Resources | *.rsc";
      this.openC2RSC.FileOk += new CancelEventHandler(this.openC2RSC_FileOk);
      this.backgroundWorkerLoadRSC.WorkerReportsProgress = true;
      this.backgroundWorkerLoadRSC.DoWork += new DoWorkEventHandler(this.backgroundWorkerLoadRSC_DoWork);
      this.panel1.Controls.Add((Control) this.mapTabs);
      this.panel1.Location = new Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(586, 547);
      this.panel1.TabIndex = 10;
      this.mapTabs.Controls.Add((Control) this.tabPage1);
      this.mapTabs.Controls.Add((Control) this.tabPage2);
      this.mapTabs.Location = new Point(3, 3);
      this.mapTabs.Name = "mapTabs";
      this.mapTabs.SelectedIndex = 0;
      this.mapTabs.Size = new Size(518, 541);
      this.mapTabs.TabIndex = 9;
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Controls.Add((Control) this.vid_panel);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(510, 515);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Map";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage2.Controls.Add((Control) this.rsc_panel);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(510, 515);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Resource";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.rsc_panel.BackColor = Color.FromArgb(34, 47, 61);
      this.rsc_panel.BackgroundImageLayout = ImageLayout.Center;
      this.rsc_panel.Location = new Point(-4, 0);
      this.rsc_panel.Name = "rsc_panel";
      this.rsc_panel.Size = new Size(512, 512);
      this.rsc_panel.TabIndex = 0;
      this.rsc_panel.TabStop = false;
      this.checkBoxViewMini.AutoSize = true;
      this.checkBoxViewMini.Checked = true;
      this.checkBoxViewMini.CheckState = CheckState.Checked;
      this.checkBoxViewMini.Location = new Point(12, 565);
      this.checkBoxViewMini.Name = "checkBoxViewMini";
      this.checkBoxViewMini.Size = new Size(106, 17);
      this.checkBoxViewMini.TabIndex = 4;
      this.checkBoxViewMini.Text = "View as MiniMap";
      this.checkBoxViewMini.UseVisualStyleBackColor = true;
      this.checkBoxViewMini.CheckedChanged += new EventHandler(this.checkBoxViewMini_CheckedChanged);
      this.exportHeightBMPDialog.DefaultExt = "bmp";
      this.exportHeightBMPDialog.Filter = "32bit Bitmap | *.bmp";
      this.exportHeightBMPDialog.FileOk += new CancelEventHandler(this.exportHeightBMPDialog_FileOk);
      this.openHeightBMPDialog.Filter = "32bit Bitmap | *.bmp";
      this.openHeightBMPDialog.FileOk += new CancelEventHandler(this.openHeightBMPDialog_FileOk);
      this.openHeightC1Dialog.Filter = "C1 Map | *.map";
      this.openHeightC1Dialog.FileOk += new CancelEventHandler(this.openHeightC1Dialog_FileOk);
      this.exportTextureDialog.AddExtension = false;
      this.exportTextureDialog.DefaultExt = "bmp";
      this.exportTextureDialog.Filter = "32bit Bitmap | *.bmp";
      this.exportTextureDialog.FileOk += new CancelEventHandler(this.exportTextureDialog_FileOk);
      this.exportAllTexturesDialog.HelpRequest += new EventHandler(this.exportAllTexturesDialog_HelpRequest);
      this.savec2ObjectDialog.DefaultExt = "c2o";
      this.savec2ObjectDialog.Filter = "C2 Objects | *.c2o";
      this.savec2ObjectDialog.FileOk += new CancelEventHandler(this.savec2ObjectDialog_FileOk);
      this.saveCObjObjectDialog.DefaultExt = "obj";
      this.saveCObjObjectDialog.Filter = "Wavefront OBJ | *.OBJ";
      this.saveCObjObjectDialog.FileOk += new CancelEventHandler(this.saveCObjObjectDialog_FileOk);
      this.pictureBoxWaterPreview.Location = new Point(7, 6);
      this.pictureBoxWaterPreview.Name = "pictureBoxWaterPreview";
      this.pictureBoxWaterPreview.Size = new Size(128, 128);
      this.pictureBoxWaterPreview.TabIndex = 0;
      this.pictureBoxWaterPreview.TabStop = false;
      this.labelWaterTexIndex.AutoSize = true;
      this.labelWaterTexIndex.ForeColor = Color.FromArgb(64, 64, 64);
      this.labelWaterTexIndex.Location = new Point(7, 141);
      this.labelWaterTexIndex.Name = "labelWaterTexIndex";
      this.labelWaterTexIndex.Size = new Size(75, 13);
      this.labelWaterTexIndex.TabIndex = 1;
      this.labelWaterTexIndex.Text = "Texture Index:";
      this.comboBoxWaterTextureIndex.Enabled = false;
      this.comboBoxWaterTextureIndex.FormattingEnabled = true;
      this.comboBoxWaterTextureIndex.Location = new Point(88, 138);
      this.comboBoxWaterTextureIndex.Name = "comboBoxWaterTextureIndex";
      this.comboBoxWaterTextureIndex.Size = new Size(47, 21);
      this.comboBoxWaterTextureIndex.TabIndex = 2;
      this.comboBoxWaterTextureIndex.SelectedIndexChanged += new EventHandler(this.comboBoxWaterTextureIndex_SelectedIndexChanged);
      this.listBoxWaters.Enabled = false;
      this.listBoxWaters.FormattingEnabled = true;
      this.listBoxWaters.Location = new Point(6, 165);
      this.listBoxWaters.Name = "listBoxWaters";
      this.listBoxWaters.Size = new Size(231, 134);
      this.listBoxWaters.TabIndex = 3;
      this.listBoxWaters.SelectedIndexChanged += new EventHandler(this.listBoxWaters_SelectedIndexChanged);
      this.labelWaterHeight.AutoSize = true;
      this.labelWaterHeight.ForeColor = Color.Black;
      this.labelWaterHeight.Location = new Point(85, 325);
      this.labelWaterHeight.Name = "labelWaterHeight";
      this.labelWaterHeight.Size = new Size(72, 13);
      this.labelWaterHeight.TabIndex = 6;
      this.labelWaterHeight.Text = "Height: NULL";
      this.trackBarWaterHeight.Enabled = false;
      this.trackBarWaterHeight.Location = new Point(7, 305);
      this.trackBarWaterHeight.Maximum = (int) byte.MaxValue;
      this.trackBarWaterHeight.Name = "trackBarWaterHeight";
      this.trackBarWaterHeight.RightToLeft = RightToLeft.No;
      this.trackBarWaterHeight.Size = new Size(231, 45);
      this.trackBarWaterHeight.TabIndex = 5;
      this.trackBarWaterHeight.TickStyle = TickStyle.None;
      this.trackBarWaterHeight.Scroll += new EventHandler(this.trackBarWaterHeight_Scroll);
      this.labelWaterTrans.AutoSize = true;
      this.labelWaterTrans.ForeColor = Color.Black;
      this.labelWaterTrans.Location = new Point(85, 375);
      this.labelWaterTrans.Name = "labelWaterTrans";
      this.labelWaterTrans.Size = new Size(77, 13);
      this.labelWaterTrans.TabIndex = 10;
      this.labelWaterTrans.Text = "Opacity: NULL";
      this.trackBarWaterTransp.Enabled = false;
      this.trackBarWaterTransp.Location = new Point(7, 356);
      this.trackBarWaterTransp.Maximum = 100;
      this.trackBarWaterTransp.Name = "trackBarWaterTransp";
      this.trackBarWaterTransp.Size = new Size(231, 45);
      this.trackBarWaterTransp.TabIndex = 9;
      this.trackBarWaterTransp.TickStyle = TickStyle.None;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = Color.FromArgb(50, 65, 84);
      this.ClientSize = new Size(875, 678);
      this.Controls.Add((Control) this.checkBoxViewMini);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.progressBarMapLoad);
      this.Controls.Add((Control) this.tabs);
      this.Controls.Add((Control) this.panelInfo);
      this.ForeColor = Color.FromArgb(137, 175, 197);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.Text = "Adelphos Pro - Carnivores Community Edition Development Toolset - MapPainter";
      this.Load += new EventHandler(this.Form1_Load);
      this.panelInfo.ResumeLayout(false);
      this.panelInfo.PerformLayout();
      this.tabs.ResumeLayout(false);
      this.tabMDetail.ResumeLayout(false);
      this.groupBoxRsc.ResumeLayout(false);
      this.groupBoxMDetailsA.ResumeLayout(false);
      this.tabHeightmap.ResumeLayout(false);
      this.tabTextures.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBoxTexPre).EndInit();
      this.tabObjects.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBoxObPre).EndInit();
      this.tabSky.ResumeLayout(false);
      this.tabFogs.ResumeLayout(false);
      this.tabFogs.PerformLayout();
      this.trackBarFogTrans.EndInit();
      this.trackBarFogYLimit.EndInit();
      this.trackBarFogHeight.EndInit();
      ((ISupportInitialize) this.pictureBoxFogPre).EndInit();
      this.tabWater.ResumeLayout(false);
      this.tabWater.PerformLayout();
      ((ISupportInitialize) this.vid_panel).EndInit();
      this.panel1.ResumeLayout(false);
      this.mapTabs.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((ISupportInitialize) this.rsc_panel).EndInit();
      ((ISupportInitialize) this.pictureBoxWaterPreview).EndInit();
      this.trackBarWaterHeight.EndInit();
      this.trackBarWaterTransp.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public Form1()
    {
      this.ActiveTab = this.appConst.TAB_DETAILS;
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.saveCIAMapBttn.Enabled = false;
      this.loadRscBttn.Enabled = false;
      this.backgroundLoadC2Map.ProgressChanged += new ProgressChangedEventHandler(this.backgroundLoadC2Map_ReportProgress);
      this.backgroundWorkerLoadRSC.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorkerLoadRSC_ReportProgress);
    }

    private void openc2MapDialog_FileOk(object sender, CancelEventArgs e)
    {
      this.FogPreview = (Bitmap) null;
      this.MapPreview = (Bitmap) null;
      this.backgroundLoadC2Map.RunWorkerAsync();
    }

    private void rAWToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      int num = (int) this.openHeightRawDialog.ShowDialog();
    }

    private void openHeightRawDialog_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedMap == null)
      {
        int num1 = (int) MessageBox.Show("Load a map first");
      }
      else if (this.LoadedMap.ReplaceHeightmapFromRAW(this.openHeightRawDialog.FileName))
      {
        this.ActiveTab = -1;
        this.UpdateForm();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Faled to load RAW heightmap data");
      }
    }

    private void saveMapDialog_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedMap == null)
      {
        int num1 = (int) MessageBox.Show("Load a map first");
      }
      else if (this.LoadedMap.SaveAs(this.saveMapDialog.FileName))
      {
        int num2 = (int) MessageBox.Show("New Map Saved");
      }
      else
      {
        int num3 = (int) MessageBox.Show("Map failed to save");
      }
    }

    private void loadC2IAMapToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      int num = (int) this.openc2MapDialog.ShowDialog();
    }

    private void c2IAMapToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      int num = (int) this.saveMapDialog.ShowDialog();
    }

    private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void heightImportBttn_Click(object sender, EventArgs e)
    {
      int num = (int) this.openHeightRawDialog.ShowDialog();
    }

    private void loadCIAMapBttn_Click(object sender, EventArgs e)
    {
      int num = (int) this.openc2MapDialog.ShowDialog();
    }

    private void saveCIAMapBttn_Click(object sender, EventArgs e)
    {
      int num = (int) this.saveMapDialog.ShowDialog();
    }

    public void UpdateForm()
    {
      if (this.tabs.SelectedIndex != this.ActiveTab && this.LoadedMap != null)
      {
        this.ActiveTab = this.tabs.SelectedIndex;
        this.mapTabs.SelectedIndex = 0;
        switch (this.ActiveTab)
        {
          case 0:
            this.rsc_panel.BackgroundImage = (Image) null;
            if (this.MapPreview != null)
            {
              this.vid_panel.BackgroundImage = (Image) this.MapPreview;
              break;
            }
            if (this.LoadedMap == null || this.LoadedMap.heightmap_bmp == null)
              break;
            this.vid_panel.BackgroundImage = (Image) this.LoadedMap.heightmap_bmp;
            break;
          case 1:
            this.vid_panel.BackgroundImage = (Image) this.LoadedMap.heightmap_bmp;
            this.rsc_panel.BackgroundImage = (Image) null;
            break;
          case 2:
            this.vid_panel.BackgroundImage = (Image) this.MapPreview;
            this.rsc_panel.BackgroundImage = (Image) null;
            if (this.LoadedRsc == null)
            {
              this.textureExportBttn.Enabled = false;
              this.textureExportAllBttn.Enabled = false;
              this.texmapGenerate.Enabled = false;
              break;
            }
            this.textureExportBttn.Enabled = true;
            this.textureExportAllBttn.Enabled = true;
            this.texmapGenerate.Enabled = true;
            break;
          case 4:
            this.mapTabs.SelectedIndex = 1;
            int selectedIndex = this.comboBoxSkies.SelectedIndex;
            this.comboBoxSkies.SelectedIndex = 1;
            if (selectedIndex != this.comboBoxSkies.SelectedIndex)
              break;
            this.comboBoxSkies_SelectedIndexChanged_1((object) null, (EventArgs) null);
            break;
          case 5:
            this.rsc_panel.BackgroundImage = (Image) null;
            if (this.FogPreview != null)
            {
              this.vid_panel.BackgroundImage = (Image) this.FogPreview;
              break;
            }
            if (this.LoadedMap == null || this.LoadedMap.heightmap_bmp == null)
              break;
            this.vid_panel.BackgroundImage = (Image) this.LoadedMap.heightmap_bmp;
            break;
          default:
            this.vid_panel.BackgroundImage = (Image) null;
            this.rsc_panel.BackgroundImage = (Image) null;
            break;
        }
      }
      else
      {
        if (this.LoadedMap != null || this.tabs.SelectedIndex == this.appConst.TAB_DETAILS)
          return;
        this.tabs.SelectedIndex = this.appConst.TAB_DETAILS;
      }
    }

    private void heightExportBttn_Click(object sender, EventArgs e)
    {
      int num = (int) this.exportHeightRaw.ShowDialog();
    }

    private void exportHeightRaw_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedMap == null)
      {
        int num1 = (int) MessageBox.Show("Load a map first");
      }
      else if (this.LoadedMap.ExportHeightmap(this.exportHeightRaw.FileName))
      {
        int num2 = (int) MessageBox.Show("RAW heightmap exported");
      }
      else
      {
        int num3 = (int) MessageBox.Show("Failed to export map");
      }
    }

    private void backgroundLoadC2Map_DoWork(object sender, DoWorkEventArgs e)
    {
      this.backgroundLoadC2Map.ReportProgress(10);
      if (this.LoadedMap != null)
        this.LoadedMap = (Map) null;
      this.LoadedMap = new Map();
      this.backgroundLoadC2Map.ReportProgress(25);
      if (this.LoadedMap.Load(this.openc2MapDialog.FileName))
      {
        this.backgroundLoadC2Map.ReportProgress(60);
        this.LoadedMap.UpdateHeightbmp();
        this.backgroundLoadC2Map.ReportProgress(80);
        this.LoadedMap.UpdateTexturemap1Bmp();
        this.backgroundLoadC2Map.ReportProgress(100);
      }
      else
      {
        int num = (int) MessageBox.Show("Failed to load c2 MAP file");
        this.LoadedMap = (Map) null;
        this.backgroundLoadC2Map.ReportProgress(100);
      }
    }

    private void backgroundLoadC2Map_ReportProgress(object sender, ProgressChangedEventArgs e)
    {
      this.progressBarMapLoad.Value = e.ProgressPercentage;
      if (e.ProgressPercentage == 100)
      {
        if (this.LoadedMap != null)
        {
          string[] strArray = this.openc2MapDialog.FileName.Split('\\');
          this.mapLoadedTxt.Text = strArray[strArray.Length - 1];
          this.saveCIAMapBttn.Enabled = true;
          this.loadRscBttn.Enabled = true;
          this.LoadedRsc = (Rsc) null;
          this.MapPreview = (Bitmap) null;
          this.ActiveTab = -1;
          this.UpdateForm();
        }
        this.Enabled = true;
        this.progressBarMapLoad.Value = 0;
      }
      else
        this.Enabled = false;
    }

    private void heightImportHmpBttn_Click(object sender, EventArgs e)
    {
      int num = (int) this.openHeightHMPDialog.ShowDialog();
    }

    private void openHeightHMPDialog_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedMap == null)
      {
        int num1 = (int) MessageBox.Show("Load a map first");
      }
      else if (this.LoadedMap.ReplaceHeightmapFromHMP(this.openHeightHMPDialog.FileName))
      {
        this.ActiveTab = -1;
        this.UpdateForm();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Faled to load RAW heightmap data");
      }
    }

    private void texmapGenerate_Click(object sender, EventArgs e)
    {
      this.Enabled = false;
      this.GenerateMapPic();
      this.vid_panel.BackgroundImage = (Image) this.MapPreview;
      this.Enabled = true;
    }

    private void loadRscBttn_Click(object sender, EventArgs e)
    {
      this.listTextures.Items.Clear();
      int num = (int) this.openC2RSC.ShowDialog();
    }

    private void openC2RSC_FileOk(object sender, CancelEventArgs e)
    {
      this.MapPreview = (Bitmap) null;
      this.FogPreview = (Bitmap) null;
      this.backgroundWorkerLoadRSC.RunWorkerAsync();
    }

    private void backgroundWorkerLoadRSC_DoWork(object sender, DoWorkEventArgs e)
    {
      if (this.LoadedRsc != null)
        this.LoadedRsc = (Rsc) null;
      this.LoadedRsc = new Rsc();
      this.backgroundWorkerLoadRSC.ReportProgress(0);
      if (this.LoadedRsc.Load(this.openC2RSC.FileName))
      {
        this.backgroundWorkerLoadRSC.ReportProgress(0);
        float num = 0.0f;
        int numTextures = this.LoadedRsc.num_textures;
        for (int tex_index = 0; tex_index < this.LoadedRsc.num_textures; ++tex_index)
        {
          this.LoadedRsc.Texture_Bitmaps[tex_index] = this.LoadedRsc.getBitmapForTexture(tex_index);
          this.backgroundWorkerLoadRSC.ReportProgress((int) (float) ((double) tex_index / (double) numTextures * 99.0));
        }
        num = 0.0f;
        int numObjects = this.LoadedRsc.num_objects;
        for (int o_index = 0; o_index < numObjects; ++o_index)
        {
          this.LoadedRsc.Object_Bitmaps[o_index] = this.LoadedRsc.getBitmapForObject(o_index);
          this.backgroundWorkerLoadRSC.ReportProgress((int) (float) ((double) o_index / (double) numObjects * 99.0));
        }
        this.backgroundWorkerLoadRSC.ReportProgress(100);
      }
      else
      {
        int num = (int) MessageBox.Show("Failed to load c2 RSC file");
        this.LoadedRsc = (Rsc) null;
        this.backgroundWorkerLoadRSC.ReportProgress(100);
      }
    }

    private bool is_bit_set(ushort value, ushort bitindex)
    {
      return ((int) value & 1 << (int) bitindex) != 0;
    }

    private bool GenerateMapPic()
    {
      Color[] colorArray = new Color[128];
      if (this.LoadedRsc == null || this.LoadedMap == null)
        return false;
      if (this.MapPreview != null)
        this.MapPreview = (Bitmap) null;
      this.progressBarMapLoad.Value = 0;
      this.MapPreview = new Bitmap(1024, 1024);
      for (int index = 0; index < this.LoadedRsc.num_textures; ++index)
      {
        colorArray[index] = Form1.getDominantColor(this.LoadedRsc.Texture_Bitmaps[index]);
        this.progressBarMapLoad.Value = (int) (float) ((double) index / (double) this.LoadedRsc.num_textures * 50.0);
      }
      for (int y = 0; y < 1024; ++y)
      {
        for (int x = 0; x < 1024; ++x)
        {
          int index = int.Parse(this.LoadedMap.Texturemap1[y, x].ToString());
          float factor = (float) this.LoadedMap.Heightmap[y, x] * 0.01f;
          Color color = this.AdjustBrightness(index <= -1 || index >= this.LoadedRsc.num_textures ? Color.Blue : colorArray[index], factor);
          this.MapPreview.SetPixel(x, y, color);
          this.progressBarMapLoad.Value = (int) (float) (50.0 + (double) (y * 1024 + x) / 1048576.0 * 50.0);
        }
      }
      this.progressBarMapLoad.Value = 0;
      return true;
    }

    private Color AdjustBrightness(Color c1, float factor)
    {
      float num1 = (double) c1.R * (double) factor > (double) byte.MaxValue ? (float) byte.MaxValue : (float) c1.R * factor;
      float num2 = (double) c1.G * (double) factor > (double) byte.MaxValue ? (float) byte.MaxValue : (float) c1.G * factor;
      float num3 = (double) c1.B * (double) factor > (double) byte.MaxValue ? (float) byte.MaxValue : (float) c1.B * factor;
      return Color.FromArgb((int) c1.A, (int) num1, (int) num2, (int) num3);
    }

    public static Color getDominantColor(Bitmap bmp)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      for (int x = 0; x < bmp.Width; ++x)
      {
        for (int y = 0; y < bmp.Height; ++y)
        {
          Color pixel = bmp.GetPixel(x, y);
          num1 += (int) pixel.R;
          num2 += (int) pixel.G;
          num3 += (int) pixel.B;
          ++num4;
        }
      }
      return Color.FromArgb(num1 / num4, num2 / num4, num3 / num4);
    }

    private void backgroundWorkerLoadRSC_ReportProgress(object sender, ProgressChangedEventArgs e)
    {
      this.progressBarMapLoad.Value = e.ProgressPercentage;
      if (e.ProgressPercentage == 100)
      {
        if (this.LoadedRsc != null)
        {
          this.listTextures.Items.Clear();
          for (int index = 0; index < this.LoadedRsc.num_textures; ++index)
          {
            this.listTextures.Items.Add((object) ("Texture " + index.ToString()));
            this.comboBoxWaterTextureIndex.Items.Add((object) index.ToString());
          }
          this.textureExportAllBttn.Enabled = true;
          this.textureExportBttn.Enabled = true;
          this.comboBoxSkies.Enabled = true;
          this.listObjects.Items.Clear();
          for (int index = 0; index < this.LoadedRsc.num_objects; ++index)
            this.listObjects.Items.Add((object) ("Object " + index.ToString()));
          this.objectExportBttn.Enabled = true;
          this.buttonObjExportObj.Enabled = true;
          this.listBoxFogs.Items.Clear();
          this.listBoxFogs.Items.Add((object) "No Fog");
          for (int index = 1; index <= this.LoadedRsc.num_fogs; ++index)
            this.listBoxFogs.Items.Add((object) ("Fog " + index.ToString()));
          this.buttonFogMakePreview.Enabled = true;
          this.listBoxWaters.Items.Clear();
          for (int index = 0; index < this.LoadedRsc.num_water; ++index)
            this.listBoxWaters.Items.Add((object) ("Water " + index.ToString()));
          this.listBoxWaters.Enabled = true;
          this.labelLoadRSC.Text = "Loaded!";
        }
        this.Enabled = true;
        this.progressBarMapLoad.Value = 0;
      }
      else
        this.Enabled = false;
    }

    private void listTextures_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      if (this.LoadedRsc == null || this.listTextures.SelectedIndex == -1 || this.listTextures.SelectedIndex == -1)
        return;
      this.pictureBoxTexPre.BackgroundImage = (Image) this.LoadedRsc.Texture_Bitmaps[this.listTextures.SelectedIndex];
    }

    private void checkBoxViewMini_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.checkBoxViewMini.Checked)
      {
        this.vid_panel.Width = 4096;
        this.vid_panel.Height = 4096;
      }
      else
      {
        this.vid_panel.Width = 512;
        this.vid_panel.Height = 512;
      }
    }

    private void textureExportBttn_Click(object sender, EventArgs e)
    {
      if (this.listTextures.SelectedIndex == -1)
        return;
      int num = (int) this.exportTextureDialog.ShowDialog();
    }

    private void textureExportAllBttn_Click(object sender, EventArgs e)
    {
      this.Enabled = false;
      if (this.LoadedRsc != null)
      {
        int num = (int) this.exportAllTexturesDialog.ShowDialog();
        if (this.exportAllTexturesDialog.SelectedPath.Length > 0)
        {
          this.progressBarMapLoad.Value = 0;
          for (int index = 0; index < this.LoadedRsc.num_textures; ++index)
          {
            this.LoadedRsc.Texture_Bitmaps[index].Save(this.exportAllTexturesDialog.SelectedPath + "\\texture_" + index.ToString() + ".bmp", ImageFormat.Bmp);
            this.progressBarMapLoad.Value = (int) ((double) ((float) index / (float) this.LoadedRsc.num_textures) * 100.0);
          }
        }
      }
      this.progressBarMapLoad.Value = 0;
      this.Enabled = true;
    }

    private void heightmapExportBMPBttn_Click(object sender, EventArgs e)
    {
      if (this.LoadedMap.heightmap_bmp == null)
      {
        int num1 = (int) MessageBox.Show("Cannot export heightmap as bitmap - Heightmap bitmap not loaded");
      }
      else
      {
        int num2 = (int) this.exportHeightBMPDialog.ShowDialog();
      }
    }

    private void exportHeightBMPDialog_FileOk(object sender, CancelEventArgs e)
    {
      this.LoadedMap.heightmap_bmp.Save(this.exportHeightBMPDialog.FileName, ImageFormat.Bmp);
    }

    private void heightImportBMPBttn_Click(object sender, EventArgs e)
    {
      int num = (int) this.openHeightBMPDialog.ShowDialog();
    }

    private void openHeightBMPDialog_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedMap == null)
      {
        int num1 = (int) MessageBox.Show("Load a map first");
      }
      else if (this.LoadedMap.ReplaceHeightmapFromBMP(this.openHeightBMPDialog.FileName))
      {
        this.ActiveTab = -1;
        this.UpdateForm();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Faled to load Bitmap heightmap data");
      }
    }

    private void heightImportC1Bttn_Click(object sender, EventArgs e)
    {
      int num = (int) this.openHeightC1Dialog.ShowDialog();
    }

    private void openHeightC1Dialog_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedMap == null)
      {
        int num1 = (int) MessageBox.Show("Load a map first");
      }
      else if (this.LoadedMap.ReplaceHeightmapFromC1(this.openHeightC1Dialog.FileName))
      {
        this.ActiveTab = -1;
        this.UpdateForm();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Faled to load carnivores 1 heightmap data");
      }
    }

    private void exportTextureDialog_FileOk(object sender, CancelEventArgs e)
    {
      this.LoadedRsc.Texture_Bitmaps[this.listTextures.SelectedIndex].Save(this.exportTextureDialog.FileName, ImageFormat.Bmp);
    }

    private void exportAllTexturesDialog_HelpRequest(object sender, EventArgs e)
    {
    }

    private void listObjects_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.LoadedRsc == null || this.listObjects.SelectedIndex == -1 || this.listObjects.SelectedIndex == -1)
        return;
      this.pictureBoxObPre.BackgroundImage = (Image) this.LoadedRsc.Object_Bitmaps[this.listObjects.SelectedIndex];
    }

    private void objectExportBttn_Click(object sender, EventArgs e)
    {
      if (this.listObjects.SelectedIndex == -1)
        return;
      int num = (int) this.savec2ObjectDialog.ShowDialog();
    }

    private void savec2ObjectDialog_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedRsc == null || this.listObjects.SelectedIndex == -1)
        return;
      this.LoadedRsc.Objects[this.listObjects.SelectedIndex].SaveAs(this.savec2ObjectDialog.FileName);
    }

    private void tabSky_Click(object sender, EventArgs e)
    {
    }

    private void buttonSkiesLoadBitBMP_Click(object sender, EventArgs e)
    {
    }

    private void comboBoxSkies_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      if (this.LoadedRsc == null || this.comboBoxSkies.SelectedIndex == -1 || !this.LoadedRsc.getBitmapForSky(this.comboBoxSkies.SelectedIndex))
        return;
      this.rsc_panel.BackgroundImage = (Image) this.LoadedRsc.Skies[this.comboBoxSkies.SelectedIndex];
      this.mapTabs.SelectedIndex = 1;
    }

    private void listBoxFogs_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.LoadedRsc == null)
        return;
      int index = this.listBoxFogs.SelectedIndex;
      if (index == 0)
      {
        if (this.LoadedRsc.num_fogs > 0)
        {
          index = 1;
          this.listBoxFogs.SelectedIndex = 1;
        }
        else
        {
          index = -1;
          this.listBoxFogs.SelectedIndex = -1;
        }
      }
      if (index == -1)
        return;
      this.trackBarFogHeight.Value = (int) this.LoadedRsc.Fogs[index].y;
      this.labelFogHeight.Text = "Fog Start Height: " + this.trackBarFogHeight.Value.ToString();
      this.trackBarFogYLimit.Value = (int) this.LoadedRsc.Fogs[index].FLimit;
      this.labelFogYLimit.Text = "Fog Height Limit: " + this.trackBarFogYLimit.Value.ToString();
      this.trackBarFogTrans.Value = (int) ((double) this.LoadedRsc.Fogs[index].opacity / 1024.0 * 100.0);
      this.labelFogTrans.Text = "Fog Opacity: " + ((float) ((double) this.LoadedRsc.Fogs[index].opacity / 1024.0 * 100.0)).ToString() + "%";
      this.checkBoxFogMortal.Checked = this.LoadedRsc.Fogs[index].isMortal == 1;
      this.pictureBoxFogPre.BackColor = Color.FromArgb(this.LoadedRsc.Fogs[index].RGB & (int) byte.MaxValue, this.LoadedRsc.Fogs[index].RGB >> 8 & (int) byte.MaxValue, this.LoadedRsc.Fogs[index].RGB >> 16 & (int) byte.MaxValue);
    }

    private void tabFogs_Click(object sender, EventArgs e)
    {
    }

    private void buttonFogMakePreview_Click(object sender, EventArgs e)
    {
      Color[] colorArray = new Color[128];
      if (this.LoadedRsc == null || this.LoadedMap == null)
        return;
      if (this.FogPreview != null)
        this.FogPreview = (Bitmap) null;
      this.progressBarMapLoad.Value = 0;
      this.FogPreview = new Bitmap(1024, 1024);
      for (int y = 0; y < 1024; ++y)
      {
        for (int x = 0; x < 1024; ++x)
        {
          int index = int.Parse(this.LoadedMap.Fogmap[y / 2, x / 2].ToString());
          Color color;
          if (index > 0 && index <= this.LoadedRsc.num_fogs)
          {
            color = Color.FromArgb(this.LoadedRsc.Fogs[index].RGB & (int) byte.MaxValue, this.LoadedRsc.Fogs[index].RGB >> 8 & (int) byte.MaxValue, this.LoadedRsc.Fogs[index].RGB >> 16 & (int) byte.MaxValue);
            if (index == 0)
            {
              float factor = (float) this.LoadedMap.Heightmap[y, x] * (1f / 1000f);
              color = this.AdjustBrightness(color, factor);
            }
          }
          else
          {
            switch (index)
            {
              case 0:
                color = this.AdjustBrightness(this.LoadedMap.heightmap_bmp.GetPixel(x, y), (float) this.LoadedMap.Heightmap[y, x] * (1f / 1000f));
                break;
              case (int) sbyte.MaxValue:
                color = Color.Green;
                break;
              default:
                color = Color.Blue;
                break;
            }
          }
          this.FogPreview.SetPixel(x, y, color);
          this.progressBarMapLoad.Value = (int) (float) ((double) (y * 1024 + x) / 1048576.0 * 100.0);
        }
      }
      this.progressBarMapLoad.Value = 0;
      this.vid_panel.BackgroundImage = (Image) this.FogPreview;
    }

    private void vid_panel_MouseUp(object sender, MouseEventArgs e)
    {
      int index1;
      int index2;
      if (this.checkBoxViewMini.Checked)
      {
        index1 = e.Location.X;
        index2 = e.Location.Y;
      }
      else
      {
        index1 = e.Location.X / 8;
        index2 = e.Location.Y / 8;
      }
      if (this.ActiveTab == 5)
      {
        int num1 = (int) MessageBox.Show("Selected Fog: " + this.listBoxFogs.Items[(int) this.LoadedMap.Fogmap[index2, index1]]);
      }
      if (this.ActiveTab != 2)
        return;
      int index3 = index1 * 2;
      int num2 = (int) this.LoadedMap.Texturemap1[index2 * 2, index3];
      if (num2 < this.LoadedRsc.num_textures)
        this.listTextures.SelectedIndex = num2;
    }

    private void buttonGenTextureBlend_Click(object sender, EventArgs e)
    {
    }

    private void buttonObjExportObj_Click(object sender, EventArgs e)
    {
      if (this.listObjects.SelectedIndex == -1)
        return;
      int num = (int) this.saveCObjObjectDialog.ShowDialog();
    }

    private void saveCObjObjectDialog_FileOk(object sender, CancelEventArgs e)
    {
      if (this.LoadedRsc == null || this.listObjects.SelectedIndex == -1)
        return;
      this.LoadedRsc.Objects[this.listObjects.SelectedIndex].SaveAsObj(this.saveCObjObjectDialog.FileName);
    }

    private void listBoxWaters_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.LoadedRsc == null || this.listBoxWaters.SelectedIndex == -1)
        return;
      this.comboBoxWaterTextureIndex.SelectedIndex = this.LoadedRsc.Waters[this.listBoxWaters.SelectedIndex].texture_index;
      this.pictureBoxWaterPreview.BackgroundImage = (Image) this.LoadedRsc.Texture_Bitmaps[this.comboBoxWaterTextureIndex.SelectedIndex];
      this.trackBarWaterHeight.Value = this.LoadedRsc.Waters[this.listBoxWaters.SelectedIndex].water_level;
      this.labelWaterHeight.Text = "Height: " + this.trackBarWaterHeight.Value.ToString();
      this.trackBarWaterTransp.Value = (int) ((double) this.LoadedRsc.Waters[this.listBoxWaters.SelectedIndex].transp / 2.0 * 100.0);
      this.labelWaterTrans.Text = "Opacity: " + ((float) ((double) this.LoadedRsc.Waters[this.listBoxWaters.SelectedIndex].transp / 2.0 * 100.0)).ToString() + "%";
    }

    private void comboBoxWaterTextureIndex_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listBoxWaters.SelectedIndex == -1 || this.comboBoxWaterTextureIndex.SelectedIndex == -1)
        return;
      this.LoadedRsc.Waters[this.listBoxWaters.SelectedIndex].texture_index = this.comboBoxWaterTextureIndex.SelectedIndex;
      this.listBoxWaters_SelectedIndexChanged((object) null, (EventArgs) null);
    }

    private void trackBarWaterHeight_Scroll(object sender, EventArgs e)
    {
    }
  }
}
