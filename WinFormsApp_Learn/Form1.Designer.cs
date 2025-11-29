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
            btn_Search = new Button();
            txt_Search = new TextBox();
            picbox_00 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Album).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_00).BeginInit();
            SuspendLayout();
            // 
            // but_Album
            // 
            but_Album.Location = new Point(309, 43);
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
            lblHellowWorld.Location = new Point(970, 84);
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
            dgv_Album.CellClick += dgv_Album_CellClick;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(772, 43);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(96, 35);
            btn_Search.TabIndex = 3;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(432, 43);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(318, 27);
            txt_Search.TabIndex = 4;
            // 
            // picbox_00
            // 
            picbox_00.Location = new Point(106, 84);
            picbox_00.Name = "picbox_00";
            picbox_00.Size = new Size(189, 259);
            picbox_00.TabIndex = 5;
            picbox_00.TabStop = false;
            picbox_00.WaitOnLoad = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 502);
            Controls.Add(picbox_00);
            Controls.Add(txt_Search);
            Controls.Add(btn_Search);
            Controls.Add(dgv_Album);
            Controls.Add(lblHellowWorld);
            Controls.Add(but_Album);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Album).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_00).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but01;
        private Button but_Album;
        private Label lblHellowWorld;
        private DataGridView dgv_Album;
        private Button btn_Search;
        private TextBox txt_Search;
        private PictureBox picbox_00;
    }
}
