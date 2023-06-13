namespace PROVA_2bim
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_gabarito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gabarito
            // 
            this.bt_gabarito.Location = new System.Drawing.Point(660, 45);
            this.bt_gabarito.Name = "bt_gabarito";
            this.bt_gabarito.Size = new System.Drawing.Size(75, 23);
            this.bt_gabarito.TabIndex = 0;
            this.bt_gabarito.Text = "Gabarito";
            this.bt_gabarito.UseVisualStyleBackColor = true;
            this.bt_gabarito.Click += new System.EventHandler(this.bt_gabarito_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_gabarito);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_gabarito;
    }
}

