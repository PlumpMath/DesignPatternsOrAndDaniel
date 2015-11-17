namespace _523116184522448
{
    partial class EventImagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventImagesForm));
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.imageListEventImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonFetchEvents
            // 
            resources.ApplyResources(this.buttonFetchEvents, "buttonFetchEvents");
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxEvents, "listBoxEvents");
            this.listBoxEvents.Name = "listBoxEvents";
            // 
            // listView
            // 
            this.listView.LargeImageList = this.imageListEventImages;
            resources.ApplyResources(this.listView, "listView");
            this.listView.Name = "listView";
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // imageListEventImages
            // 
            this.imageListEventImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageListEventImages, "imageListEventImages");
            this.imageListEventImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EventImagesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonFetchEvents);
            this.Name = "EventImagesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageListEventImages;
    }
}