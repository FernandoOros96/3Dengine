namespace _3Dengine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rotateX = new System.Windows.Forms.Button();
            this.rotateY = new System.Windows.Forms.Button();
            this.rotateZ = new System.Windows.Forms.Button();
            this.rotateXYZ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PCT_CANVAS.Location = new System.Drawing.Point(228, 51);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(727, 433);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rotateX
            // 
            this.rotateX.Location = new System.Drawing.Point(68, 101);
            this.rotateX.Name = "rotateX";
            this.rotateX.Size = new System.Drawing.Size(94, 29);
            this.rotateX.TabIndex = 1;
            this.rotateX.Text = "ROTATE X";
            this.rotateX.UseVisualStyleBackColor = true;
            this.rotateX.Click += new System.EventHandler(this.rotateX_Click);
            // 
            // rotateY
            // 
            this.rotateY.Location = new System.Drawing.Point(68, 161);
            this.rotateY.Name = "rotateY";
            this.rotateY.Size = new System.Drawing.Size(94, 29);
            this.rotateY.TabIndex = 2;
            this.rotateY.Text = "ROTATE Y";
            this.rotateY.UseVisualStyleBackColor = true;
            this.rotateY.Click += new System.EventHandler(this.rotateY_Click);
            // 
            // rotateZ
            // 
            this.rotateZ.Location = new System.Drawing.Point(68, 229);
            this.rotateZ.Name = "rotateZ";
            this.rotateZ.Size = new System.Drawing.Size(94, 29);
            this.rotateZ.TabIndex = 3;
            this.rotateZ.Text = "ROTATE Z";
            this.rotateZ.UseVisualStyleBackColor = true;
            this.rotateZ.Click += new System.EventHandler(this.rotateZ_Click);
            // 
            // rotateXYZ
            // 
            this.rotateXYZ.Location = new System.Drawing.Point(68, 295);
            this.rotateXYZ.Name = "rotateXYZ";
            this.rotateXYZ.Size = new System.Drawing.Size(111, 29);
            this.rotateXYZ.TabIndex = 4;
            this.rotateXYZ.Text = "ROTATE XYZ";
            this.rotateXYZ.UseVisualStyleBackColor = true;
            this.rotateXYZ.Click += new System.EventHandler(this.rotateXYZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 589);
            this.Controls.Add(this.rotateXYZ);
            this.Controls.Add(this.rotateZ);
            this.Controls.Add(this.rotateY);
            this.Controls.Add(this.rotateX);
            this.Controls.Add(this.PCT_CANVAS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PCT_CANVAS;
        private System.Windows.Forms.Timer timer1;
        private Button rotateX;
        private Button rotateY;
        private Button rotateZ;
        private Button rotateXYZ;
    }
}