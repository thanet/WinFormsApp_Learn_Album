namespace WinFormsApp_Learn
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
            but_Album = new Button();
            lblHellowWorld = new Label();
            dgv_Album = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Album).BeginInit();
            SuspendLayout();
            // 
            // but_Album
            // 
            but_Album.Location = new Point(198, 84);
            but_Album.Name = "but_Album";
            but_Album.Size = new Size(105, 35);
            but_Album.TabIndex = 0;
            but_Album.Text = "Album";
            but_Album.UseVisualStyleBackColor = true;
            but_Album.Click += but_Album_Click;
            // 
            // lblHellowWorld
            // 
            lblHellowWorld.AutoSize = true;
            lblHellowWorld.Location = new Point(327, 56);
            lblHellowWorld.Name = "lblHellowWorld";
            lblHellowWorld.Size = new Size(50, 20);
            lblHellowWorld.TabIndex = 1;
            lblHellowWorld.Text = "label1";
            // 
            // dgv_Album
            // 
            dgv_Album.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Album.Location = new Point(309, 84);
            dgv_Album.Name = "dgv_Album";
            dgv_Album.Size = new Size(655, 271);
            dgv_Album.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 502);
            Controls.Add(dgv_Album);
            Controls.Add(lblHellowWorld);
            Controls.Add(but_Album);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Album).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but01;
        private Button but_Album;
        private Label lblHellowWorld;
        private DataGridView dgv_Album;
    }
}
