namespace PaintDonGian
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.panelControl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnRightColor = new System.Windows.Forms.Button();
            this.btnLeftColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpDownArrow = new System.Windows.Forms.Button();
            this.btnLeftRightArrow = new System.Windows.Forms.Button();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnDrawTriangular = new System.Windows.Forms.Button();
            this.btnDrawElipse = new System.Windows.Forms.Button();
            this.btnDrawRectangle = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.lbMouse = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRedo = new PaintDonGian.CircularButton();
            this.btnUndo = new PaintDonGian.CircularButton();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.AutoScroll = true;
            this.panelControl.BackColor = System.Drawing.Color.Silver;
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControl.Controls.Add(this.btnRedo);
            this.panelControl.Controls.Add(this.btnUndo);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Controls.Add(this.cbSize);
            this.panelControl.Controls.Add(this.btnColor);
            this.panelControl.Controls.Add(this.btnRightColor);
            this.panelControl.Controls.Add(this.btnLeftColor);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.panel2);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelControl.Location = new System.Drawing.Point(0, 24);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(838, 99);
            this.panelControl.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(658, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Shape Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(565, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pen Color";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnPen);
            this.panel1.Location = new System.Drawing.Point(387, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 67);
            this.panel1.TabIndex = 8;
            // 
            // btnEraser
            // 
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.Location = new System.Drawing.Point(58, 3);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(35, 36);
            this.btnEraser.TabIndex = 1;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPen
            // 
            this.btnPen.Image = ((System.Drawing.Image)(resources.GetObject("btnPen.Image")));
            this.btnPen.Location = new System.Drawing.Point(3, 2);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(49, 42);
            this.btnPen.TabIndex = 0;
            this.btnPen.Text = "e";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(224, 27);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 7;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.Location = new System.Drawing.Point(760, 10);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(47, 49);
            this.btnColor.TabIndex = 6;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnRightColor
            // 
            this.btnRightColor.BackColor = System.Drawing.Color.Red;
            this.btnRightColor.Location = new System.Drawing.Point(659, 15);
            this.btnRightColor.Name = "btnRightColor";
            this.btnRightColor.Size = new System.Drawing.Size(73, 39);
            this.btnRightColor.TabIndex = 5;
            this.btnRightColor.UseVisualStyleBackColor = false;
            this.btnRightColor.Click += new System.EventHandler(this.btnRightColor_Click);
            // 
            // btnLeftColor
            // 
            this.btnLeftColor.BackColor = System.Drawing.Color.Black;
            this.btnLeftColor.Location = new System.Drawing.Point(568, 15);
            this.btnLeftColor.Name = "btnLeftColor";
            this.btnLeftColor.Size = new System.Drawing.Size(75, 39);
            this.btnLeftColor.TabIndex = 4;
            this.btnLeftColor.UseVisualStyleBackColor = false;
            this.btnLeftColor.Click += new System.EventHandler(this.btnLeftColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(221, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnUpDownArrow);
            this.panel2.Controls.Add(this.btnLeftRightArrow);
            this.panel2.Controls.Add(this.btnHexagon);
            this.panel2.Controls.Add(this.btnDrawTriangular);
            this.panel2.Controls.Add(this.btnDrawElipse);
            this.panel2.Controls.Add(this.btnDrawRectangle);
            this.panel2.Controls.Add(this.btnDrawLine);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 80);
            this.panel2.TabIndex = 0;
            // 
            // btnUpDownArrow
            // 
            this.btnUpDownArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnUpDownArrow.Image")));
            this.btnUpDownArrow.Location = new System.Drawing.Point(46, 40);
            this.btnUpDownArrow.Name = "btnUpDownArrow";
            this.btnUpDownArrow.Size = new System.Drawing.Size(33, 38);
            this.btnUpDownArrow.TabIndex = 7;
            this.btnUpDownArrow.UseVisualStyleBackColor = true;
            this.btnUpDownArrow.Click += new System.EventHandler(this.btnUpDownArrow_Click);
            // 
            // btnLeftRightArrow
            // 
            this.btnLeftRightArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftRightArrow.Image")));
            this.btnLeftRightArrow.Location = new System.Drawing.Point(85, 40);
            this.btnLeftRightArrow.Name = "btnLeftRightArrow";
            this.btnLeftRightArrow.Size = new System.Drawing.Size(35, 38);
            this.btnLeftRightArrow.TabIndex = 6;
            this.btnLeftRightArrow.UseVisualStyleBackColor = true;
            this.btnLeftRightArrow.Click += new System.EventHandler(this.btnLeftRightArrow_Click);
            // 
            // btnHexagon
            // 
            this.btnHexagon.Image = ((System.Drawing.Image)(resources.GetObject("btnHexagon.Image")));
            this.btnHexagon.Location = new System.Drawing.Point(3, 40);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(35, 38);
            this.btnHexagon.TabIndex = 4;
            this.btnHexagon.UseVisualStyleBackColor = true;
            this.btnHexagon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnDrawTriangular
            // 
            this.btnDrawTriangular.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawTriangular.Image")));
            this.btnDrawTriangular.Location = new System.Drawing.Point(126, 3);
            this.btnDrawTriangular.Name = "btnDrawTriangular";
            this.btnDrawTriangular.Size = new System.Drawing.Size(33, 34);
            this.btnDrawTriangular.TabIndex = 3;
            this.btnDrawTriangular.UseVisualStyleBackColor = true;
            this.btnDrawTriangular.Click += new System.EventHandler(this.btnDrawPolygon_Click);
            // 
            // btnDrawElipse
            // 
            this.btnDrawElipse.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawElipse.Image")));
            this.btnDrawElipse.Location = new System.Drawing.Point(85, 3);
            this.btnDrawElipse.Name = "btnDrawElipse";
            this.btnDrawElipse.Size = new System.Drawing.Size(35, 34);
            this.btnDrawElipse.TabIndex = 2;
            this.btnDrawElipse.UseVisualStyleBackColor = true;
            this.btnDrawElipse.Click += new System.EventHandler(this.btnDrawElipse_Click);
            // 
            // btnDrawRectangle
            // 
            this.btnDrawRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawRectangle.Image")));
            this.btnDrawRectangle.Location = new System.Drawing.Point(44, 3);
            this.btnDrawRectangle.Name = "btnDrawRectangle";
            this.btnDrawRectangle.Size = new System.Drawing.Size(35, 34);
            this.btnDrawRectangle.TabIndex = 1;
            this.btnDrawRectangle.UseVisualStyleBackColor = true;
            this.btnDrawRectangle.Click += new System.EventHandler(this.btnDrawRectangle_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawLine.Image")));
            this.btnDrawLine.Location = new System.Drawing.Point(3, 3);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(35, 34);
            this.btnDrawLine.TabIndex = 0;
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.Silver;
            this.panelBot.Controls.Add(this.lbMouse);
            this.panelBot.Controls.Add(this.lbLocation);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 511);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(838, 27);
            this.panelBot.TabIndex = 1;
            // 
            // lbMouse
            // 
            this.lbMouse.AutoSize = true;
            this.lbMouse.BackColor = System.Drawing.Color.Silver;
            this.lbMouse.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMouse.ForeColor = System.Drawing.Color.Snow;
            this.lbMouse.Location = new System.Drawing.Point(3, 6);
            this.lbMouse.Name = "lbMouse";
            this.lbMouse.Size = new System.Drawing.Size(0, 18);
            this.lbMouse.TabIndex = 1;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.White;
            this.lbLocation.Location = new System.Drawing.Point(3, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(0, 13);
            this.lbLocation.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Open";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.White;
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.Location = new System.Drawing.Point(293, 49);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(52, 43);
            this.btnRedo.TabIndex = 12;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.White;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(224, 48);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(50, 44);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Paint
            // 
            this.AcceptButton = this.btnPen;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(838, 538);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            this.Resize += new System.EventHandler(this.Paint_Resize);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.panelBot.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnRightColor;
        private System.Windows.Forms.Button btnLeftColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDrawTriangular;
        private System.Windows.Forms.Button btnDrawElipse;
        private System.Windows.Forms.Button btnDrawRectangle;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Label lbMouse;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.Button btnLeftRightArrow;
        private System.Windows.Forms.Button btnUpDownArrow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CircularButton btnRedo;
        private CircularButton btnUndo;
    }
}

