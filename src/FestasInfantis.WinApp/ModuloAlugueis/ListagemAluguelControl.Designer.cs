namespace FestasInfantis.WinApp.ModuloAlugueis
{
    partial class ListagemAluguelControl
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
            listAluguel = new ListBox();
            SuspendLayout();
            // 
            // listAluguel
            // 
            listAluguel.Dock = DockStyle.Fill;
            listAluguel.FormattingEnabled = true;
            listAluguel.ItemHeight = 15;
            listAluguel.Location = new Point(0, 0);
            listAluguel.Name = "listAluguel";
            listAluguel.Size = new Size(622, 386);
            listAluguel.TabIndex = 0;
            // 
            // ListagemAluguelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listAluguel);
            Name = "ListagemAluguelControl";
            Size = new Size(622, 386);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listAluguel;
    }
}
