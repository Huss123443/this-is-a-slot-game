namespace slots
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
            components = new System.ComponentModel.Container();
            slot1 = new PictureBox();
            slot2 = new PictureBox();
            slot3 = new PictureBox();
            SlotTimer = new System.Windows.Forms.Timer(components);
            slowbuttoncooldown = new System.Windows.Forms.Timer(components);
            button = new PictureBox();
            ButtonCoolDown = new System.Windows.Forms.Timer(components);
            Theslowbutton = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)slot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Theslowbutton).BeginInit();
            SuspendLayout();
            // 
            // slot1
            // 
            slot1.Location = new Point(152, 137);
            slot1.Name = "slot1";
            slot1.Size = new Size(158, 132);
            slot1.SizeMode = PictureBoxSizeMode.StretchImage;
            slot1.TabIndex = 0;
            slot1.TabStop = false;
            // 
            // slot2
            // 
            slot2.Location = new Point(316, 137);
            slot2.Name = "slot2";
            slot2.Size = new Size(158, 132);
            slot2.SizeMode = PictureBoxSizeMode.StretchImage;
            slot2.TabIndex = 1;
            slot2.TabStop = false;
            // 
            // slot3
            // 
            slot3.Location = new Point(480, 137);
            slot3.Name = "slot3";
            slot3.Size = new Size(158, 132);
            slot3.SizeMode = PictureBoxSizeMode.StretchImage;
            slot3.TabIndex = 2;
            slot3.TabStop = false;
            // 
            // SlotTimer
            // 
            SlotTimer.Enabled = true;
            SlotTimer.Tick += NextItem;
            // 
            // slowbuttoncooldown
            // 
            slowbuttoncooldown.Interval = 2000;
            slowbuttoncooldown.Tick += slowbuttoncooldown_Tick;
            // 
            // button
            // 
            button.Location = new Point(340, 320);
            button.Margin = new Padding(3, 2, 3, 2);
            button.Name = "button";
            button.Size = new Size(134, 95);
            button.SizeMode = PictureBoxSizeMode.StretchImage;
            button.TabIndex = 3;
            button.TabStop = false;
            button.MouseClick += button_MouseClick;
            // 
            // ButtonCoolDown
            // 
            ButtonCoolDown.Interval = 2000;
            ButtonCoolDown.Tick += ButtonCoolDown_Tick;
            // 
            // Theslowbutton
            // 
            Theslowbutton.Location = new Point(180, 320);
            Theslowbutton.Name = "Theslowbutton";
            Theslowbutton.Size = new Size(120, 95);
            Theslowbutton.SizeMode = PictureBoxSizeMode.StretchImage;
            Theslowbutton.TabIndex = 4;
            Theslowbutton.TabStop = false;
            Theslowbutton.MouseClick += Theslowbutton_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Theslowbutton);
            Controls.Add(button);
            Controls.Add(slot3);
            Controls.Add(slot2);
            Controls.Add(slot1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)slot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)button).EndInit();
            ((System.ComponentModel.ISupportInitialize)Theslowbutton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox slot1;
        private PictureBox slot2;
        private PictureBox slot3;
        private System.Windows.Forms.Timer SlotTimer;
        private System.Windows.Forms.Timer slowbuttoncooldown;
        private PictureBox button;
        private System.Windows.Forms.Timer ButtonCoolDown;
        private PictureBox Theslowbutton;
        private Label label1;
    }
}