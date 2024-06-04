namespace FestasInfantis.WinApp.ModuloItens
{
    partial class TelaItemForm
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
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            label3 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            numValor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(71, 40);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(102, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 11.25F);
            txtDescricao.Location = new Point(102, 70);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(333, 27);
            txtDescricao.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(50, 106);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 0;
            label3.Text = "Valor:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(229, 151);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 3;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(335, 151);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numValor
            // 
            numValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numValor.Location = new Point(102, 104);
            numValor.Name = "numValor";
            numValor.Size = new Size(120, 27);
            numValor.TabIndex = 2;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 196);
            Controls.Add(numValor);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaItemForm";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private Button btnGravar;
        private Button btnCancelar;
        private NumericUpDown numValor;
    }
}