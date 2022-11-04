namespace ValidadorDeFaces
{
    partial class Validador
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
            this.pictureBoxImagemOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxImagemValidada = new System.Windows.Forms.PictureBox();
            this.buttonValidarFoto = new System.Windows.Forms.Button();
            this.comboBoxEquipamentos = new System.Windows.Forms.ComboBox();
            this.labelEquipamentos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialogValidador = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemValidada)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagemOriginal
            // 
            this.pictureBoxImagemOriginal.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImagemOriginal.Name = "pictureBoxImagemOriginal";
            this.pictureBoxImagemOriginal.Size = new System.Drawing.Size(174, 171);
            this.pictureBoxImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagemOriginal.TabIndex = 0;
            this.pictureBoxImagemOriginal.TabStop = false;
            // 
            // pictureBoxImagemValidada
            // 
            this.pictureBoxImagemValidada.Location = new System.Drawing.Point(319, 12);
            this.pictureBoxImagemValidada.Name = "pictureBoxImagemValidada";
            this.pictureBoxImagemValidada.Size = new System.Drawing.Size(174, 171);
            this.pictureBoxImagemValidada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagemValidada.TabIndex = 1;
            this.pictureBoxImagemValidada.TabStop = false;
            // 
            // buttonValidarFoto
            // 
            this.buttonValidarFoto.Enabled = false;
            this.buttonValidarFoto.Location = new System.Drawing.Point(192, 88);
            this.buttonValidarFoto.Name = "buttonValidarFoto";
            this.buttonValidarFoto.Size = new System.Drawing.Size(86, 27);
            this.buttonValidarFoto.TabIndex = 2;
            this.buttonValidarFoto.Text = "Validar Foto";
            this.buttonValidarFoto.UseVisualStyleBackColor = true;
            this.buttonValidarFoto.Click += new System.EventHandler(this.buttonValidarFoto_Click);
            // 
            // comboBoxEquipamentos
            // 
            this.comboBoxEquipamentos.Enabled = false;
            this.comboBoxEquipamentos.FormattingEnabled = true;
            this.comboBoxEquipamentos.Location = new System.Drawing.Point(192, 61);
            this.comboBoxEquipamentos.Name = "comboBoxEquipamentos";
            this.comboBoxEquipamentos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipamentos.TabIndex = 3;
            // 
            // labelEquipamentos
            // 
            this.labelEquipamentos.AutoSize = true;
            this.labelEquipamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipamentos.ForeColor = System.Drawing.Color.White;
            this.labelEquipamentos.Location = new System.Drawing.Point(189, 42);
            this.labelEquipamentos.Name = "labelEquipamentos";
            this.labelEquipamentos.Size = new System.Drawing.Size(98, 16);
            this.labelEquipamentos.TabIndex = 4;
            this.labelEquipamentos.Text = "Equipamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Explorar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogValidador
            // 
            this.openFileDialogValidador.FileName = "openFileDialogValidador";
            // 
            // Validador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelEquipamentos);
            this.Controls.Add(this.comboBoxEquipamentos);
            this.Controls.Add(this.buttonValidarFoto);
            this.Controls.Add(this.pictureBoxImagemValidada);
            this.Controls.Add(this.pictureBoxImagemOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Validador";
            this.ShowIcon = false;
            this.Text = "Validador de Fotos";
            this.Load += new System.EventHandler(this.Validador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemValidada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagemOriginal;
        private System.Windows.Forms.PictureBox pictureBoxImagemValidada;
        private System.Windows.Forms.Button buttonValidarFoto;
        private System.Windows.Forms.ComboBox comboBoxEquipamentos;
        private System.Windows.Forms.Label labelEquipamentos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogValidador;
    }
}

