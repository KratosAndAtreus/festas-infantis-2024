namespace FestasInfantis.WinApp.ModuloTema
{
    partial class ListagemTemaControl
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
            listTemas = new ListBox();
            SuspendLayout();
            // 
            // listTemas
            // 
            listTemas.Dock = DockStyle.Fill;
            listTemas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listTemas.FormattingEnabled = true;
            listTemas.ItemHeight = 20;
            listTemas.Location = new Point(0, 0);
            listTemas.Name = "listTemas";
            listTemas.Size = new Size(398, 249);
            listTemas.TabIndex = 0;
            // 
            // ListagemTemaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTemas);
            Name = "ListagemTemaControl";
            Size = new Size(398, 249);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTemas;
    }
}
