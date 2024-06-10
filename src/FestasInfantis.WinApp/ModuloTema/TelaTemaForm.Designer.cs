namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTemaForm));
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            tabCadastroItens = new TabControl();
            tabCadastroBasico = new TabPage();
            tabPage2 = new TabPage();
            listBoxItens = new CheckedListBox();
            tabCadastroItens.SuspendLayout();
            tabCadastroBasico.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(46, 51);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Id: ";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(102, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(64, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Título: ";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11.25F);
            txtTitulo.Location = new Point(102, 96);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(230, 27);
            txtTitulo.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(315, 293);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(421, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tabCadastroItens
            // 
            tabCadastroItens.Controls.Add(tabCadastroBasico);
            tabCadastroItens.Controls.Add(tabPage2);
            tabCadastroItens.Location = new Point(12, 12);
            tabCadastroItens.Name = "tabCadastroItens";
            tabCadastroItens.SelectedIndex = 0;
            tabCadastroItens.Size = new Size(513, 275);
            tabCadastroItens.TabIndex = 8;
            // 
            // tabCadastroBasico
            // 
            tabCadastroBasico.Controls.Add(txtId);
            tabCadastroBasico.Controls.Add(txtTitulo);
            tabCadastroBasico.Controls.Add(label2);
            tabCadastroBasico.Controls.Add(label1);
            tabCadastroBasico.Location = new Point(4, 24);
            tabCadastroBasico.Name = "tabCadastroBasico";
            tabCadastroBasico.Padding = new Padding(3);
            tabCadastroBasico.Size = new Size(505, 247);
            tabCadastroBasico.TabIndex = 0;
            tabCadastroBasico.Text = "Cadastro Basico";
            tabCadastroBasico.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBoxItens);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(505, 247);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro de itens";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxItens
            // 
            listBoxItens.Dock = DockStyle.Fill;
            listBoxItens.FormattingEnabled = true;
            listBoxItens.Location = new Point(3, 3);
            listBoxItens.Name = "listBoxItens";
            listBoxItens.Size = new Size(499, 241);
            listBoxItens.TabIndex = 0;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 338);
            Controls.Add(tabCadastroItens);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaTemaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar tema";
            tabCadastroItens.ResumeLayout(false);
            tabCadastroBasico.ResumeLayout(false);
            tabCadastroBasico.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtTitulo;
        private Button btnGravar;
        private Button btnCancelar;
        private TabControl tabCadastroItens;
        private TabPage tabCadastroBasico;
        private TabPage tabPage2;
        private CheckedListBox listBoxItens;
    }
}