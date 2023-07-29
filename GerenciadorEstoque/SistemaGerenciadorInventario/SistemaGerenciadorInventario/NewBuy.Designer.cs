﻿namespace SistemaGerenciadorInventario
{
    partial class NewBuy
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
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.btnSelecProd = new System.Windows.Forms.Button();
            this.lblQnt = new System.Windows.Forms.Label();
            this.panelClient = new System.Windows.Forms.Panel();
            this.lblIdn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductQnt = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioAvist = new System.Windows.Forms.RadioButton();
            this.radioParcel = new System.Windows.Forms.RadioButton();
            this.comboValues = new System.Windows.Forms.ComboBox();
            this.numericQnt = new System.Windows.Forms.NumericUpDown();
            this.lblValueTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.numericUpPayed = new System.Windows.Forms.NumericUpDown();
            this.valorTotal = new System.Windows.Forms.Label();
            this.lblTxtRmn = new System.Windows.Forms.Label();
            this.lblRemaing = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelClient.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpPayed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSelectClient.Location = new System.Drawing.Point(150, 190);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(138, 23);
            this.btnSelectClient.TabIndex = 0;
            this.btnSelectClient.Text = "Selecionar Cliente";
            this.btnSelectClient.UseVisualStyleBackColor = false;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // btnSelecProd
            // 
            this.btnSelecProd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelecProd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSelecProd.Location = new System.Drawing.Point(554, 190);
            this.btnSelecProd.Name = "btnSelecProd";
            this.btnSelecProd.Size = new System.Drawing.Size(133, 23);
            this.btnSelecProd.TabIndex = 1;
            this.btnSelecProd.Text = "Selecionar produto";
            this.btnSelecProd.UseVisualStyleBackColor = false;
            this.btnSelecProd.Click += new System.EventHandler(this.btnSelecProd_Click);
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(322, 303);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(62, 13);
            this.lblQnt.TabIndex = 2;
            this.lblQnt.Text = "Quantidade";
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelClient.Controls.Add(this.lblIdn);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.lblSaldo);
            this.panelClient.Controls.Add(this.label18);
            this.panelClient.Controls.Add(this.lblPhone);
            this.panelClient.Controls.Add(this.label8);
            this.panelClient.Controls.Add(this.lblCpf);
            this.panelClient.Controls.Add(this.label6);
            this.panelClient.Controls.Add(this.lblName);
            this.panelClient.Controls.Add(this.label4);
            this.panelClient.Font = new System.Drawing.Font("Noto Sans", 8.249999F);
            this.panelClient.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panelClient.Location = new System.Drawing.Point(30, 35);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(370, 149);
            this.panelClient.TabIndex = 6;
            // 
            // lblIdn
            // 
            this.lblIdn.AutoSize = true;
            this.lblIdn.Location = new System.Drawing.Point(18, 37);
            this.lblIdn.Name = "lblIdn";
            this.lblIdn.Size = new System.Drawing.Size(10, 15);
            this.lblIdn.TabIndex = 17;
            this.lblIdn.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSaldo.Location = new System.Drawing.Point(174, 59);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(11, 13);
            this.lblSaldo.TabIndex = 15;
            this.lblSaldo.Text = ".";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(85, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 15);
            this.label18.TabIndex = 14;
            this.label18.Text = "Saldo devedor";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(174, 93);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(11, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Telefone";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(174, 122);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(11, 13);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "CPF";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(174, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(11, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome do cliente";
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.LightGray;
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Controls.Add(this.lblProductID);
            this.panelProduct.Controls.Add(this.lblProductQnt);
            this.panelProduct.Controls.Add(this.label16);
            this.panelProduct.Controls.Add(this.lblProductType);
            this.panelProduct.Controls.Add(this.label14);
            this.panelProduct.Controls.Add(this.lblProductPrice);
            this.panelProduct.Controls.Add(this.label12);
            this.panelProduct.Controls.Add(this.lblProductName);
            this.panelProduct.Controls.Add(this.label10);
            this.panelProduct.Font = new System.Drawing.Font("Noto Sans", 8.249999F);
            this.panelProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelProduct.Location = new System.Drawing.Point(427, 35);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(370, 149);
            this.panelProduct.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(15, 25);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(10, 15);
            this.lblProductID.TabIndex = 14;
            this.lblProductID.Text = ".";
            // 
            // lblProductQnt
            // 
            this.lblProductQnt.AutoSize = true;
            this.lblProductQnt.Location = new System.Drawing.Point(189, 122);
            this.lblProductQnt.Name = "lblProductQnt";
            this.lblProductQnt.Size = new System.Drawing.Size(10, 15);
            this.lblProductQnt.TabIndex = 13;
            this.lblProductQnt.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(134, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "Tipo";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(189, 91);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(10, 15);
            this.lblProductType.TabIndex = 11;
            this.lblProductType.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Quantidade em estoque";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(189, 57);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(10, 15);
            this.lblProductPrice.TabIndex = 9;
            this.lblProductPrice.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Preço";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(189, 22);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(10, 15);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nome do produto";
            // 
            // radioAvist
            // 
            this.radioAvist.AutoSize = true;
            this.radioAvist.Location = new System.Drawing.Point(14, 30);
            this.radioAvist.Name = "radioAvist";
            this.radioAvist.Size = new System.Drawing.Size(57, 17);
            this.radioAvist.TabIndex = 8;
            this.radioAvist.TabStop = true;
            this.radioAvist.Text = "à Vista";
            this.radioAvist.UseVisualStyleBackColor = true;
            this.radioAvist.CheckedChanged += new System.EventHandler(this.radioAvist_CheckedChanged);
            // 
            // radioParcel
            // 
            this.radioParcel.AutoSize = true;
            this.radioParcel.Location = new System.Drawing.Point(99, 30);
            this.radioParcel.Name = "radioParcel";
            this.radioParcel.Size = new System.Drawing.Size(73, 17);
            this.radioParcel.TabIndex = 9;
            this.radioParcel.TabStop = true;
            this.radioParcel.Text = "Parcelado";
            this.radioParcel.UseVisualStyleBackColor = true;
            this.radioParcel.CheckedChanged += new System.EventHandler(this.radioParcel_CheckedChanged);
            // 
            // comboValues
            // 
            this.comboValues.BackColor = System.Drawing.Color.White;
            this.comboValues.FormattingEnabled = true;
            this.comboValues.Location = new System.Drawing.Point(508, 335);
            this.comboValues.Name = "comboValues";
            this.comboValues.Size = new System.Drawing.Size(187, 21);
            this.comboValues.TabIndex = 10;
            // 
            // numericQnt
            // 
            this.numericQnt.Location = new System.Drawing.Point(445, 301);
            this.numericQnt.Name = "numericQnt";
            this.numericQnt.Size = new System.Drawing.Size(42, 20);
            this.numericQnt.TabIndex = 11;
            this.numericQnt.ValueChanged += new System.EventHandler(this.ChangeNumeric);
            // 
            // lblValueTotal
            // 
            this.lblValueTotal.AutoSize = true;
            this.lblValueTotal.BackColor = System.Drawing.Color.Black;
            this.lblValueTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblValueTotal.Location = new System.Drawing.Point(94, 520);
            this.lblValueTotal.Name = "lblValueTotal";
            this.lblValueTotal.Size = new System.Drawing.Size(13, 20);
            this.lblValueTotal.TabIndex = 13;
            this.lblValueTotal.Text = ".";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(295, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(445, 540);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 32);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Realizar compra";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(307, 429);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(365, 413);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(122, 13);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Data da primeira parcela";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(322, 338);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(102, 13);
            this.lblEnter.TabIndex = 19;
            this.lblEnter.Text = "Entrada de parcelas";
            // 
            // numericUpPayed
            // 
            this.numericUpPayed.Location = new System.Drawing.Point(445, 341);
            this.numericUpPayed.Name = "numericUpPayed";
            this.numericUpPayed.Size = new System.Drawing.Size(42, 20);
            this.numericUpPayed.TabIndex = 20;
            this.numericUpPayed.ValueChanged += new System.EventHandler(this.ChangeNumericNmb_Click);
            // 
            // valorTotal
            // 
            this.valorTotal.AutoSize = true;
            this.valorTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotal.ForeColor = System.Drawing.Color.Lime;
            this.valorTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.valorTotal.Location = new System.Drawing.Point(26, 520);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(71, 20);
            this.valorTotal.TabIndex = 21;
            this.valorTotal.Text = "Valor R$";
            // 
            // lblTxtRmn
            // 
            this.lblTxtRmn.AutoSize = true;
            this.lblTxtRmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTxtRmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtRmn.Location = new System.Drawing.Point(26, 565);
            this.lblTxtRmn.Name = "lblTxtRmn";
            this.lblTxtRmn.Size = new System.Drawing.Size(151, 20);
            this.lblTxtRmn.TabIndex = 22;
            this.lblTxtRmn.Text = "Valor restante R$";
            // 
            // lblRemaing
            // 
            this.lblRemaing.AutoSize = true;
            this.lblRemaing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRemaing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaing.ForeColor = System.Drawing.Color.Lime;
            this.lblRemaing.Location = new System.Drawing.Point(170, 565);
            this.lblRemaing.Name = "lblRemaing";
            this.lblRemaing.Size = new System.Drawing.Size(14, 20);
            this.lblRemaing.TabIndex = 23;
            this.lblRemaing.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAvist);
            this.groupBox1.Controls.Add(this.radioParcel);
            this.groupBox1.Location = new System.Drawing.Point(311, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 66);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "PRODUTO";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 264);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 29;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 588);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(857, 23);
            this.progressBar1.TabIndex = 30;
            // 
            // NewBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(850, 614);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRemaing);
            this.Controls.Add(this.lblTxtRmn);
            this.Controls.Add(this.valorTotal);
            this.Controls.Add(this.numericUpPayed);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblValueTotal);
            this.Controls.Add(this.numericQnt);
            this.Controls.Add(this.comboValues);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.btnSelecProd);
            this.Controls.Add(this.btnSelectClient);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "NewBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova compra";
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpPayed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Button btnSelecProd;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label lblProductQnt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioAvist;
        private System.Windows.Forms.RadioButton radioParcel;
        private System.Windows.Forms.ComboBox comboValues;
        private System.Windows.Forms.NumericUpDown numericQnt;
        private System.Windows.Forms.Label lblValueTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblIdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.NumericUpDown numericUpPayed;
        private System.Windows.Forms.Label valorTotal;
        private System.Windows.Forms.Label lblTxtRmn;
        private System.Windows.Forms.Label lblRemaing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}