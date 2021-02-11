
namespace OOPCarInformation
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
            this.lMarka = new System.Windows.Forms.Label();
            this.bKaydet = new System.Windows.Forms.Button();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.lAgirlik = new System.Windows.Forms.Label();
            this.lSifirdanYuzeHizlanma = new System.Windows.Forms.Label();
            this.lCekis = new System.Windows.Forms.Label();
            this.lMaksimumHiz = new System.Windows.Forms.Label();
            this.lArabaTürü = new System.Windows.Forms.Label();
            this.lBeygirGücü = new System.Windows.Forms.Label();
            this.lKapiSayisi = new System.Windows.Forms.Label();
            this.lModel = new System.Windows.Forms.Label();
            this.lMotorHacmi = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.nudKapiSayisi = new System.Windows.Forms.NumericUpDown();
            this.tbBeygirGücü = new System.Windows.Forms.TextBox();
            this.cbArabaTürü = new System.Windows.Forms.ComboBox();
            this.tbMaksimumHiz = new System.Windows.Forms.TextBox();
            this.cbCekis = new System.Windows.Forms.ComboBox();
            this.tbSifirdanYuzeHizlanma = new System.Windows.Forms.TextBox();
            this.tbAgirlik = new System.Windows.Forms.TextBox();
            this.tbMotorHacmi = new System.Windows.Forms.TextBox();
            this.lSonucId = new System.Windows.Forms.Label();
            this.bGöster = new System.Windows.Forms.Button();
            this.lSonucMotorHacmi = new System.Windows.Forms.Label();
            this.lSonucAgirlik = new System.Windows.Forms.Label();
            this.lSonucSifirdanYüzeHizlanma = new System.Windows.Forms.Label();
            this.lSonucCekis = new System.Windows.Forms.Label();
            this.lSonucMaksimumHiz = new System.Windows.Forms.Label();
            this.lSonucArabaTürü = new System.Windows.Forms.Label();
            this.lSonucBeygirGücü = new System.Windows.Forms.Label();
            this.lSonucKapiSayisi = new System.Windows.Forms.Label();
            this.lSonucModel = new System.Windows.Forms.Label();
            this.lSonucMarka = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapiSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // lMarka
            // 
            this.lMarka.AutoSize = true;
            this.lMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMarka.Location = new System.Drawing.Point(12, 46);
            this.lMarka.Name = "lMarka";
            this.lMarka.Size = new System.Drawing.Size(58, 20);
            this.lMarka.TabIndex = 0;
            this.lMarka.Text = "Marka";
            // 
            // bKaydet
            // 
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.Location = new System.Drawing.Point(108, 417);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(170, 57);
            this.bKaydet.TabIndex = 1;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(151, 47);
            this.tbMarka.MaxLength = 100;
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(186, 20);
            this.tbMarka.TabIndex = 2;
            // 
            // lAgirlik
            // 
            this.lAgirlik.AutoSize = true;
            this.lAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lAgirlik.Location = new System.Drawing.Point(12, 346);
            this.lAgirlik.Name = "lAgirlik";
            this.lAgirlik.Size = new System.Drawing.Size(58, 20);
            this.lAgirlik.TabIndex = 3;
            this.lAgirlik.Text = "Ağırlık";
            // 
            // lSifirdanYuzeHizlanma
            // 
            this.lSifirdanYuzeHizlanma.AutoSize = true;
            this.lSifirdanYuzeHizlanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSifirdanYuzeHizlanma.Location = new System.Drawing.Point(12, 310);
            this.lSifirdanYuzeHizlanma.Name = "lSifirdanYuzeHizlanma";
            this.lSifirdanYuzeHizlanma.Size = new System.Drawing.Size(134, 20);
            this.lSifirdanYuzeHizlanma.TabIndex = 4;
            this.lSifirdanYuzeHizlanma.Text = "0-100 Hızlanma";
            // 
            // lCekis
            // 
            this.lCekis.AutoSize = true;
            this.lCekis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lCekis.Location = new System.Drawing.Point(12, 276);
            this.lCekis.Name = "lCekis";
            this.lCekis.Size = new System.Drawing.Size(53, 20);
            this.lCekis.TabIndex = 5;
            this.lCekis.Text = "Çekiş";
            // 
            // lMaksimumHiz
            // 
            this.lMaksimumHiz.AutoSize = true;
            this.lMaksimumHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMaksimumHiz.Location = new System.Drawing.Point(12, 241);
            this.lMaksimumHiz.Name = "lMaksimumHiz";
            this.lMaksimumHiz.Size = new System.Drawing.Size(124, 20);
            this.lMaksimumHiz.TabIndex = 6;
            this.lMaksimumHiz.Text = "Maksimum Hız";
            // 
            // lArabaTürü
            // 
            this.lArabaTürü.AutoSize = true;
            this.lArabaTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lArabaTürü.Location = new System.Drawing.Point(12, 199);
            this.lArabaTürü.Name = "lArabaTürü";
            this.lArabaTürü.Size = new System.Drawing.Size(98, 20);
            this.lArabaTürü.TabIndex = 7;
            this.lArabaTürü.Text = "Araba Türü";
            // 
            // lBeygirGücü
            // 
            this.lBeygirGücü.AutoSize = true;
            this.lBeygirGücü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBeygirGücü.Location = new System.Drawing.Point(12, 160);
            this.lBeygirGücü.Name = "lBeygirGücü";
            this.lBeygirGücü.Size = new System.Drawing.Size(107, 20);
            this.lBeygirGücü.TabIndex = 8;
            this.lBeygirGücü.Text = "Beygir Gücü";
            // 
            // lKapiSayisi
            // 
            this.lKapiSayisi.AutoSize = true;
            this.lKapiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKapiSayisi.Location = new System.Drawing.Point(12, 119);
            this.lKapiSayisi.Name = "lKapiSayisi";
            this.lKapiSayisi.Size = new System.Drawing.Size(96, 20);
            this.lKapiSayisi.TabIndex = 9;
            this.lKapiSayisi.Text = "Kapı Sayısı";
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lModel.Location = new System.Drawing.Point(12, 80);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(57, 20);
            this.lModel.TabIndex = 10;
            this.lModel.Text = "Model";
            // 
            // lMotorHacmi
            // 
            this.lMotorHacmi.AutoSize = true;
            this.lMotorHacmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMotorHacmi.Location = new System.Drawing.Point(12, 384);
            this.lMotorHacmi.Name = "lMotorHacmi";
            this.lMotorHacmi.Size = new System.Drawing.Size(110, 20);
            this.lMotorHacmi.TabIndex = 11;
            this.lMotorHacmi.Text = "Motor Hacmi";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(151, 83);
            this.tbModel.MaxLength = 100;
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(186, 20);
            this.tbModel.TabIndex = 12;
            // 
            // nudKapiSayisi
            // 
            this.nudKapiSayisi.Location = new System.Drawing.Point(151, 120);
            this.nudKapiSayisi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKapiSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKapiSayisi.Name = "nudKapiSayisi";
            this.nudKapiSayisi.Size = new System.Drawing.Size(186, 20);
            this.nudKapiSayisi.TabIndex = 13;
            this.nudKapiSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tbBeygirGücü
            // 
            this.tbBeygirGücü.Location = new System.Drawing.Point(151, 163);
            this.tbBeygirGücü.MaxLength = 100;
            this.tbBeygirGücü.Name = "tbBeygirGücü";
            this.tbBeygirGücü.Size = new System.Drawing.Size(186, 20);
            this.tbBeygirGücü.TabIndex = 14;
            // 
            // cbArabaTürü
            // 
            this.cbArabaTürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArabaTürü.FormattingEnabled = true;
            this.cbArabaTürü.Items.AddRange(new object[] {
            "Binek",
            "Ticari"});
            this.cbArabaTürü.Location = new System.Drawing.Point(151, 199);
            this.cbArabaTürü.Name = "cbArabaTürü";
            this.cbArabaTürü.Size = new System.Drawing.Size(186, 21);
            this.cbArabaTürü.Sorted = true;
            this.cbArabaTürü.TabIndex = 15;
            // 
            // tbMaksimumHiz
            // 
            this.tbMaksimumHiz.Location = new System.Drawing.Point(151, 244);
            this.tbMaksimumHiz.MaxLength = 100;
            this.tbMaksimumHiz.Name = "tbMaksimumHiz";
            this.tbMaksimumHiz.Size = new System.Drawing.Size(186, 20);
            this.tbMaksimumHiz.TabIndex = 16;
            // 
            // cbCekis
            // 
            this.cbCekis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCekis.FormattingEnabled = true;
            this.cbCekis.Items.AddRange(new object[] {
            "Arkadan İtişli",
            "Dört Çeker",
            "Önden Çekişli"});
            this.cbCekis.Location = new System.Drawing.Point(151, 279);
            this.cbCekis.Name = "cbCekis";
            this.cbCekis.Size = new System.Drawing.Size(186, 21);
            this.cbCekis.Sorted = true;
            this.cbCekis.TabIndex = 17;
            // 
            // tbSifirdanYuzeHizlanma
            // 
            this.tbSifirdanYuzeHizlanma.Location = new System.Drawing.Point(151, 311);
            this.tbSifirdanYuzeHizlanma.MaxLength = 100;
            this.tbSifirdanYuzeHizlanma.Name = "tbSifirdanYuzeHizlanma";
            this.tbSifirdanYuzeHizlanma.Size = new System.Drawing.Size(186, 20);
            this.tbSifirdanYuzeHizlanma.TabIndex = 18;
            // 
            // tbAgirlik
            // 
            this.tbAgirlik.Location = new System.Drawing.Point(151, 348);
            this.tbAgirlik.MaxLength = 100;
            this.tbAgirlik.Name = "tbAgirlik";
            this.tbAgirlik.Size = new System.Drawing.Size(186, 20);
            this.tbAgirlik.TabIndex = 19;
            // 
            // tbMotorHacmi
            // 
            this.tbMotorHacmi.Location = new System.Drawing.Point(151, 386);
            this.tbMotorHacmi.MaxLength = 100;
            this.tbMotorHacmi.Name = "tbMotorHacmi";
            this.tbMotorHacmi.Size = new System.Drawing.Size(186, 20);
            this.tbMotorHacmi.TabIndex = 20;
            // 
            // lSonucId
            // 
            this.lSonucId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucId.Location = new System.Drawing.Point(390, 9);
            this.lSonucId.Name = "lSonucId";
            this.lSonucId.Size = new System.Drawing.Size(327, 21);
            this.lSonucId.TabIndex = 21;
            this.lSonucId.Text = "Id:";
            // 
            // bGöster
            // 
            this.bGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGöster.Location = new System.Drawing.Point(535, 417);
            this.bGöster.Name = "bGöster";
            this.bGöster.Size = new System.Drawing.Size(170, 57);
            this.bGöster.TabIndex = 22;
            this.bGöster.Text = "Göster";
            this.bGöster.UseVisualStyleBackColor = true;
            this.bGöster.Click += new System.EventHandler(this.bGöster_Click);
            // 
            // lSonucMotorHacmi
            // 
            this.lSonucMotorHacmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucMotorHacmi.Location = new System.Drawing.Point(390, 386);
            this.lSonucMotorHacmi.Name = "lSonucMotorHacmi";
            this.lSonucMotorHacmi.Size = new System.Drawing.Size(327, 28);
            this.lSonucMotorHacmi.TabIndex = 23;
            this.lSonucMotorHacmi.Text = "Motor Hacmi:";
            // 
            // lSonucAgirlik
            // 
            this.lSonucAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucAgirlik.Location = new System.Drawing.Point(390, 347);
            this.lSonucAgirlik.Name = "lSonucAgirlik";
            this.lSonucAgirlik.Size = new System.Drawing.Size(327, 30);
            this.lSonucAgirlik.TabIndex = 24;
            this.lSonucAgirlik.Text = "Ağırlık:";
            // 
            // lSonucSifirdanYüzeHizlanma
            // 
            this.lSonucSifirdanYüzeHizlanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucSifirdanYüzeHizlanma.Location = new System.Drawing.Point(390, 310);
            this.lSonucSifirdanYüzeHizlanma.Name = "lSonucSifirdanYüzeHizlanma";
            this.lSonucSifirdanYüzeHizlanma.Size = new System.Drawing.Size(327, 21);
            this.lSonucSifirdanYüzeHizlanma.TabIndex = 25;
            this.lSonucSifirdanYüzeHizlanma.Text = "0-100 Hızlanma:";
            // 
            // lSonucCekis
            // 
            this.lSonucCekis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucCekis.Location = new System.Drawing.Point(390, 272);
            this.lSonucCekis.Name = "lSonucCekis";
            this.lSonucCekis.Size = new System.Drawing.Size(327, 28);
            this.lSonucCekis.TabIndex = 26;
            this.lSonucCekis.Text = "Çekiş:";
            // 
            // lSonucMaksimumHiz
            // 
            this.lSonucMaksimumHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucMaksimumHiz.Location = new System.Drawing.Point(390, 236);
            this.lSonucMaksimumHiz.Name = "lSonucMaksimumHiz";
            this.lSonucMaksimumHiz.Size = new System.Drawing.Size(327, 28);
            this.lSonucMaksimumHiz.TabIndex = 27;
            this.lSonucMaksimumHiz.Text = "Maksimum Hız:";
            // 
            // lSonucArabaTürü
            // 
            this.lSonucArabaTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucArabaTürü.Location = new System.Drawing.Point(390, 201);
            this.lSonucArabaTürü.Name = "lSonucArabaTürü";
            this.lSonucArabaTürü.Size = new System.Drawing.Size(327, 35);
            this.lSonucArabaTürü.TabIndex = 28;
            this.lSonucArabaTürü.Text = "Araba Türü:";
            // 
            // lSonucBeygirGücü
            // 
            this.lSonucBeygirGücü.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucBeygirGücü.Location = new System.Drawing.Point(390, 157);
            this.lSonucBeygirGücü.Name = "lSonucBeygirGücü";
            this.lSonucBeygirGücü.Size = new System.Drawing.Size(327, 35);
            this.lSonucBeygirGücü.TabIndex = 29;
            this.lSonucBeygirGücü.Text = "Beygir Gücü:";
            // 
            // lSonucKapiSayisi
            // 
            this.lSonucKapiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucKapiSayisi.Location = new System.Drawing.Point(390, 114);
            this.lSonucKapiSayisi.Name = "lSonucKapiSayisi";
            this.lSonucKapiSayisi.Size = new System.Drawing.Size(327, 37);
            this.lSonucKapiSayisi.TabIndex = 30;
            this.lSonucKapiSayisi.Text = "Kapı Sayısı:";
            // 
            // lSonucModel
            // 
            this.lSonucModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucModel.Location = new System.Drawing.Point(390, 79);
            this.lSonucModel.Name = "lSonucModel";
            this.lSonucModel.Size = new System.Drawing.Size(327, 35);
            this.lSonucModel.TabIndex = 31;
            this.lSonucModel.Text = "Model:";
            // 
            // lSonucMarka
            // 
            this.lSonucMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonucMarka.Location = new System.Drawing.Point(390, 46);
            this.lSonucMarka.Name = "lSonucMarka";
            this.lSonucMarka.Size = new System.Drawing.Size(327, 21);
            this.lSonucMarka.TabIndex = 32;
            this.lSonucMarka.Text = "Marka:";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lId.Location = new System.Drawing.Point(9, 9);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(25, 20);
            this.lId.TabIndex = 33;
            this.lId.Text = "Id";
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(151, 9);
            this.nudId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(186, 20);
            this.nudId.TabIndex = 34;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(862, 525);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lSonucMarka);
            this.Controls.Add(this.lSonucModel);
            this.Controls.Add(this.lSonucKapiSayisi);
            this.Controls.Add(this.lSonucBeygirGücü);
            this.Controls.Add(this.lSonucArabaTürü);
            this.Controls.Add(this.lSonucMaksimumHiz);
            this.Controls.Add(this.lSonucCekis);
            this.Controls.Add(this.lSonucSifirdanYüzeHizlanma);
            this.Controls.Add(this.lSonucAgirlik);
            this.Controls.Add(this.lSonucMotorHacmi);
            this.Controls.Add(this.bGöster);
            this.Controls.Add(this.lSonucId);
            this.Controls.Add(this.tbMotorHacmi);
            this.Controls.Add(this.tbAgirlik);
            this.Controls.Add(this.tbSifirdanYuzeHizlanma);
            this.Controls.Add(this.cbCekis);
            this.Controls.Add(this.tbMaksimumHiz);
            this.Controls.Add(this.cbArabaTürü);
            this.Controls.Add(this.tbBeygirGücü);
            this.Controls.Add(this.nudKapiSayisi);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.lMotorHacmi);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.lKapiSayisi);
            this.Controls.Add(this.lBeygirGücü);
            this.Controls.Add(this.lArabaTürü);
            this.Controls.Add(this.lMaksimumHiz);
            this.Controls.Add(this.lCekis);
            this.Controls.Add(this.lSifirdanYuzeHizlanma);
            this.Controls.Add(this.lAgirlik);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.lMarka);
            this.Name = "Form1";
            this.Text = "OOPCarİnformation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKapiSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lMarka;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label lAgirlik;
        private System.Windows.Forms.Label lSifirdanYuzeHizlanma;
        private System.Windows.Forms.Label lCekis;
        private System.Windows.Forms.Label lMaksimumHiz;
        private System.Windows.Forms.Label lArabaTürü;
        private System.Windows.Forms.Label lBeygirGücü;
        private System.Windows.Forms.Label lKapiSayisi;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label lMotorHacmi;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.NumericUpDown nudKapiSayisi;
        private System.Windows.Forms.TextBox tbBeygirGücü;
        private System.Windows.Forms.ComboBox cbArabaTürü;
        private System.Windows.Forms.TextBox tbMaksimumHiz;
        private System.Windows.Forms.ComboBox cbCekis;
        private System.Windows.Forms.TextBox tbSifirdanYuzeHizlanma;
        private System.Windows.Forms.TextBox tbAgirlik;
        private System.Windows.Forms.TextBox tbMotorHacmi;
        private System.Windows.Forms.Label lSonucId;
        private System.Windows.Forms.Button bGöster;
        private System.Windows.Forms.Label lSonucMotorHacmi;
        private System.Windows.Forms.Label lSonucAgirlik;
        private System.Windows.Forms.Label lSonucSifirdanYüzeHizlanma;
        private System.Windows.Forms.Label lSonucCekis;
        private System.Windows.Forms.Label lSonucMaksimumHiz;
        private System.Windows.Forms.Label lSonucArabaTürü;
        private System.Windows.Forms.Label lSonucBeygirGücü;
        private System.Windows.Forms.Label lSonucKapiSayisi;
        private System.Windows.Forms.Label lSonucModel;
        private System.Windows.Forms.Label lSonucMarka;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.NumericUpDown nudId;
    }
}

