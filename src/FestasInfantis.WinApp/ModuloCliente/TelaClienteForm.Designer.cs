namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            lblId = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtCPF = new TextBox();
            lblCPF = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(85, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(57, 78);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(41, 154);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(113, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(64, 23);
            txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 79);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(284, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(113, 155);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(159, 23);
            txtTelefone.TabIndex = 2;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(308, 187);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(135, 34);
            btnGravar.TabIndex = 3;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(449, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(113, 117);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(159, 23);
            txtCPF.TabIndex = 1;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCPF.Location = new Point(74, 117);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(33, 20);
            lblCPF.TabIndex = 9;
            lblCPF.Text = "CPF";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 233);
            Controls.Add(lblCPF);
            Controls.Add(txtCPF);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "TelaClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtCPF;
        private Label lblCPF;
    }
}