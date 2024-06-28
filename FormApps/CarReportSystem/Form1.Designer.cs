namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            cbAuthor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbCarname = new ComboBox();
            rbToyota = new RadioButton();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            tbReport = new TextBox();
            label6 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label7 = new Label();
            dgvCarreport = new DataGridView();
            btReportSave = new Button();
            btReportOpen = new Button();
            ofdPicFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarreport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(78, 38);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // cbAuther
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(78, 95);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(224, 33);
            cbAuthor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(25, 195);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(8, 244);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // cbCarname
            // 
            cbCarname.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarname.FormattingEnabled = true;
            cbCarname.Location = new Point(84, 195);
            cbCarname.Name = "cbCarname";
            cbCarname.Size = new Size(224, 33);
            cbCarname.TabIndex = 2;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 14);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 3;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(78, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 39);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(297, 14);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 3;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(230, 14);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 3;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(171, 14);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(117, 14);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 3;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(62, 14);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 3;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(78, 244);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(353, 115);
            tbReport.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(534, 38);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 0;
            label6.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.Location = new Point(607, 41);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 6;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(724, 40);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 6;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.FromArgb(255, 255, 192);
            pbPicture.Location = new Point(534, 70);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(265, 235);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 7;
            pbPicture.TabStop = false;
            // 
            // btAddReport
            // 
            btAddReport.Location = new Point(534, 322);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(85, 37);
            btAddReport.TabIndex = 6;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.Location = new Point(638, 322);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(80, 37);
            btModifyReport.TabIndex = 6;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = true;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Location = new Point(724, 322);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(75, 37);
            btDeleteReport.TabIndex = 6;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(5, 377);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 0;
            label7.Text = "一覧";
            // 
            // dgvCarreport
            // 
            dgvCarreport.AllowUserToAddRows = false;
            dgvCarreport.AllowUserToDeleteRows = false;
            dgvCarreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreport.Location = new Point(140, 389);
            dgvCarreport.MultiSelect = false;
            dgvCarreport.Name = "dgvCarreport";
            dgvCarreport.ReadOnly = true;
            dgvCarreport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarreport.Size = new Size(746, 185);
            dgvCarreport.TabIndex = 8;
            dgvCarreport.Click += dgvCarreport_Click;
            // 
            // btReportSave
            // 
            btReportSave.Location = new Point(22, 512);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(82, 41);
            btReportSave.TabIndex = 6;
            btReportSave.Text = "保存";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // btReportOpen
            // 
            btReportOpen.Location = new Point(22, 449);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(82, 37);
            btReportOpen.TabIndex = 6;
            btReportOpen.Text = "開く...";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 631);
            Controls.Add(dgvCarreport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btReportOpen);
            Controls.Add(btReportSave);
            Controls.Add(btAddReport);
            Controls.Add(btPicOpen);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(cbCarname);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarreport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbAuthor;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbCarname;
        private RadioButton rbToyota;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private TextBox tbReport;
        private Label label6;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label7;
        private DataGridView dgvCarreport;
        private Button btReportSave;
        private Button btReportOpen;
        private OpenFileDialog ofdPicFileOpen;
    }
}
