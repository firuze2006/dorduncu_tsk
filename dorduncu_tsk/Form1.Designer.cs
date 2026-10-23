namespace dorduncu_tsk
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.numYas = new System.Windows.Forms.NumericUpDown();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.rbQadin = new System.Windows.Forms.RadioButton();
            this.rbKisi = new System.Windows.Forms.RadioButton();
            this.lstTelebeler = new System.Windows.Forms.ListBox();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblKurs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblSiyahi = new System.Windows.Forms.Label();
            this.lblMelumat = new System.Windows.Forms.Label();
            this.grpCins = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).BeginInit();
            this.grpCins.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(113, 74);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 0;
            
            // 
            // numYas
            // 
            this.numYas.Location = new System.Drawing.Point(113, 119);
            this.numYas.Name = "numYas";
            this.numYas.Size = new System.Drawing.Size(120, 22);
            this.numYas.TabIndex = 1;
            // 
            // cmbKurs
            // 
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(112, 169);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(121, 24);
            this.cmbKurs.TabIndex = 3;
            // 
            // rbQadin
            // 
            this.rbQadin.AutoSize = true;
            this.rbQadin.Location = new System.Drawing.Point(0, 21);
            this.rbQadin.Name = "rbQadin";
            this.rbQadin.Size = new System.Drawing.Size(64, 20);
            this.rbQadin.TabIndex = 4;
            this.rbQadin.TabStop = true;
            this.rbQadin.Text = "Qadin";
            this.rbQadin.UseVisualStyleBackColor = true;
            // 
            // rbKisi
            // 
            this.rbKisi.AutoSize = true;
            this.rbKisi.Location = new System.Drawing.Point(88, 21);
            this.rbKisi.Name = "rbKisi";
            this.rbKisi.Size = new System.Drawing.Size(49, 20);
            this.rbKisi.TabIndex = 5;
            this.rbKisi.TabStop = true;
            this.rbKisi.Text = "Kisi";
            this.rbKisi.UseVisualStyleBackColor = true;
            // 
            // lstTelebeler
            // 
            this.lstTelebeler.FormattingEnabled = true;
            this.lstTelebeler.ItemHeight = 16;
            this.lstTelebeler.Location = new System.Drawing.Point(112, 316);
            this.lstTelebeler.Name = "lstTelebeler";
            this.lstTelebeler.Size = new System.Drawing.Size(220, 52);
            this.lstTelebeler.TabIndex = 6;
            this.lstTelebeler.SelectedIndexChanged += new System.EventHandler(this.lstTelebeler_SelectedIndexChanged);
           
            // 
            this.btnElaveEt.Location = new System.Drawing.Point(55, 260);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(75, 23);
            this.btnElaveEt.TabIndex = 7;
            this.btnElaveEt.Text = "Elave et";
            this.btnElaveEt.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(195, 260);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(28, 80);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 16);
            this.lblAd.TabIndex = 9;
            this.lblAd.Text = "Ad:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(28, 119);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(31, 16);
            this.lblYas.TabIndex = 10;
            this.lblYas.Text = "Yas";
            // 
            // lblKurs
            // 
            this.lblKurs.AutoSize = true;
            this.lblKurs.Location = new System.Drawing.Point(28, 169);
            this.lblKurs.Name = "lblKurs";
            this.lblKurs.Size = new System.Drawing.Size(33, 16);
            this.lblKurs.TabIndex = 11;
            this.lblKurs.Text = "Kurs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telebe melumat sistemi";
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(28, 217);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(33, 16);
            this.lblCins.TabIndex = 13;
            this.lblCins.Text = "Cins";
            // 
            // lblSiyahi
            // 
            this.lblSiyahi.AutoSize = true;
            this.lblSiyahi.Location = new System.Drawing.Point(28, 316);
            this.lblSiyahi.Name = "lblSiyahi";
            this.lblSiyahi.Size = new System.Drawing.Size(44, 16);
            this.lblSiyahi.TabIndex = 14;
            this.lblSiyahi.Text = "Siyahi";
            // 
            // lblMelumat
            // 
            this.lblMelumat.AutoSize = true;
            this.lblMelumat.Location = new System.Drawing.Point(28, 392);
            this.lblMelumat.Name = "lblMelumat";
            this.lblMelumat.Size = new System.Drawing.Size(58, 16);
            this.lblMelumat.TabIndex = 15;
            this.lblMelumat.Text = "Melumat";
            // 
            // grpCins
            // 
            this.grpCins.Controls.Add(this.rbKisi);
            this.grpCins.Controls.Add(this.rbQadin);
            this.grpCins.Location = new System.Drawing.Point(100, 204);
            this.grpCins.Name = "grpCins";
            this.grpCins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpCins.Size = new System.Drawing.Size(170, 50);
            this.grpCins.TabIndex = 16;
            this.grpCins.TabStop = false;
            this.grpCins.Text = "Cins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.grpCins);
            this.Controls.Add(this.lblMelumat);
            this.Controls.Add(this.lblSiyahi);
            this.Controls.Add(this.lblCins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKurs);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.lstTelebeler);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.numYas);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).EndInit();
            this.grpCins.ResumeLayout(false);
            this.grpCins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.NumericUpDown numYas;
        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.RadioButton rbQadin;
        private System.Windows.Forms.RadioButton rbKisi;
        private System.Windows.Forms.ListBox lstTelebeler;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblKurs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblSiyahi;
        private System.Windows.Forms.Label lblMelumat;
        private System.Windows.Forms.GroupBox grpCins;
    }
}

