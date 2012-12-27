using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();

            PaintFormParameters();

            FormManager formManager = new FormManager(this);

            formManager.Start();
        }

        private void PaintFormParameters()
        {
            WindowState = FormWindowState.Maximized;

            PaintingArea.Image = new Bitmap(1000, 1000);

            paintToolsTableLayoutPanel.MaximumSize = new Size(splitContainer.Panel1.Width, 0);
            colorsBox.MaximumSize = new Size(splitContainer.Panel1.Width, 0);
            colorsFlowLayoutPanel.MaximumSize = new Size(splitContainer.Panel1.Width, 0);
            toolsBox.MaximumSize = new Size(splitContainer.Panel1.Width, 0);
            toolsFlowLayoutPanel.MaximumSize = new Size(splitContainer.Panel1.Width, 0);
        }

        public ToolStrip MenuPanel
        {
            get
            {
                return menuPanel;
            }
        }

        public FlowLayoutPanel ColorsPanel
        {
            get
            {
                return colorsFlowLayoutPanel;
            }
        }

        public FlowLayoutPanel ToolsPanel
        {
            get
            {
                return toolsFlowLayoutPanel;
            }
        }

        public PictureBox PaintingArea
        {
            get
            {
                return paintingArea;
            }
        }

        public ToolTip ToolTips
        {
            get
            {
                return toolTips;
            }
        }
    }
}
