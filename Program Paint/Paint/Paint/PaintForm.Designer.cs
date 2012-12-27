namespace Paint
{
    partial class PaintForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.menuPanel = new System.Windows.Forms.ToolStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.paintToolsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colorsBox = new System.Windows.Forms.GroupBox();
            this.colorsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolsBox = new System.Windows.Forms.GroupBox();
            this.toolsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.paintingArea = new System.Windows.Forms.PictureBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.paintToolsTableLayoutPanel.SuspendLayout();
            this.colorsBox.SuspendLayout();
            this.toolsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButtons
            // 
            this.menuPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuButtons";
            this.menuPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPanel.Size = new System.Drawing.Size(647, 25);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Text = "MenuButtons";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.paintToolsTableLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.paintingArea);
            this.splitContainer.Size = new System.Drawing.Size(647, 490);
            this.splitContainer.SplitterDistance = 86;
            this.splitContainer.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.paintToolsTableLayoutPanel.AutoScroll = true;
            this.paintToolsTableLayoutPanel.AutoSize = true;
            this.paintToolsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paintToolsTableLayoutPanel.ColumnCount = 1;
            this.paintToolsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paintToolsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.paintToolsTableLayoutPanel.Controls.Add(this.colorsBox, 0, 0);
            this.paintToolsTableLayoutPanel.Controls.Add(this.toolsBox, 0, 1);
            this.paintToolsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.paintToolsTableLayoutPanel.Name = "tableLayoutPanel1";
            this.paintToolsTableLayoutPanel.RowCount = 2;
            this.paintToolsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.7551F));
            this.paintToolsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.2449F));
            this.paintToolsTableLayoutPanel.Size = new System.Drawing.Size(12, 52);
            this.paintToolsTableLayoutPanel.TabIndex = 0;
            // 
            // colorsBox
            // 
            this.colorsBox.AutoSize = true;
            this.colorsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorsBox.Controls.Add(this.colorsFlowLayoutPanel);
            this.colorsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorsBox.Location = new System.Drawing.Point(3, 3);
            this.colorsBox.Name = "colorsBox";
            this.colorsBox.Size = new System.Drawing.Size(6, 18);
            this.colorsBox.TabIndex = 0;
            this.colorsBox.TabStop = false;
            this.colorsBox.Text = "Colors";
            // 
            // colorsFlowLayoutPanel
            // 
            this.colorsFlowLayoutPanel.AutoSize = true;
            this.colorsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorsFlowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.colorsFlowLayoutPanel.Name = "colorsFlowLayoutPanel";
            this.colorsFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.colorsFlowLayoutPanel.TabIndex = 0;
            // 
            // toolsBox
            // 
            this.toolsBox.AutoSize = true;
            this.toolsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsBox.Controls.Add(this.toolsFlowLayoutPanel);
            this.toolsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsBox.Location = new System.Drawing.Point(3, 27);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(6, 22);
            this.toolsBox.TabIndex = 1;
            this.toolsBox.TabStop = false;
            this.toolsBox.Text = "Tools";
            // 
            // toolsFlowLayoutPanel
            // 
            this.toolsFlowLayoutPanel.AutoSize = true;
            this.toolsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsFlowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.toolsFlowLayoutPanel.Name = "toolsFlowLayoutPanel";
            this.toolsFlowLayoutPanel.Size = new System.Drawing.Size(0, 3);
            this.toolsFlowLayoutPanel.TabIndex = 0;
            // 
            // paintingArea
            // 
            this.paintingArea.BackColor = System.Drawing.Color.White;
            this.paintingArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintingArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.paintingArea.Location = new System.Drawing.Point(3, 0);
            this.paintingArea.Name = "paintingArea";
            this.paintingArea.Size = new System.Drawing.Size(500, 400);
            this.paintingArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paintingArea.TabIndex = 0;
            this.paintingArea.TabStop = false;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(647, 515);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.paintToolsTableLayoutPanel.ResumeLayout(false);
            this.paintToolsTableLayoutPanel.PerformLayout();
            this.colorsBox.ResumeLayout(false);
            this.colorsBox.PerformLayout();
            this.toolsBox.ResumeLayout(false);
            this.toolsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel paintToolsTableLayoutPanel;
        private System.Windows.Forms.GroupBox colorsBox;
        private System.Windows.Forms.FlowLayoutPanel colorsFlowLayoutPanel;
        private System.Windows.Forms.GroupBox toolsBox;
        private System.Windows.Forms.FlowLayoutPanel toolsFlowLayoutPanel;
        private System.Windows.Forms.PictureBox paintingArea;
        private System.Windows.Forms.ToolTip toolTips;
    }
}

