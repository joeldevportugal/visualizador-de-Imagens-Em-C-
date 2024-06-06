namespace Visualizador_de_Imagens
{
    partial class FrVisualizador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrVisualizador));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.Limagem = new System.Windows.Forms.ListBox();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnSeguinte = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Lblimagem = new System.Windows.Forms.Label();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.BtnParar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem,
            this.toolStripSeparator3});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.White;
            this.picImagem.Location = new System.Drawing.Point(13, 32);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(632, 466);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 2;
            this.picImagem.TabStop = false;
            // 
            // Limagem
            // 
            this.Limagem.FormattingEnabled = true;
            this.Limagem.ItemHeight = 16;
            this.Limagem.Location = new System.Drawing.Point(652, 32);
            this.Limagem.Name = "Limagem";
            this.Limagem.ScrollAlwaysVisible = true;
            this.Limagem.Size = new System.Drawing.Size(222, 468);
            this.Limagem.TabIndex = 3;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.BackColor = System.Drawing.Color.LightGray;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.ForeColor = System.Drawing.Color.Black;
            this.BtnAnterior.Location = new System.Drawing.Point(12, 504);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(116, 45);
            this.BtnAnterior.TabIndex = 4;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = false;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnSeguinte
            // 
            this.BtnSeguinte.BackColor = System.Drawing.Color.LightGray;
            this.BtnSeguinte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSeguinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeguinte.ForeColor = System.Drawing.Color.Black;
            this.BtnSeguinte.Location = new System.Drawing.Point(134, 504);
            this.BtnSeguinte.Name = "BtnSeguinte";
            this.BtnSeguinte.Size = new System.Drawing.Size(131, 45);
            this.BtnSeguinte.TabIndex = 5;
            this.BtnSeguinte.Text = "Seguinte";
            this.BtnSeguinte.UseVisualStyleBackColor = false;
            this.BtnSeguinte.Click += new System.EventHandler(this.BtnSeguinte_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.LightGray;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(272, 505);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(115, 44);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Lblimagem
            // 
            this.Lblimagem.AutoSize = true;
            this.Lblimagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblimagem.ForeColor = System.Drawing.Color.White;
            this.Lblimagem.Location = new System.Drawing.Point(656, 509);
            this.Lblimagem.Name = "Lblimagem";
            this.Lblimagem.Size = new System.Drawing.Size(154, 25);
            this.Lblimagem.TabIndex = 7;
            this.Lblimagem.Text = "Imagem 0 de 0";
            // 
            // BtnAuto
            // 
            this.BtnAuto.BackColor = System.Drawing.Color.LightGray;
            this.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAuto.Location = new System.Drawing.Point(394, 505);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(116, 44);
            this.BtnAuto.TabIndex = 8;
            this.BtnAuto.Text = "Iniciar";
            this.BtnAuto.UseVisualStyleBackColor = false;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.BackColor = System.Drawing.Color.LightGray;
            this.BtnParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParar.Location = new System.Drawing.Point(517, 504);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(128, 45);
            this.BtnParar.TabIndex = 9;
            this.BtnParar.Text = "Parar";
            this.BtnParar.UseVisualStyleBackColor = false;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrVisualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(880, 556);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.Lblimagem);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSeguinte);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.Limagem);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrVisualizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Imagem dev Joel 2024 Portugal ©";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.ListBox Limagem;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnSeguinte;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label Lblimagem;
        private System.Windows.Forms.Button BtnAuto;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.Timer timer1;
    }
}

