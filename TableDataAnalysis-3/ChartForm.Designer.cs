
namespace TableDataAnalysis
{
    partial class ChartForm
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
            this.ScrollBar = new System.Windows.Forms.HScrollBar();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.Canvas = new System.Windows.Forms.Panel();
            this.LabelScaleX = new System.Windows.Forms.Label();
            this.NumericUpDownColumnWidth = new System.Windows.Forms.NumericUpDown();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumnWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollBar
            // 
            this.ScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ScrollBar.Location = new System.Drawing.Point(0, 587);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(1026, 17);
            this.ScrollBar.TabIndex = 0;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1026, 28);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "Меню";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemExport});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 24);
            this.MenuItemFile.Text = "Файл";
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.Size = new System.Drawing.Size(206, 22);
            this.MenuItemFileOpen.Text = "Открыть график";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.Size = new System.Drawing.Size(206, 22);
            this.MenuItemFileSave.Text = "Сохранить график";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemExport
            // 
            this.MenuItemExport.Name = "MenuItemExport";
            this.MenuItemExport.Size = new System.Drawing.Size(206, 22);
            this.MenuItemExport.Text = "Экспортировать график";
            this.MenuItemExport.Click += new System.EventHandler(this.MenuItemExport_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 28);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1026, 559);
            this.Canvas.TabIndex = 2;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            this.Canvas.Resize += new System.EventHandler(this.Canvas_Resize);
            // 
            // LabelScaleX
            // 
            this.LabelScaleX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelScaleX.AutoSize = true;
            this.LabelScaleX.Location = new System.Drawing.Point(904, 4);
            this.LabelScaleX.Name = "LabelScaleX";
            this.LabelScaleX.Size = new System.Drawing.Size(48, 15);
            this.LabelScaleX.TabIndex = 4;
            this.LabelScaleX.Text = "Scale X:";
            // 
            // NumericUpDownColumnWidth
            // 
            this.NumericUpDownColumnWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDownColumnWidth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NumericUpDownColumnWidth.Location = new System.Drawing.Point(958, 2);
            this.NumericUpDownColumnWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDownColumnWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownColumnWidth.Name = "NumericUpDownColumnWidth";
            this.NumericUpDownColumnWidth.Size = new System.Drawing.Size(56, 23);
            this.NumericUpDownColumnWidth.TabIndex = 3;
            this.NumericUpDownColumnWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownColumnWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownColumnWidth.ValueChanged += new System.EventHandler(this.NumericUpDownColumnWidth_ValueChanged);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 604);
            this.Controls.Add(this.LabelScaleX);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.NumericUpDownColumnWidth);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "ChartForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumnWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar ScrollBar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.NumericUpDown NumericUpDownColumnWidth;
        private System.Windows.Forms.Label LabelScaleX;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExport;
    }
}