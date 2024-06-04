namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TabelaClientesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clienteGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clienteGridView).BeginInit();
            SuspendLayout();
            // 
            // clienteGridView
            // 
            clienteGridView.AllowUserToAddRows = false;
            clienteGridView.AllowUserToDeleteRows = false;
            clienteGridView.AllowUserToResizeColumns = false;
            clienteGridView.AllowUserToResizeRows = false;
            clienteGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clienteGridView.Dock = DockStyle.Fill;
            clienteGridView.Location = new Point(0, 0);
            clienteGridView.Name = "clienteGridView";
            clienteGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clienteGridView.Size = new Size(503, 304);
            clienteGridView.TabIndex = 0;
            // 
            // TabelaClientesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clienteGridView);
            Name = "TabelaClientesControl";
            Size = new Size(503, 304);
            ((System.ComponentModel.ISupportInitialize)clienteGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clienteGridView;
    }
}
