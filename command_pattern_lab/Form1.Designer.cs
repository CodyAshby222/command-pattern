
namespace command_pattern_lab
{
    partial class Command_Form
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
            this.Up_Btn = new System.Windows.Forms.Button();
            this.Left_Btn = new System.Windows.Forms.Button();
            this.Right_Btn = new System.Windows.Forms.Button();
            this.Down_Btn = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.PictureBox();
            this.Red_Btn = new System.Windows.Forms.Button();
            this.Green_Btn = new System.Windows.Forms.Button();
            this.Blue_Btn = new System.Windows.Forms.Button();
            this.Undo_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            this.SuspendLayout();
            // 
            // Up_Btn
            // 
            this.Up_Btn.Location = new System.Drawing.Point(63, 22);
            this.Up_Btn.Name = "Up_Btn";
            this.Up_Btn.Size = new System.Drawing.Size(45, 35);
            this.Up_Btn.TabIndex = 0;
            this.Up_Btn.Text = "Up";
            this.Up_Btn.UseVisualStyleBackColor = true;
            this.Up_Btn.Click += new System.EventHandler(this.Up_Btn_Click);
            // 
            // Left_Btn
            // 
            this.Left_Btn.Location = new System.Drawing.Point(12, 63);
            this.Left_Btn.Name = "Left_Btn";
            this.Left_Btn.Size = new System.Drawing.Size(45, 35);
            this.Left_Btn.TabIndex = 2;
            this.Left_Btn.Text = "Left";
            this.Left_Btn.UseVisualStyleBackColor = true;
            this.Left_Btn.Click += new System.EventHandler(this.Left_Btn_Click);
            // 
            // Right_Btn
            // 
            this.Right_Btn.Location = new System.Drawing.Point(113, 63);
            this.Right_Btn.Name = "Right_Btn";
            this.Right_Btn.Size = new System.Drawing.Size(45, 35);
            this.Right_Btn.TabIndex = 3;
            this.Right_Btn.Text = "Right";
            this.Right_Btn.UseVisualStyleBackColor = true;
            this.Right_Btn.Click += new System.EventHandler(this.Right_Btn_Click);
            // 
            // Down_Btn
            // 
            this.Down_Btn.Location = new System.Drawing.Point(63, 105);
            this.Down_Btn.Name = "Down_Btn";
            this.Down_Btn.Size = new System.Drawing.Size(45, 35);
            this.Down_Btn.TabIndex = 4;
            this.Down_Btn.Text = "Down";
            this.Down_Btn.UseVisualStyleBackColor = true;
            this.Down_Btn.Click += new System.EventHandler(this.Down_Btn_Click);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.DarkRed;
            this.Square.Location = new System.Drawing.Point(376, 178);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(50, 50);
            this.Square.TabIndex = 5;
            this.Square.TabStop = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Red_Btn
            // 
            this.Red_Btn.BackColor = System.Drawing.Color.DarkRed;
            this.Red_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Red_Btn.Location = new System.Drawing.Point(12, 395);
            this.Red_Btn.Name = "Red_Btn";
            this.Red_Btn.Size = new System.Drawing.Size(75, 45);
            this.Red_Btn.TabIndex = 6;
            this.Red_Btn.Text = "Change To Red";
            this.Red_Btn.UseVisualStyleBackColor = false;
            this.Red_Btn.Click += new System.EventHandler(this.Red_Btn_Click);
            // 
            // Green_Btn
            // 
            this.Green_Btn.BackColor = System.Drawing.Color.Green;
            this.Green_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Green_Btn.Location = new System.Drawing.Point(104, 395);
            this.Green_Btn.Name = "Green_Btn";
            this.Green_Btn.Size = new System.Drawing.Size(75, 45);
            this.Green_Btn.TabIndex = 7;
            this.Green_Btn.Text = "Change To Green";
            this.Green_Btn.UseVisualStyleBackColor = false;
            this.Green_Btn.Click += new System.EventHandler(this.Green_Btn_Click);
            // 
            // Blue_Btn
            // 
            this.Blue_Btn.BackColor = System.Drawing.Color.DarkBlue;
            this.Blue_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Blue_Btn.Location = new System.Drawing.Point(198, 395);
            this.Blue_Btn.Name = "Blue_Btn";
            this.Blue_Btn.Size = new System.Drawing.Size(75, 45);
            this.Blue_Btn.TabIndex = 8;
            this.Blue_Btn.Text = "Change To Blue";
            this.Blue_Btn.UseVisualStyleBackColor = false;
            this.Blue_Btn.Click += new System.EventHandler(this.Blue_Btn_Click);
            // 
            // Undo_Btn
            // 
            this.Undo_Btn.Location = new System.Drawing.Point(687, 406);
            this.Undo_Btn.Name = "Undo_Btn";
            this.Undo_Btn.Size = new System.Drawing.Size(75, 23);
            this.Undo_Btn.TabIndex = 9;
            this.Undo_Btn.Text = "Undo";
            this.Undo_Btn.UseVisualStyleBackColor = true;
            this.Undo_Btn.Click += new System.EventHandler(this.Undo_Btn_Click);
            // 
            // Command_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Undo_Btn);
            this.Controls.Add(this.Blue_Btn);
            this.Controls.Add(this.Green_Btn);
            this.Controls.Add(this.Red_Btn);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Down_Btn);
            this.Controls.Add(this.Right_Btn);
            this.Controls.Add(this.Left_Btn);
            this.Controls.Add(this.Up_Btn);
            this.Name = "Command_Form";
            this.Text = "Command Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Up_Btn;
        private System.Windows.Forms.Button Left_Btn;
        private System.Windows.Forms.Button Right_Btn;
        private System.Windows.Forms.Button Down_Btn;
        private System.Windows.Forms.PictureBox Square;
        private System.Windows.Forms.Button Red_Btn;
        private System.Windows.Forms.Button Green_Btn;
        private System.Windows.Forms.Button Blue_Btn;
        private System.Windows.Forms.Button Undo_Btn;
    }
}

