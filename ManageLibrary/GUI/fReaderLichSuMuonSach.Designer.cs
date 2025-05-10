namespace GUI
{
    partial class fReaderLichSuMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReaderLichSuMuonSach));
            this.dgvLichSuMuonSach = new System.Windows.Forms.DataGridView();
            this.btnLocTheoTinhTrang = new System.Windows.Forms.Button();
            this.cbbLocTheoTinhTrang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuMuonSach
            // 
            this.dgvLichSuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuMuonSach.Location = new System.Drawing.Point(12, 115);
            this.dgvLichSuMuonSach.Name = "dgvLichSuMuonSach";
            this.dgvLichSuMuonSach.RowHeadersWidth = 51;
            this.dgvLichSuMuonSach.RowTemplate.Height = 24;
            this.dgvLichSuMuonSach.Size = new System.Drawing.Size(785, 331);
            this.dgvLichSuMuonSach.TabIndex = 0;
            // 
            // btnLocTheoTinhTrang
            // 
            this.btnLocTheoTinhTrang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocTheoTinhTrang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocTheoTinhTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocTheoTinhTrang.Image = ((System.Drawing.Image)(resources.GetObject("btnLocTheoTinhTrang.Image")));
            this.btnLocTheoTinhTrang.Location = new System.Drawing.Point(351, 79);
            this.btnLocTheoTinhTrang.Name = "btnLocTheoTinhTrang";
            this.btnLocTheoTinhTrang.Size = new System.Drawing.Size(31, 27);
            this.btnLocTheoTinhTrang.TabIndex = 70;
            this.btnLocTheoTinhTrang.UseVisualStyleBackColor = false;
            // 
            // cbbLocTheoTinhTrang
            // 
            this.cbbLocTheoTinhTrang.FormattingEnabled = true;
            this.cbbLocTheoTinhTrang.Location = new System.Drawing.Point(137, 82);
            this.cbbLocTheoTinhTrang.Name = "cbbLocTheoTinhTrang";
            this.cbbLocTheoTinhTrang.Size = new System.Drawing.Size(208, 24);
            this.cbbLocTheoTinhTrang.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Lọc theo trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Kiểm tra lịch sử mượn sách";
            // 
            // fReaderLichSuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocTheoTinhTrang);
            this.Controls.Add(this.cbbLocTheoTinhTrang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvLichSuMuonSach);
            this.Name = "fReaderLichSuMuonSach";
            this.Text = "fReaderLichSuMuonSach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuMuonSach;
        private System.Windows.Forms.Button btnLocTheoTinhTrang;
        private System.Windows.Forms.ComboBox cbbLocTheoTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}