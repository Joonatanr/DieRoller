namespace DieRoller
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
            this.dieRollControl7 = new DieRoller.DieRollControl();
            this.dieRollControl6 = new DieRoller.DieRollControl();
            this.dieRollControl5 = new DieRoller.DieRollControl();
            this.dieRollControl4 = new DieRoller.DieRollControl();
            this.dieRollControl3 = new DieRoller.DieRollControl();
            this.dieRollControl2 = new DieRoller.DieRollControl();
            this.dieRollControl1 = new DieRoller.DieRollControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dieRollControl7
            // 
            this.dieRollControl7.DefaultInputText = "";
            this.dieRollControl7.Location = new System.Drawing.Point(12, 234);
            this.dieRollControl7.Name = "dieRollControl7";
            this.dieRollControl7.Size = new System.Drawing.Size(379, 31);
            this.dieRollControl7.TabIndex = 6;
            // 
            // dieRollControl6
            // 
            this.dieRollControl6.DefaultInputText = "";
            this.dieRollControl6.Location = new System.Drawing.Point(12, 197);
            this.dieRollControl6.Name = "dieRollControl6";
            this.dieRollControl6.Size = new System.Drawing.Size(379, 31);
            this.dieRollControl6.TabIndex = 5;
            // 
            // dieRollControl5
            // 
            this.dieRollControl5.DefaultInputText = "";
            this.dieRollControl5.Location = new System.Drawing.Point(12, 160);
            this.dieRollControl5.Name = "dieRollControl5";
            this.dieRollControl5.Size = new System.Drawing.Size(379, 31);
            this.dieRollControl5.TabIndex = 4;
            // 
            // dieRollControl4
            // 
            this.dieRollControl4.DefaultInputText = "";
            this.dieRollControl4.Location = new System.Drawing.Point(12, 123);
            this.dieRollControl4.Name = "dieRollControl4";
            this.dieRollControl4.Size = new System.Drawing.Size(379, 31);
            this.dieRollControl4.TabIndex = 3;
            // 
            // dieRollControl3
            // 
            this.dieRollControl3.DefaultInputText = "";
            this.dieRollControl3.Location = new System.Drawing.Point(12, 49);
            this.dieRollControl3.Name = "dieRollControl3";
            this.dieRollControl3.Size = new System.Drawing.Size(379, 31);
            this.dieRollControl3.TabIndex = 2;
            // 
            // dieRollControl2
            // 
            this.dieRollControl2.DefaultInputText = "";
            this.dieRollControl2.Location = new System.Drawing.Point(12, 86);
            this.dieRollControl2.Name = "dieRollControl2";
            this.dieRollControl2.Size = new System.Drawing.Size(379, 31);
            this.dieRollControl2.TabIndex = 1;
            // 
            // dieRollControl1
            // 
            this.dieRollControl1.DefaultInputText = "2d10+5";
            this.dieRollControl1.Location = new System.Drawing.Point(12, 12);
            this.dieRollControl1.Name = "dieRollControl1";
            this.dieRollControl1.Size = new System.Drawing.Size(379, 31);
            this.dieRollControl1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 271);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(824, 225);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dieRollControl7);
            this.Controls.Add(this.dieRollControl6);
            this.Controls.Add(this.dieRollControl5);
            this.Controls.Add(this.dieRollControl4);
            this.Controls.Add(this.dieRollControl3);
            this.Controls.Add(this.dieRollControl2);
            this.Controls.Add(this.dieRollControl1);
            this.Name = "Form1";
            this.Text = "Die Roller";
            this.ResumeLayout(false);

        }

        #endregion

        private DieRollControl dieRollControl1;
        private DieRollControl dieRollControl2;
        private DieRollControl dieRollControl3;
        private DieRollControl dieRollControl4;
        private DieRollControl dieRollControl5;
        private DieRollControl dieRollControl6;
        private DieRollControl dieRollControl7;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

