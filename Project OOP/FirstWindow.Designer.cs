/*
 * Robert O'Brien
 * CMPS-5113-101
 * November 15, 2022
 */
using System.Windows.Forms;

namespace Project_OOP
{
    /*
     * Class name: FirstWindow
     * Process: Displays the main windows that display the all the functionality
     *          of the password generator. 
     */
    partial class FirstWindow
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
            this.Uppercase_Check_Box = new System.Windows.Forms.CheckBox();
            this.Lowercase_Check_Box = new System.Windows.Forms.CheckBox();
            this.Numbers_Check_Box = new System.Windows.Forms.CheckBox();
            this.Symbols_Check_Box = new System.Windows.Forms.CheckBox();
            this.Password_Text_Box = new System.Windows.Forms.TextBox();
            this.Password_Length_Slider = new System.Windows.Forms.TrackBar();
            this.Password_Length_Text_Box = new System.Windows.Forms.TextBox();
            this.Toolbar_Strip = new System.Windows.Forms.MenuStrip();
            this.Help_Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.Tutorial_Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.About_Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Copy_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Password_Length_Slider)).BeginInit();
            this.Toolbar_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uppercase_Check_Box
            // 
            this.Uppercase_Check_Box.AutoSize = true;
            this.Uppercase_Check_Box.Checked = true;
            this.Uppercase_Check_Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Uppercase_Check_Box.Location = new System.Drawing.Point(535, 70);
            this.Uppercase_Check_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Uppercase_Check_Box.Name = "Uppercase_Check_Box";
            this.Uppercase_Check_Box.Size = new System.Drawing.Size(78, 17);
            this.Uppercase_Check_Box.TabIndex = 0;
            this.Uppercase_Check_Box.Text = "Uppercase";
            this.Uppercase_Check_Box.UseVisualStyleBackColor = true;
            // 
            // Lowercase_Check_Box
            // 
            this.Lowercase_Check_Box.AutoSize = true;
            this.Lowercase_Check_Box.Checked = true;
            this.Lowercase_Check_Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lowercase_Check_Box.Location = new System.Drawing.Point(535, 91);
            this.Lowercase_Check_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Lowercase_Check_Box.Name = "Lowercase_Check_Box";
            this.Lowercase_Check_Box.Size = new System.Drawing.Size(78, 17);
            this.Lowercase_Check_Box.TabIndex = 1;
            this.Lowercase_Check_Box.Text = "Lowercase";
            this.Lowercase_Check_Box.UseVisualStyleBackColor = true;
            // 
            // Numbers_Check_Box
            // 
            this.Numbers_Check_Box.AutoSize = true;
            this.Numbers_Check_Box.Checked = true;
            this.Numbers_Check_Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Numbers_Check_Box.Location = new System.Drawing.Point(535, 112);
            this.Numbers_Check_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Numbers_Check_Box.Name = "Numbers_Check_Box";
            this.Numbers_Check_Box.Size = new System.Drawing.Size(68, 17);
            this.Numbers_Check_Box.TabIndex = 2;
            this.Numbers_Check_Box.Text = "Numbers";
            this.Numbers_Check_Box.UseVisualStyleBackColor = true;
            // 
            // Symbols_Check_Box
            // 
            this.Symbols_Check_Box.AutoSize = true;
            this.Symbols_Check_Box.Checked = true;
            this.Symbols_Check_Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Symbols_Check_Box.Location = new System.Drawing.Point(535, 132);
            this.Symbols_Check_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Symbols_Check_Box.Name = "Symbols_Check_Box";
            this.Symbols_Check_Box.Size = new System.Drawing.Size(65, 17);
            this.Symbols_Check_Box.TabIndex = 3;
            this.Symbols_Check_Box.Text = "Symbols";
            this.Symbols_Check_Box.UseVisualStyleBackColor = true;
            // 
            // Password_Text_Box
            // 
            this.Password_Text_Box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text_Box.Location = new System.Drawing.Point(11, 70);
            this.Password_Text_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Password_Text_Box.Name = "Password_Text_Box";
            this.Password_Text_Box.Size = new System.Drawing.Size(501, 26);
            this.Password_Text_Box.TabIndex = 4;
            // 
            // Password_Length_Slider
            // 
            this.Password_Length_Slider.BackColor = System.Drawing.SystemColors.Control;
            this.Password_Length_Slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.Password_Length_Slider.Location = new System.Drawing.Point(11, 112);
            this.Password_Length_Slider.Margin = new System.Windows.Forms.Padding(2);
            this.Password_Length_Slider.Maximum = 256;
            this.Password_Length_Slider.Minimum = 1;
            this.Password_Length_Slider.Name = "Password_Length_Slider";
            this.Password_Length_Slider.Size = new System.Drawing.Size(456, 45);
            this.Password_Length_Slider.TabIndex = 6;
            this.Password_Length_Slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Password_Length_Slider.Value = 1;
            this.Password_Length_Slider.Scroll += new System.EventHandler(this.Password_Length_Slider_Scroll);
            // 
            // Password_Length_Text_Box
            // 
            this.Password_Length_Text_Box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Length_Text_Box.Location = new System.Drawing.Point(469, 112);
            this.Password_Length_Text_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Password_Length_Text_Box.MaxLength = 3;
            this.Password_Length_Text_Box.Multiline = true;
            this.Password_Length_Text_Box.Name = "Password_Length_Text_Box";
            this.Password_Length_Text_Box.Size = new System.Drawing.Size(43, 26);
            this.Password_Length_Text_Box.TabIndex = 7;
            this.Password_Length_Text_Box.Text = "1";
            this.Password_Length_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_Length_Text_Box.TextChanged += new System.EventHandler(this.Password_Length_Text_Box_TextChanged);
            this.Password_Length_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_Length_Text_Box_KeyPress);
            // 
            // Toolbar_Strip
            // 
            this.Toolbar_Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Toolbar_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_Strip});
            this.Toolbar_Strip.Location = new System.Drawing.Point(0, 0);
            this.Toolbar_Strip.Name = "Toolbar_Strip";
            this.Toolbar_Strip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Toolbar_Strip.Size = new System.Drawing.Size(634, 24);
            this.Toolbar_Strip.TabIndex = 8;
            this.Toolbar_Strip.Text = "menuStrip1";
            // 
            // Help_Strip
            // 
            this.Help_Strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tutorial_Strip,
            this.About_Strip});
            this.Help_Strip.Name = "Help_Strip";
            this.Help_Strip.Size = new System.Drawing.Size(44, 20);
            this.Help_Strip.Text = "Help";
            // 
            // Tutorial_Strip
            // 
            this.Tutorial_Strip.Name = "Tutorial_Strip";
            this.Tutorial_Strip.Size = new System.Drawing.Size(180, 22);
            this.Tutorial_Strip.Text = "Credits";
            this.Tutorial_Strip.Click += new System.EventHandler(this.Tutorial_Strip_Click);
            // 
            // About_Strip
            // 
            this.About_Strip.Name = "About_Strip";
            this.About_Strip.Size = new System.Drawing.Size(180, 22);
            this.About_Strip.Text = "About";
            this.About_Strip.Click += new System.EventHandler(this.About_Strip_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(207, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 16);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Password Length";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Copy_Button
            // 
            this.Copy_Button.BackColor = System.Drawing.Color.Blue;
            this.Copy_Button.Image = global::Project_OOP.Properties.Resources.Clipboard;
            this.Copy_Button.Location = new System.Drawing.Point(427, 25);
            this.Copy_Button.Name = "Copy_Button";
            this.Copy_Button.Size = new System.Drawing.Size(40, 40);
            this.Copy_Button.TabIndex = 10;
            this.Copy_Button.UseVisualStyleBackColor = false;
            this.Copy_Button.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Refresh_Button.Image = global::Project_OOP.Properties.Resources.Refresh;
            this.Refresh_Button.Location = new System.Drawing.Point(473, 25);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(40, 40);
            this.Refresh_Button.TabIndex = 11;
            this.Refresh_Button.UseVisualStyleBackColor = false;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 161);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Copy_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password_Length_Text_Box);
            this.Controls.Add(this.Password_Length_Slider);
            this.Controls.Add(this.Password_Text_Box);
            this.Controls.Add(this.Symbols_Check_Box);
            this.Controls.Add(this.Numbers_Check_Box);
            this.Controls.Add(this.Lowercase_Check_Box);
            this.Controls.Add(this.Uppercase_Check_Box);
            this.Controls.Add(this.Toolbar_Strip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FirstWindow";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.Password_Length_Slider)).EndInit();
            this.Toolbar_Strip.ResumeLayout(false);
            this.Toolbar_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Uppercase_Check_Box;
        private System.Windows.Forms.CheckBox Lowercase_Check_Box;
        private System.Windows.Forms.CheckBox Numbers_Check_Box;
        private System.Windows.Forms.CheckBox Symbols_Check_Box;
        private System.Windows.Forms.TextBox Password_Text_Box;
        private TrackBar Password_Length_Slider;
        private TextBox Password_Length_Text_Box;
        private MenuStrip Toolbar_Strip;
        private ToolStripMenuItem Help_Strip;
        private ToolStripMenuItem Tutorial_Strip;
        private ToolStripMenuItem About_Strip;
        private TextBox textBox1;
        private Button Copy_Button;
        private Button Refresh_Button;
    }
}