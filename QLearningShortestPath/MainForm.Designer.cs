namespace GraphShortest
{
    partial class MnFrm
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
            this.components = new System.ComponentModel.Container();
            this.listDugumler = new System.Windows.Forms.ListBox();
            this.txtDugumAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBas = new System.Windows.Forms.ComboBox();
            this.comboBitis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNode2 = new System.Windows.Forms.ComboBox();
            this.comboBoxNode1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBaglar = new System.Windows.Forms.ListBox();
            this.btnYolSil = new System.Windows.Forms.Button();
            this.btnYolEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRtable = new System.Windows.Forms.TabPage();
            this.panelRtable = new System.Windows.Forms.Panel();
            this.tabPageQtable = new System.Windows.Forms.TabPage();
            this.panelQtable = new System.Windows.Forms.Panel();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btniter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn3D = new System.Windows.Forms.Button();
            this.timerEkran = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRtable.SuspendLayout();
            this.tabPageQtable.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDugumler
            // 
            this.listDugumler.FormattingEnabled = true;
            this.listDugumler.Location = new System.Drawing.Point(6, 62);
            this.listDugumler.Name = "listDugumler";
            this.listDugumler.Size = new System.Drawing.Size(62, 147);
            this.listDugumler.TabIndex = 0;
            // 
            // txtDugumAd
            // 
            this.txtDugumAd.Location = new System.Drawing.Point(6, 36);
            this.txtDugumAd.MaxLength = 2;
            this.txtDugumAd.Name = "txtDugumAd";
            this.txtDugumAd.Size = new System.Drawing.Size(62, 20);
            this.txtDugumAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(71, 33);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(48, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(71, 62);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(48, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SÝL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Düðüm Adý";
            // 
            // comboBas
            // 
            this.comboBas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBas.FormattingEnabled = true;
            this.comboBas.Location = new System.Drawing.Point(12, 35);
            this.comboBas.Name = "comboBas";
            this.comboBas.Size = new System.Drawing.Size(76, 21);
            this.comboBas.TabIndex = 5;
            // 
            // comboBitis
            // 
            this.comboBitis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBitis.FormattingEnabled = true;
            this.comboBitis.Location = new System.Drawing.Point(10, 75);
            this.comboBitis.Name = "comboBitis";
            this.comboBitis.Size = new System.Drawing.Size(76, 21);
            this.comboBitis.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baþlangýç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bitiþ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Node 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Node 1";
            // 
            // comboBoxNode2
            // 
            this.comboBoxNode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNode2.FormattingEnabled = true;
            this.comboBoxNode2.Location = new System.Drawing.Point(111, 43);
            this.comboBoxNode2.Name = "comboBoxNode2";
            this.comboBoxNode2.Size = new System.Drawing.Size(55, 21);
            this.comboBoxNode2.TabIndex = 10;
            // 
            // comboBoxNode1
            // 
            this.comboBoxNode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNode1.FormattingEnabled = true;
            this.comboBoxNode1.Location = new System.Drawing.Point(13, 43);
            this.comboBoxNode1.Name = "comboBoxNode1";
            this.comboBoxNode1.Size = new System.Drawing.Size(55, 21);
            this.comboBoxNode1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(74, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "---->";
            // 
            // listBaglar
            // 
            this.listBaglar.FormattingEnabled = true;
            this.listBaglar.Location = new System.Drawing.Point(11, 84);
            this.listBaglar.Name = "listBaglar";
            this.listBaglar.Size = new System.Drawing.Size(150, 108);
            this.listBaglar.TabIndex = 14;
            // 
            // btnYolSil
            // 
            this.btnYolSil.Location = new System.Drawing.Point(172, 113);
            this.btnYolSil.Name = "btnYolSil";
            this.btnYolSil.Size = new System.Drawing.Size(64, 23);
            this.btnYolSil.TabIndex = 16;
            this.btnYolSil.Text = "SÝL";
            this.btnYolSil.UseVisualStyleBackColor = true;
            this.btnYolSil.Click += new System.EventHandler(this.btnYolSil_Click);
            // 
            // btnYolEkle
            // 
            this.btnYolEkle.Location = new System.Drawing.Point(172, 84);
            this.btnYolEkle.Name = "btnYolEkle";
            this.btnYolEkle.Size = new System.Drawing.Size(64, 23);
            this.btnYolEkle.TabIndex = 15;
            this.btnYolEkle.Text = "EKLE";
            this.btnYolEkle.UseVisualStyleBackColor = true;
            this.btnYolEkle.Click += new System.EventHandler(this.btnYolEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDugumAd);
            this.groupBox1.Controls.Add(this.listDugumler);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 226);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Düðüm Oluþturma";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTamam);
            this.groupBox2.Controls.Add(this.comboBitis);
            this.groupBox2.Controls.Add(this.comboBas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(158, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 154);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Düðüm Seçme";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(13, 115);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 9;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnYolSil);
            this.groupBox3.Controls.Add(this.comboBoxNode1);
            this.groupBox3.Controls.Add(this.comboBoxNode2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnYolEkle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.listBaglar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 215);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Node Baðlama";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageRtable);
            this.tabControl1.Controls.Add(this.tabPageQtable);
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Controls.Add(this.tabPageRules);
            this.tabControl1.Location = new System.Drawing.Point(280, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 460);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageRtable
            // 
            this.tabPageRtable.Controls.Add(this.panelRtable);
            this.tabPageRtable.Location = new System.Drawing.Point(4, 22);
            this.tabPageRtable.Name = "tabPageRtable";
            this.tabPageRtable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRtable.Size = new System.Drawing.Size(562, 434);
            this.tabPageRtable.TabIndex = 0;
            this.tabPageRtable.Text = "R table";
            this.tabPageRtable.UseVisualStyleBackColor = true;
            // 
            // panelRtable
            // 
            this.panelRtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRtable.Location = new System.Drawing.Point(3, 3);
            this.panelRtable.Name = "panelRtable";
            this.panelRtable.Size = new System.Drawing.Size(556, 428);
            this.panelRtable.TabIndex = 0;
            // 
            // tabPageQtable
            // 
            this.tabPageQtable.Controls.Add(this.panelQtable);
            this.tabPageQtable.Location = new System.Drawing.Point(4, 22);
            this.tabPageQtable.Name = "tabPageQtable";
            this.tabPageQtable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQtable.Size = new System.Drawing.Size(562, 434);
            this.tabPageQtable.TabIndex = 1;
            this.tabPageQtable.Text = "Q table";
            this.tabPageQtable.UseVisualStyleBackColor = true;
            // 
            // panelQtable
            // 
            this.panelQtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQtable.Location = new System.Drawing.Point(3, 3);
            this.panelQtable.Name = "panelQtable";
            this.panelQtable.Size = new System.Drawing.Size(556, 428);
            this.panelQtable.TabIndex = 0;
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.panelGraph);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(562, 434);
            this.tabPageGraph.TabIndex = 2;
            this.tabPageGraph.Text = "Graph 2D";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // panelGraph
            // 
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(3, 3);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(556, 428);
            this.panelGraph.TabIndex = 0;
            this.panelGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGraph_MouseDown);
            this.panelGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGraph_MouseMove);
            this.panelGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGraph_MouseUp);
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.label10);
            this.tabPageRules.Controls.Add(this.label9);
            this.tabPageRules.Controls.Add(this.label8);
            this.tabPageRules.Controls.Add(this.label7);
            this.tabPageRules.Location = new System.Drawing.Point(4, 22);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRules.Size = new System.Drawing.Size(562, 434);
            this.tabPageRules.TabIndex = 3;
            this.tabPageRules.Text = "Kurallar";
            this.tabPageRules.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(50, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Q(B,F)=R(B,F)+0.8xMAX[Q(F,E),Q(F,B)]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(50, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "ÖRNEK:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(50, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "0<@<1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(440, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Q(S,A)=R(S,A)+@xMAX[Q(sonraki durumda yapýlabilecek yollar )]";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btniter);
            this.groupBox4.Location = new System.Drawing.Point(149, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 66);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ýþlem";
            // 
            // btniter
            // 
            this.btniter.Location = new System.Drawing.Point(6, 15);
            this.btniter.Name = "btniter";
            this.btniter.Size = new System.Drawing.Size(105, 43);
            this.btniter.TabIndex = 0;
            this.btniter.Text = "Q Deðerlerini Oluþtur ve Yol Bul";
            this.btniter.UseVisualStyleBackColor = true;
            this.btniter.Click += new System.EventHandler(this.btniter_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(856, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(82, 121);
            this.listBox1.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(853, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Geçilen Düðümler";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(856, 195);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(82, 121);
            this.listBox2.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(853, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Geçilen Yollar";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btn3D);
            this.groupBox5.Location = new System.Drawing.Point(856, 341);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(82, 63);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ýþlem";
            // 
            // btn3D
            // 
            this.btn3D.Location = new System.Drawing.Point(11, 16);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(63, 37);
            this.btn3D.TabIndex = 0;
            this.btn3D.Text = "3D";
            this.btn3D.UseVisualStyleBackColor = true;
            this.btn3D.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // timerEkran
            // 
            this.timerEkran.Interval = 2;
            this.timerEkran.Tick += new System.EventHandler(this.timerEkran_Tick);
            // 
            // MnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 487);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MnFrm";
            this.Text = "Q-Learning Shortest Path (developed by Uður CORUH)";
            this.Load += new System.EventHandler(this.MnFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRtable.ResumeLayout(false);
            this.tabPageQtable.ResumeLayout(false);
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageRules.ResumeLayout(false);
            this.tabPageRules.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDugumler;
        private System.Windows.Forms.TextBox txtDugumAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBas;
        private System.Windows.Forms.ComboBox comboBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNode2;
        private System.Windows.Forms.ComboBox comboBoxNode1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBaglar;
        private System.Windows.Forms.Button btnYolSil;
        private System.Windows.Forms.Button btnYolEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRtable;
        private System.Windows.Forms.TabPage tabPageQtable;
        private System.Windows.Forms.Panel panelRtable;
        private System.Windows.Forms.Panel panelQtable;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.TabPage tabPageRules;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btniter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn3D;
        private System.Windows.Forms.Timer timerEkran;
    }
}

