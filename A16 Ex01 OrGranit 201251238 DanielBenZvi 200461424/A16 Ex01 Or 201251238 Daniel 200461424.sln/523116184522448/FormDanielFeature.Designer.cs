namespace _523116184522448
{
    partial class FormDanielFeature
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
            this.labelEventImages = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // labelEventImages
            // 
            this.labelEventImages.AutoSize = true;
            this.labelEventImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEventImages.Location = new System.Drawing.Point(17, 38);
            this.labelEventImages.Name = "labelEventImages";
            this.labelEventImages.Size = new System.Drawing.Size(232, 13);
            this.labelEventImages.TabIndex = 6;
            this.labelEventImages.Text = "Choose an event to see its location on the map.";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 82);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(266, 225);
            this.listBoxEvents.TabIndex = 5;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFetchEvents.Location = new System.Drawing.Point(57, 12);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(163, 23);
            this.buttonFetchEvents.TabIndex = 4;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(284, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 30;
            this.gMapControl1.MinZoom = 1;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = false;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = false;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(315, 295);
            this.gMapControl1.TabIndex = 7;
            this.gMapControl1.Zoom = 0D;
            // 
            // FormDanielFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 326);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.labelEventImages);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonFetchEvents);
            this.Name = "FormDanielFeature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventImages;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}