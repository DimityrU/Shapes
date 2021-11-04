namespace Course_project
{
    partial class Scene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene));
            this.side_a = new System.Windows.Forms.TextBox();
            this.side_b = new System.Windows.Forms.TextBox();
            this.side_c = new System.Windows.Forms.TextBox();
            this.rectangleBox = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Area = new System.Windows.Forms.ToolStripStatusLabel();
            this.Perimeter = new System.Windows.Forms.ToolStripStatusLabel();
            this.squareBox = new System.Windows.Forms.RadioButton();
            this.triangleBox = new System.Windows.Forms.RadioButton();
            this.circleBox = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // side_a
            // 
            this.side_a.Location = new System.Drawing.Point(51, 317);
            this.side_a.Name = "side_a";
            this.side_a.ReadOnly = true;
            this.side_a.Size = new System.Drawing.Size(100, 22);
            this.side_a.TabIndex = 0;
            this.side_a.TextChanged += new System.EventHandler(this.side_a_TextChanged);
            // 
            // side_b
            // 
            this.side_b.Location = new System.Drawing.Point(51, 355);
            this.side_b.Name = "side_b";
            this.side_b.ReadOnly = true;
            this.side_b.Size = new System.Drawing.Size(100, 22);
            this.side_b.TabIndex = 1;
            this.side_b.TextChanged += new System.EventHandler(this.side_b_TextChanged);
            // 
            // side_c
            // 
            this.side_c.Location = new System.Drawing.Point(51, 394);
            this.side_c.Name = "side_c";
            this.side_c.ReadOnly = true;
            this.side_c.Size = new System.Drawing.Size(100, 22);
            this.side_c.TabIndex = 2;
            this.side_c.TextChanged += new System.EventHandler(this.side_c_TextChanged);
            // 
            // rectangleBox
            // 
            this.rectangleBox.AutoSize = true;
            this.rectangleBox.BackColor = System.Drawing.Color.Transparent;
            this.rectangleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectangleBox.Location = new System.Drawing.Point(19, 101);
            this.rectangleBox.Name = "rectangleBox";
            this.rectangleBox.Size = new System.Drawing.Size(105, 24);
            this.rectangleBox.TabIndex = 6;
            this.rectangleBox.TabStop = true;
            this.rectangleBox.Text = "Rectangle";
            this.rectangleBox.UseVisualStyleBackColor = false;
            this.rectangleBox.CheckedChanged += new System.EventHandler(this.rectangleBox_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Area,
            this.Perimeter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(947, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Area
            // 
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(0, 16);
            // 
            // Perimeter
            // 
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(0, 16);
            // 
            // squareBox
            // 
            this.squareBox.AutoSize = true;
            this.squareBox.BackColor = System.Drawing.Color.Transparent;
            this.squareBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareBox.Location = new System.Drawing.Point(17, 140);
            this.squareBox.Name = "squareBox";
            this.squareBox.Size = new System.Drawing.Size(83, 24);
            this.squareBox.TabIndex = 8;
            this.squareBox.TabStop = true;
            this.squareBox.Text = "Square";
            this.squareBox.UseVisualStyleBackColor = false;
            this.squareBox.CheckedChanged += new System.EventHandler(this.squareBox_CheckedChanged);
            // 
            // triangleBox
            // 
            this.triangleBox.AutoSize = true;
            this.triangleBox.BackColor = System.Drawing.Color.Transparent;
            this.triangleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.triangleBox.Location = new System.Drawing.Point(17, 180);
            this.triangleBox.Name = "triangleBox";
            this.triangleBox.Size = new System.Drawing.Size(90, 24);
            this.triangleBox.TabIndex = 9;
            this.triangleBox.TabStop = true;
            this.triangleBox.Text = "Triangle";
            this.triangleBox.UseVisualStyleBackColor = false;
            this.triangleBox.CheckedChanged += new System.EventHandler(this.triangleBox_CheckedChanged);
            // 
            // circleBox
            // 
            this.circleBox.AutoSize = true;
            this.circleBox.BackColor = System.Drawing.Color.Transparent;
            this.circleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleBox.Location = new System.Drawing.Point(17, 219);
            this.circleBox.Name = "circleBox";
            this.circleBox.Size = new System.Drawing.Size(74, 24);
            this.circleBox.TabIndex = 10;
            this.circleBox.TabStop = true;
            this.circleBox.Text = "Circle";
            this.circleBox.UseVisualStyleBackColor = false;
            this.circleBox.CheckedChanged += new System.EventHandler(this.circleBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose a figure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose sizes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "C =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "B = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "A = ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(947, 31);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "ToolBar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Information";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(405, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(530, 489);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(327, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(146, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "Visualization";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(947, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circleBox);
            this.Controls.Add(this.triangleBox);
            this.Controls.Add(this.squareBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rectangleBox);
            this.Controls.Add(this.side_c);
            this.Controls.Add(this.side_b);
            this.Controls.Add(this.side_a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Scene";
            this.Text = "Figures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scene_FormClosing);
            this.Load += new System.EventHandler(this.Scene_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scene_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox side_a;
        private System.Windows.Forms.TextBox side_b;
        private System.Windows.Forms.TextBox side_c;
        private System.Windows.Forms.RadioButton rectangleBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Area;
        private System.Windows.Forms.RadioButton squareBox;
        private System.Windows.Forms.RadioButton triangleBox;
        private System.Windows.Forms.RadioButton circleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel Perimeter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

