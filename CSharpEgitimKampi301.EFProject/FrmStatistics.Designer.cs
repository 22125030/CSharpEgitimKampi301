﻿namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocationCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSumCapacity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGuideCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvgCapacity = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTurkiyeCapacityAvg = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCappacociaLocationCapacity = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLastCountryName = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAvgLocationPrice = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAysegulCinarLocationCount = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMaxPriceLocation = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMaxCapacityLocation = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.lblRomaGuideName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lokasyon Sayısı";
            // 
            // lblLocationCount
            // 
            this.lblLocationCount.AutoSize = true;
            this.lblLocationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLocationCount.Location = new System.Drawing.Point(25, 43);
            this.lblLocationCount.Name = "lblLocationCount";
            this.lblLocationCount.Size = new System.Drawing.Size(38, 25);
            this.lblLocationCount.TabIndex = 1;
            this.lblLocationCount.Text = "00";
            this.lblLocationCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLocationCount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 123);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblSumCapacity);
            this.panel2.Location = new System.Drawing.Point(197, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 123);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam Kapasite";
            // 
            // lblSumCapacity
            // 
            this.lblSumCapacity.AutoSize = true;
            this.lblSumCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSumCapacity.Location = new System.Drawing.Point(34, 43);
            this.lblSumCapacity.Name = "lblSumCapacity";
            this.lblSumCapacity.Size = new System.Drawing.Size(38, 25);
            this.lblSumCapacity.TabIndex = 1;
            this.lblSumCapacity.Text = "00";
            this.lblSumCapacity.Click += new System.EventHandler(this.lblSumCapacity_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblGuideCount);
            this.panel3.Location = new System.Drawing.Point(382, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 123);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rehber Sayısı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblGuideCount
            // 
            this.lblGuideCount.AutoSize = true;
            this.lblGuideCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuideCount.Location = new System.Drawing.Point(34, 43);
            this.lblGuideCount.Name = "lblGuideCount";
            this.lblGuideCount.Size = new System.Drawing.Size(38, 25);
            this.lblGuideCount.TabIndex = 1;
            this.lblGuideCount.Text = "00";
            this.lblGuideCount.Click += new System.EventHandler(this.lblGuideCount_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblAvgCapacity);
            this.panel4.Location = new System.Drawing.Point(567, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 123);
            this.panel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ortalama Kapasite";
            // 
            // lblAvgCapacity
            // 
            this.lblAvgCapacity.AutoSize = true;
            this.lblAvgCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAvgCapacity.Location = new System.Drawing.Point(34, 43);
            this.lblAvgCapacity.Name = "lblAvgCapacity";
            this.lblAvgCapacity.Size = new System.Drawing.Size(38, 25);
            this.lblAvgCapacity.TabIndex = 1;
            this.lblAvgCapacity.Text = "00";
            this.lblAvgCapacity.Click += new System.EventHandler(this.lblAvgCapacity_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lblTurkiyeCapacityAvg);
            this.panel5.Location = new System.Drawing.Point(567, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 123);
            this.panel5.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(35, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "  Türkiye Turları \r\nOrtalama Kapasite";
            // 
            // lblTurkiyeCapacityAvg
            // 
            this.lblTurkiyeCapacityAvg.AutoSize = true;
            this.lblTurkiyeCapacityAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkiyeCapacityAvg.Location = new System.Drawing.Point(34, 52);
            this.lblTurkiyeCapacityAvg.Name = "lblTurkiyeCapacityAvg";
            this.lblTurkiyeCapacityAvg.Size = new System.Drawing.Size(38, 25);
            this.lblTurkiyeCapacityAvg.TabIndex = 1;
            this.lblTurkiyeCapacityAvg.Text = "00";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lblCappacociaLocationCapacity);
            this.panel6.Location = new System.Drawing.Point(382, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 123);
            this.panel6.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(4, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kapadokya Tur Kapasitesi";
            // 
            // lblCappacociaLocationCapacity
            // 
            this.lblCappacociaLocationCapacity.AutoSize = true;
            this.lblCappacociaLocationCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCappacociaLocationCapacity.Location = new System.Drawing.Point(15, 52);
            this.lblCappacociaLocationCapacity.Name = "lblCappacociaLocationCapacity";
            this.lblCappacociaLocationCapacity.Size = new System.Drawing.Size(38, 25);
            this.lblCappacociaLocationCapacity.TabIndex = 1;
            this.lblCappacociaLocationCapacity.Text = "00";
            this.lblCappacociaLocationCapacity.Click += new System.EventHandler(this.lblCappacociaLocationCapacity_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.lblLastCountryName);
            this.panel7.Location = new System.Drawing.Point(197, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(179, 123);
            this.panel7.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(35, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Eklenen Son Ülke";
            // 
            // lblLastCountryName
            // 
            this.lblLastCountryName.AutoSize = true;
            this.lblLastCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastCountryName.Location = new System.Drawing.Point(34, 52);
            this.lblLastCountryName.Name = "lblLastCountryName";
            this.lblLastCountryName.Size = new System.Drawing.Size(38, 25);
            this.lblLastCountryName.TabIndex = 1;
            this.lblLastCountryName.Text = "00";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.lblAvgLocationPrice);
            this.panel8.Location = new System.Drawing.Point(12, 151);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(179, 123);
            this.panel8.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(25, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ortalama Tur Fiyatı";
            // 
            // lblAvgLocationPrice
            // 
            this.lblAvgLocationPrice.AutoSize = true;
            this.lblAvgLocationPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAvgLocationPrice.Location = new System.Drawing.Point(24, 52);
            this.lblAvgLocationPrice.Name = "lblAvgLocationPrice";
            this.lblAvgLocationPrice.Size = new System.Drawing.Size(38, 25);
            this.lblAvgLocationPrice.TabIndex = 1;
            this.lblAvgLocationPrice.Text = "00";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.lblAysegulCinarLocationCount);
            this.panel9.Location = new System.Drawing.Point(567, 292);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(179, 123);
            this.panel9.TabIndex = 12;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(35, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 38);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ayşegül Çınar\'ın\r\n      Tur Sayısı";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblAysegulCinarLocationCount
            // 
            this.lblAysegulCinarLocationCount.AutoSize = true;
            this.lblAysegulCinarLocationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAysegulCinarLocationCount.Location = new System.Drawing.Point(24, 52);
            this.lblAysegulCinarLocationCount.Name = "lblAysegulCinarLocationCount";
            this.lblAysegulCinarLocationCount.Size = new System.Drawing.Size(38, 25);
            this.lblAysegulCinarLocationCount.TabIndex = 1;
            this.lblAysegulCinarLocationCount.Text = "00";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Lime;
            this.panel10.Controls.Add(this.label19);
            this.panel10.Controls.Add(this.lblMaxPriceLocation);
            this.panel10.Location = new System.Drawing.Point(382, 292);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(179, 123);
            this.panel10.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(35, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "En Pahalı Tur";
            // 
            // lblMaxPriceLocation
            // 
            this.lblMaxPriceLocation.AutoSize = true;
            this.lblMaxPriceLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxPriceLocation.Location = new System.Drawing.Point(15, 52);
            this.lblMaxPriceLocation.Name = "lblMaxPriceLocation";
            this.lblMaxPriceLocation.Size = new System.Drawing.Size(38, 25);
            this.lblMaxPriceLocation.TabIndex = 1;
            this.lblMaxPriceLocation.Text = "00";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel11.Controls.Add(this.label21);
            this.panel11.Controls.Add(this.lblMaxCapacityLocation);
            this.panel11.Location = new System.Drawing.Point(197, 292);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(179, 123);
            this.panel11.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(35, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 38);
            this.label21.TabIndex = 0;
            this.label21.Text = "   En Yüksek \r\nKapasiteli Tur";
            // 
            // lblMaxCapacityLocation
            // 
            this.lblMaxCapacityLocation.AutoSize = true;
            this.lblMaxCapacityLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxCapacityLocation.Location = new System.Drawing.Point(34, 52);
            this.lblMaxCapacityLocation.Name = "lblMaxCapacityLocation";
            this.lblMaxCapacityLocation.Size = new System.Drawing.Size(38, 25);
            this.lblMaxCapacityLocation.TabIndex = 1;
            this.lblMaxCapacityLocation.Text = "00";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel12.Controls.Add(this.label23);
            this.panel12.Controls.Add(this.lblRomaGuideName);
            this.panel12.Location = new System.Drawing.Point(12, 292);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(179, 123);
            this.panel12.TabIndex = 9;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(35, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(132, 19);
            this.label23.TabIndex = 0;
            this.label23.Text = "Roma Gezi Rehberi";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // lblRomaGuideName
            // 
            this.lblRomaGuideName.AutoSize = true;
            this.lblRomaGuideName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRomaGuideName.Location = new System.Drawing.Point(24, 41);
            this.lblRomaGuideName.Name = "lblRomaGuideName";
            this.lblRomaGuideName.Size = new System.Drawing.Size(38, 25);
            this.lblRomaGuideName.TabIndex = 1;
            this.lblRomaGuideName.Text = "00";
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(759, 429);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocationCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSumCapacity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGuideCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAvgCapacity;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTurkiyeCapacityAvg;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCappacociaLocationCapacity;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblLastCountryName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAvgLocationPrice;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAysegulCinarLocationCount;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMaxPriceLocation;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMaxCapacityLocation;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblRomaGuideName;
    }
}