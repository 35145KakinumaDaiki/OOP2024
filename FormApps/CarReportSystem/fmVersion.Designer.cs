﻿namespace CarReportSystem {
    partial class fmVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btVersionOK = new Button();
            label1 = new Label();
            lbVersion1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btVersionOK
            // 
            btVersionOK.Location = new Point(329, 184);
            btVersionOK.Name = "btVersionOK";
            btVersionOK.Size = new Size(63, 20);
            btVersionOK.TabIndex = 0;
            btVersionOK.Text = "OK";
            btVersionOK.UseVisualStyleBackColor = true;
            btVersionOK.Click += btVersionOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("游ゴシック", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(63, 24);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 1;
            label1.Text = "カーレポートシステム";
            // 
            // lbVersion1
            // 
            lbVersion1.AutoSize = true;
            lbVersion1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbVersion1.Location = new Point(148, 55);
            lbVersion1.Name = "lbVersion1";
            lbVersion1.Size = new Size(42, 20);
            lbVersion1.TabIndex = 2;
            lbVersion1.Text = "1.1.1.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // fmVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 216);
            Controls.Add(label3);
            Controls.Add(lbVersion1);
            Controls.Add(label1);
            Controls.Add(btVersionOK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fmVersion";
            Text = "fmVersion";
            Load += fmVersion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVersionOK;
        private Label label1;
        private Label lbVersion1;
        private Label label3;
    }
}