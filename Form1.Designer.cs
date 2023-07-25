namespace BItMyName
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.MultiButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Pozycja_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Default_color_button = new System.Windows.Forms.Button();
            this.Focused_color_button = new System.Windows.Forms.Button();
            this.WriteModeCheck = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ReadMode_Check = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Read_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Play_Anim_Button = new System.Windows.Forms.Button();
            this.Delete_frame_button = new System.Windows.Forms.Button();
            this.Save_frame_button = new System.Windows.Forms.Button();
            this.Next_frame_button = new System.Windows.Forms.Button();
            this.previous_frame_button = new System.Windows.Forms.Button();
            this.Add_Frame_Button = new System.Windows.Forms.Button();
            this.Create_Animation_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 828);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Crate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(178, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "24 BIT";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(89, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "12 BIT";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 726);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "8 BIT";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MultiButton
            // 
            this.MultiButton.Location = new System.Drawing.Point(714, 731);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(75, 23);
            this.MultiButton.TabIndex = 5;
            this.MultiButton.Text = "Calculate";
            this.MultiButton.UseVisualStyleBackColor = true;
            this.MultiButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pozycja_Label,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 854);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(789, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Pozycja_Label
            // 
            this.Pozycja_Label.Name = "Pozycja_Label";
            this.Pozycja_Label.Size = new System.Drawing.Size(53, 17);
            this.Pozycja_Label.Text = "Position:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(550, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(161, 17);
            this.toolStripStatusLabel1.Text = "Made by Marcin Truszczyński";
            // 
            // Default_color_button
            // 
            this.Default_color_button.Location = new System.Drawing.Point(246, 779);
            this.Default_color_button.Name = "Default_color_button";
            this.Default_color_button.Size = new System.Drawing.Size(60, 48);
            this.Default_color_button.TabIndex = 7;
            this.Default_color_button.Text = "Default color";
            this.Default_color_button.UseVisualStyleBackColor = true;
            this.Default_color_button.Click += new System.EventHandler(this.Default_color_button_Click);
            // 
            // Focused_color_button
            // 
            this.Focused_color_button.Location = new System.Drawing.Point(312, 779);
            this.Focused_color_button.Name = "Focused_color_button";
            this.Focused_color_button.Size = new System.Drawing.Size(60, 48);
            this.Focused_color_button.TabIndex = 8;
            this.Focused_color_button.Text = "Focused color";
            this.Focused_color_button.UseVisualStyleBackColor = true;
            this.Focused_color_button.Click += new System.EventHandler(this.Focused_color_button_Click);
            // 
            // WriteModeCheck
            // 
            this.WriteModeCheck.AutoSize = true;
            this.WriteModeCheck.Checked = true;
            this.WriteModeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WriteModeCheck.Location = new System.Drawing.Point(19, 786);
            this.WriteModeCheck.Name = "WriteModeCheck";
            this.WriteModeCheck.Size = new System.Drawing.Size(81, 17);
            this.WriteModeCheck.TabIndex = 9;
            this.WriteModeCheck.Text = "Write Mode";
            this.WriteModeCheck.UseVisualStyleBackColor = true;
            this.WriteModeCheck.CheckedChanged += new System.EventHandler(this.WriteModeCheck_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 828);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Destroy Crate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReadMode_Check
            // 
            this.ReadMode_Check.AutoSize = true;
            this.ReadMode_Check.Location = new System.Drawing.Point(108, 786);
            this.ReadMode_Check.Name = "ReadMode_Check";
            this.ReadMode_Check.Size = new System.Drawing.Size(82, 17);
            this.ReadMode_Check.TabIndex = 11;
            this.ReadMode_Check.Text = "Read Mode";
            this.ReadMode_Check.UseVisualStyleBackColor = true;
            this.ReadMode_Check.CheckedChanged += new System.EventHandler(this.ReadMode_Check_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Read_Button);
            this.groupBox2.Controls.Add(this.Save_Button);
            this.groupBox2.Location = new System.Drawing.Point(620, 798);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // Read_Button
            // 
            this.Read_Button.Location = new System.Drawing.Point(90, 19);
            this.Read_Button.Name = "Read_Button";
            this.Read_Button.Size = new System.Drawing.Size(73, 23);
            this.Read_Button.TabIndex = 1;
            this.Read_Button.Text = "Read";
            this.Read_Button.UseVisualStyleBackColor = true;
            this.Read_Button.Click += new System.EventHandler(this.Read_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(6, 19);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 0;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "BitMyName Files(*.BitMyName)|*.BitMyName|Animation files (*.BitMyAnim)|*.BitMyAni" +
    "m";
            this.openFileDialog1.Title = "Load File";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.Play_Anim_Button);
            this.groupBox3.Controls.Add(this.Delete_frame_button);
            this.groupBox3.Controls.Add(this.Save_frame_button);
            this.groupBox3.Controls.Add(this.Next_frame_button);
            this.groupBox3.Controls.Add(this.previous_frame_button);
            this.groupBox3.Controls.Add(this.Add_Frame_Button);
            this.groupBox3.Controls.Add(this.Create_Animation_Button);
            this.groupBox3.Location = new System.Drawing.Point(390, 731);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 115);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animations";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "500";
            this.textBox1.TextChanged += new System.EventHandler(this._TextChanged);
            // 
            // Play_Anim_Button
            // 
            this.Play_Anim_Button.Location = new System.Drawing.Point(6, 77);
            this.Play_Anim_Button.Name = "Play_Anim_Button";
            this.Play_Anim_Button.Size = new System.Drawing.Size(48, 23);
            this.Play_Anim_Button.TabIndex = 6;
            this.Play_Anim_Button.Text = "Play";
            this.Play_Anim_Button.UseVisualStyleBackColor = true;
            this.Play_Anim_Button.Click += new System.EventHandler(this.Play_Anim_Button_Click);
            // 
            // Delete_frame_button
            // 
            this.Delete_frame_button.Enabled = false;
            this.Delete_frame_button.Location = new System.Drawing.Point(102, 48);
            this.Delete_frame_button.Name = "Delete_frame_button";
            this.Delete_frame_button.Size = new System.Drawing.Size(90, 23);
            this.Delete_frame_button.TabIndex = 5;
            this.Delete_frame_button.Text = "Delete frame";
            this.Delete_frame_button.UseVisualStyleBackColor = true;
            // 
            // Save_frame_button
            // 
            this.Save_frame_button.Enabled = false;
            this.Save_frame_button.Location = new System.Drawing.Point(6, 48);
            this.Save_frame_button.Name = "Save_frame_button";
            this.Save_frame_button.Size = new System.Drawing.Size(90, 23);
            this.Save_frame_button.TabIndex = 4;
            this.Save_frame_button.Text = "Save frame";
            this.Save_frame_button.UseVisualStyleBackColor = true;
            this.Save_frame_button.Click += new System.EventHandler(this.Save_frame_button_Click);
            // 
            // Next_frame_button
            // 
            this.Next_frame_button.Enabled = false;
            this.Next_frame_button.Location = new System.Drawing.Point(153, 86);
            this.Next_frame_button.Name = "Next_frame_button";
            this.Next_frame_button.Size = new System.Drawing.Size(41, 23);
            this.Next_frame_button.TabIndex = 3;
            this.Next_frame_button.Text = ">";
            this.Next_frame_button.UseVisualStyleBackColor = true;
            // 
            // previous_frame_button
            // 
            this.previous_frame_button.Enabled = false;
            this.previous_frame_button.Location = new System.Drawing.Point(112, 86);
            this.previous_frame_button.Name = "previous_frame_button";
            this.previous_frame_button.Size = new System.Drawing.Size(35, 23);
            this.previous_frame_button.TabIndex = 2;
            this.previous_frame_button.Text = "<";
            this.previous_frame_button.UseVisualStyleBackColor = true;
            // 
            // Add_Frame_Button
            // 
            this.Add_Frame_Button.Enabled = false;
            this.Add_Frame_Button.Location = new System.Drawing.Point(102, 19);
            this.Add_Frame_Button.Name = "Add_Frame_Button";
            this.Add_Frame_Button.Size = new System.Drawing.Size(90, 23);
            this.Add_Frame_Button.TabIndex = 1;
            this.Add_Frame_Button.Text = "Add new frame";
            this.Add_Frame_Button.UseVisualStyleBackColor = true;
            this.Add_Frame_Button.Click += new System.EventHandler(this.Add_Frame_Button_Click);
            // 
            // Create_Animation_Button
            // 
            this.Create_Animation_Button.Location = new System.Drawing.Point(6, 19);
            this.Create_Animation_Button.Name = "Create_Animation_Button";
            this.Create_Animation_Button.Size = new System.Drawing.Size(90, 23);
            this.Create_Animation_Button.TabIndex = 0;
            this.Create_Animation_Button.Text = "Create animation";
            this.Create_Animation_Button.UseVisualStyleBackColor = true;
            this.Create_Animation_Button.Click += new System.EventHandler(this.Create_Animation_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(789, 876);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ReadMode_Check);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.WriteModeCheck);
            this.Controls.Add(this.Focused_color_button);
            this.Controls.Add(this.Default_color_button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MultiButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitMyName";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MultiButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Pozycja_Label;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Default_color_button;
        private System.Windows.Forms.Button Focused_color_button;
        private System.Windows.Forms.CheckBox WriteModeCheck;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ReadMode_Check;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Read_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Next_frame_button;
        private System.Windows.Forms.Button previous_frame_button;
        private System.Windows.Forms.Button Add_Frame_Button;
        private System.Windows.Forms.Button Create_Animation_Button;
        private System.Windows.Forms.Button Delete_frame_button;
        private System.Windows.Forms.Button Save_frame_button;
        private System.Windows.Forms.Button Play_Anim_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

