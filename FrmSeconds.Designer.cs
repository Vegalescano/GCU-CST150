namespace CST_150_Activity_2A
{
    partial class FrmSeconds
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
            btnRun = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResults = new Label();
            txtUserEntry = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(357, 124);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(136, 40);
            btnRun.TabIndex = 0;
            btnRun.Text = "Apply Seconds";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += ManageSecondsEventHandler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 70);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter the Number of Seconds:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(524, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 2;
            label2.Text = "seconds";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(61, 261);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(99, 25);
            lblResults.TabIndex = 3;
            lblResults.Text = "Activity 3";
            lblResults.Click += lblResults_Click;
            // 
            // txtUserEntry
            // 
            txtUserEntry.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserEntry.Location = new Point(357, 70);
            txtUserEntry.Name = "txtUserEntry";
            txtUserEntry.Size = new Size(161, 31);
            txtUserEntry.TabIndex = 4;
            // 
            // FrmSeconds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserEntry);
            Controls.Add(lblResults);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Name = "FrmSeconds";
            Text = "Form1";
            Load += FrmTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Label label1;
        private Label label2;
        private Label lblResults;
        private TextBox txtUserEntry;
    }
}
