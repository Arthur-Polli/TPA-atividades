namespace eeewakawakaee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblNome = new Label();
            lblCarga = new Label();
            lblValorx = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCargaHoraria = new TextBox();
            txtValor = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(105, 73);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(32, 114);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(94, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome do Curso:";
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Location = new Point(32, 159);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(101, 15);
            lblCarga.TabIndex = 2;
            lblCarga.Text = "Carga Horária (h):";
            // 
            // lblValorx
            // 
            lblValorx.AutoSize = true;
            lblValorx.Location = new Point(32, 210);
            lblValorx.Name = "lblValorx";
            lblValorx.Size = new Size(108, 15);
            lblValorx.TabIndex = 3;
            lblValorx.Text = "Valor do Curso(R$):";
            // 
            // txtId
            // 
            txtId.Location = new Point(166, 70);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 23);
            txtId.TabIndex = 4;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(166, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(168, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(166, 156);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(168, 23);
            txtCargaHoraria.TabIndex = 6;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(166, 207);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(168, 23);
            txtValor.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(32, 322);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 49);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtValor);
            Controls.Add(txtCargaHoraria);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblValorx);
            Controls.Add(lblCarga);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblCarga;
        private Label lblValorx;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCargaHoraria;
        private TextBox txtValor;
        private Button btnSalvar;
    }
}
