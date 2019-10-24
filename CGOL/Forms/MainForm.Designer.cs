namespace CGOL.Forms
{
    partial class MainForm
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
            this.ViewPortGUI = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.FillGUIGroup = new System.Windows.Forms.GroupBox();
            this.FillButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FillPrecent = new System.Windows.Forms.TrackBar();
            this.WorldSizeGUIGroup = new System.Windows.Forms.GroupBox();
            this.WorldSizeYGUI = new System.Windows.Forms.NumericUpDown();
            this.WorldSizeXGUI = new System.Windows.Forms.NumericUpDown();
            this.CellSizeGUIGroup = new System.Windows.Forms.GroupBox();
            this.CellSizeGui = new System.Windows.Forms.NumericUpDown();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPortGUI)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.FillGUIGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillPrecent)).BeginInit();
            this.WorldSizeGUIGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorldSizeYGUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldSizeXGUI)).BeginInit();
            this.CellSizeGUIGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeGui)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPortGUI
            // 
            this.ViewPortGUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewPortGUI.BackColor = System.Drawing.Color.Aqua;
            this.ViewPortGUI.Location = new System.Drawing.Point(171, 12);
            this.ViewPortGUI.Margin = new System.Windows.Forms.Padding(0);
            this.ViewPortGUI.Name = "ViewPortGUI";
            this.ViewPortGUI.Size = new System.Drawing.Size(434, 483);
            this.ViewPortGUI.TabIndex = 0;
            this.ViewPortGUI.TabStop = false;
            this.ViewPortGUI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.ViewPortGUI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.ViewPortGUI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ControlPanel.Controls.Add(this.FillGUIGroup);
            this.ControlPanel.Controls.Add(this.WorldSizeGUIGroup);
            this.ControlPanel.Controls.Add(this.CellSizeGUIGroup);
            this.ControlPanel.Controls.Add(this.PlayButton);
            this.ControlPanel.Location = new System.Drawing.Point(12, 12);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(150, 483);
            this.ControlPanel.TabIndex = 1;
            // 
            // FillGUIGroup
            // 
            this.FillGUIGroup.Controls.Add(this.FillButton);
            this.FillGUIGroup.Controls.Add(this.ClearButton);
            this.FillGUIGroup.Controls.Add(this.FillPrecent);
            this.FillGUIGroup.Location = new System.Drawing.Point(9, 136);
            this.FillGUIGroup.Name = "FillGUIGroup";
            this.FillGUIGroup.Size = new System.Drawing.Size(138, 100);
            this.FillGUIGroup.TabIndex = 5;
            this.FillGUIGroup.TabStop = false;
            this.FillGUIGroup.Text = "Fill";
            // 
            // FillButton
            // 
            this.FillButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FillButton.Location = new System.Drawing.Point(82, 71);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(50, 23);
            this.FillButton.TabIndex = 5;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(26, 71);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(50, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FillPrecent
            // 
            this.FillPrecent.CausesValidation = false;
            this.FillPrecent.Location = new System.Drawing.Point(3, 16);
            this.FillPrecent.Maximum = 100;
            this.FillPrecent.Minimum = 1;
            this.FillPrecent.Name = "FillPrecent";
            this.FillPrecent.Size = new System.Drawing.Size(129, 45);
            this.FillPrecent.TabIndex = 0;
            this.FillPrecent.TickFrequency = 5;
            this.FillPrecent.Value = 20;
            // 
            // WorldSizeGUIGroup
            // 
            this.WorldSizeGUIGroup.Controls.Add(this.WorldSizeYGUI);
            this.WorldSizeGUIGroup.Controls.Add(this.WorldSizeXGUI);
            this.WorldSizeGUIGroup.Location = new System.Drawing.Point(3, 55);
            this.WorldSizeGUIGroup.Name = "WorldSizeGUIGroup";
            this.WorldSizeGUIGroup.Size = new System.Drawing.Size(144, 72);
            this.WorldSizeGUIGroup.TabIndex = 1;
            this.WorldSizeGUIGroup.TabStop = false;
            this.WorldSizeGUIGroup.Text = "World Size";
            // 
            // WorldSizeYGUI
            // 
            this.WorldSizeYGUI.Location = new System.Drawing.Point(6, 45);
            this.WorldSizeYGUI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.WorldSizeYGUI.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WorldSizeYGUI.Name = "WorldSizeYGUI";
            this.WorldSizeYGUI.Size = new System.Drawing.Size(132, 20);
            this.WorldSizeYGUI.TabIndex = 1;
            this.WorldSizeYGUI.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.WorldSizeYGUI.ValueChanged += new System.EventHandler(this.WorldSizeChanged);
            // 
            // WorldSizeXGUI
            // 
            this.WorldSizeXGUI.Location = new System.Drawing.Point(6, 19);
            this.WorldSizeXGUI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.WorldSizeXGUI.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WorldSizeXGUI.Name = "WorldSizeXGUI";
            this.WorldSizeXGUI.Size = new System.Drawing.Size(132, 20);
            this.WorldSizeXGUI.TabIndex = 0;
            this.WorldSizeXGUI.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.WorldSizeXGUI.ValueChanged += new System.EventHandler(this.WorldSizeChanged);
            // 
            // CellSizeGUIGroup
            // 
            this.CellSizeGUIGroup.Controls.Add(this.CellSizeGui);
            this.CellSizeGUIGroup.Location = new System.Drawing.Point(3, 3);
            this.CellSizeGUIGroup.Name = "CellSizeGUIGroup";
            this.CellSizeGUIGroup.Size = new System.Drawing.Size(144, 46);
            this.CellSizeGUIGroup.TabIndex = 3;
            this.CellSizeGUIGroup.TabStop = false;
            this.CellSizeGUIGroup.Text = "Cell Size";
            // 
            // CellSizeGui
            // 
            this.CellSizeGui.AllowDrop = true;
            this.CellSizeGui.Location = new System.Drawing.Point(6, 19);
            this.CellSizeGui.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CellSizeGui.Name = "CellSizeGui";
            this.CellSizeGui.Size = new System.Drawing.Size(132, 20);
            this.CellSizeGui.TabIndex = 2;
            this.CellSizeGui.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CellSizeGui.ValueChanged += new System.EventHandler(this.ResizeCell);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayButton.Location = new System.Drawing.Point(3, 457);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(144, 23);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayAsync);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 507);
            this.Controls.Add(this.ViewPortGUI);
            this.Controls.Add(this.ControlPanel);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.Text = "Conway\'s Game Of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPortGUI)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.FillGUIGroup.ResumeLayout(false);
            this.FillGUIGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillPrecent)).EndInit();
            this.WorldSizeGUIGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorldSizeYGUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldSizeXGUI)).EndInit();
            this.CellSizeGUIGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeGui)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ViewPortGUI;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.NumericUpDown CellSizeGui;
        private System.Windows.Forms.GroupBox CellSizeGUIGroup;
        private System.Windows.Forms.GroupBox WorldSizeGUIGroup;
        private System.Windows.Forms.NumericUpDown WorldSizeYGUI;
        private System.Windows.Forms.NumericUpDown WorldSizeXGUI;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox FillGUIGroup;
        private System.Windows.Forms.TrackBar FillPrecent;
        private System.Windows.Forms.Button FillButton;
    }
}

