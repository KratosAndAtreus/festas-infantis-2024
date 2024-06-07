namespace FestasInfantis.WinApp.ModuloAlugueis
{
    partial class TelaAluguelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAluguelForm));
            cmbClientes = new ComboBox();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            cmbTema = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPorcentagemDesconto = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            cmbSinal = new ComboBox();
            groupBox1 = new GroupBox();
            mskHoraTermino = new MaskedTextBox();
            mskHoraInicio = new MaskedTextBox();
            label12 = new Label();
            label11 = new Label();
            dtFesta = new DateTimePicker();
            label10 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            txtBairro = new TextBox();
            label15 = new Label();
            txtRua = new TextBox();
            label14 = new Label();
            txtNumero = new TextBox();
            label17 = new Label();
            txtEstado = new TextBox();
            label16 = new Label();
            txtCidade = new TextBox();
            label13 = new Label();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(71, 6);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(189, 28);
            cmbClientes.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 6;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(47, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(69, 27);
            txtId.TabIndex = 7;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 6;
            label2.Text = "Cliente:";
            // 
            // cmbTema
            // 
            cmbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTema.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(327, 6);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(189, 28);
            cmbTema.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 9);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 6;
            label3.Text = "Tema:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 43);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 6;
            label4.Text = "Sinal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 43);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 6;
            label5.Text = "% de Desconto:";
            // 
            // txtPorcentagemDesconto
            // 
            txtPorcentagemDesconto.Enabled = false;
            txtPorcentagemDesconto.Location = new Point(132, 40);
            txtPorcentagemDesconto.Name = "txtPorcentagemDesconto";
            txtPorcentagemDesconto.ReadOnly = true;
            txtPorcentagemDesconto.Size = new Size(69, 27);
            txtPorcentagemDesconto.TabIndex = 7;
            txtPorcentagemDesconto.Text = "0";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(504, 426);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(610, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbSinal
            // 
            cmbSinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSinal.FormattingEnabled = true;
            cmbSinal.Items.AddRange(new object[] { "40%", "50%" });
            cmbSinal.Location = new Point(71, 40);
            cmbSinal.Name = "cmbSinal";
            cmbSinal.Size = new Size(189, 28);
            cmbSinal.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mskHoraTermino);
            groupBox1.Controls.Add(mskHoraInicio);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dtFesta);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 147);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora:";
            // 
            // mskHoraTermino
            // 
            mskHoraTermino.Location = new Point(136, 100);
            mskHoraTermino.Mask = "00:00";
            mskHoraTermino.Name = "mskHoraTermino";
            mskHoraTermino.Size = new Size(100, 27);
            mskHoraTermino.TabIndex = 2;
            mskHoraTermino.ValidatingType = typeof(DateTime);
            // 
            // mskHoraInicio
            // 
            mskHoraInicio.Location = new Point(136, 59);
            mskHoraInicio.Mask = "00:00";
            mskHoraInicio.Name = "mskHoraInicio";
            mskHoraInicio.Size = new Size(100, 27);
            mskHoraInicio.TabIndex = 2;
            mskHoraInicio.ValidatingType = typeof(DateTime);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 103);
            label12.Name = "label12";
            label12.Size = new Size(124, 20);
            label12.TabIndex = 0;
            label12.Text = "Hora de Termino:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 62);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 0;
            label11.Text = "Hora de Ínicio:";
            // 
            // dtFesta
            // 
            dtFesta.Format = DateTimePickerFormat.Short;
            dtFesta.Location = new Point(136, 26);
            dtFesta.Name = "dtFesta";
            dtFesta.Size = new Size(117, 27);
            dtFesta.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 29);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 0;
            label10.Text = "Data da festa:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(16, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(694, 359);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(686, 326);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados da Festa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBairro);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtRua);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtNumero);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtEstado);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtCidade);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(6, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(674, 143);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados do Endereço:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(97, 98);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(156, 27);
            txtBairro.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(39, 101);
            label15.Name = "label15";
            label15.Size = new Size(52, 20);
            label15.TabIndex = 0;
            label15.Text = "Bairro:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(97, 65);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(571, 27);
            txtRua.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(53, 68);
            label14.Name = "label14";
            label14.Size = new Size(37, 20);
            label14.TabIndex = 0;
            label14.Text = "Rua:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(478, 98);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(190, 27);
            txtNumero.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(406, 101);
            label17.Name = "label17";
            label17.Size = new Size(66, 20);
            label17.TabIndex = 0;
            label17.Text = "Numero:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(478, 32);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(190, 27);
            txtEstado.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(415, 35);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 0;
            label16.Text = "Estado:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(97, 32);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(156, 27);
            txtCidade.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 35);
            label13.Name = "label13";
            label13.Size = new Size(59, 20);
            label13.TabIndex = 0;
            label13.Text = "Cidade:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(cmbClientes);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(cmbTema);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cmbSinal);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(686, 331);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados do Aluguel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(txtPorcentagemDesconto);
            groupBox2.Location = new Point(7, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 149);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 109);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 6;
            label9.Text = "Valor Pendente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(262, 33);
            label8.Name = "label8";
            label8.Size = new Size(108, 40);
            label8.TabIndex = 6;
            label8.Text = "Valor do Tema\r\ncom Desconto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 109);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 6;
            label7.Text = "Vallor do Sinal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 76);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 6;
            label6.Text = "Valor do Tema:";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(380, 106);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(69, 27);
            textBox4.TabIndex = 7;
            textBox4.Text = "0";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(380, 40);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(69, 27);
            textBox3.TabIndex = 7;
            textBox3.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(132, 106);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(69, 27);
            textBox2.TabIndex = 7;
            textBox2.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(132, 73);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(69, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "0";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 477);
            Controls.Add(tabControl1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaAluguelForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private ComboBox cmbTema;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPorcentagemDesconto;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox cmbSinal;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label10;
        private Label label12;
        private Label label11;
        private DateTimePicker dtFesta;
        private TextBox txtCidade;
        private Label label13;
        private TextBox txtBairro;
        private Label label15;
        private TextBox txtRua;
        private Label label14;
        private TextBox txtNumero;
        private Label label17;
        private TextBox txtEstado;
        private Label label16;
        private MaskedTextBox mskHoraTermino;
        private MaskedTextBox mskHoraInicio;
    }
}