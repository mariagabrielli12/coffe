namespace coffe
{
    partial class Form1
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
            this.grouplogin = new System.Windows.Forms.GroupBox();
            this.buttonentrar = new System.Windows.Forms.Button();
            this.textsenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textusuário = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupcadastro = new System.Windows.Forms.GroupBox();
            this.buttoncriar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textnovasenha = new System.Windows.Forms.Label();
            this.textnovousuario = new System.Windows.Forms.Label();
            this.texttitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grouplogin.SuspendLayout();
            this.groupcadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grouplogin
            // 
            this.grouplogin.BackColor = System.Drawing.Color.SaddleBrown;
            this.grouplogin.Controls.Add(this.buttonentrar);
            this.grouplogin.Controls.Add(this.textsenha);
            this.grouplogin.Controls.Add(this.textBox2);
            this.grouplogin.Controls.Add(this.textBox1);
            this.grouplogin.Controls.Add(this.textusuário);
            this.grouplogin.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouplogin.Location = new System.Drawing.Point(24, 92);
            this.grouplogin.Name = "grouplogin";
            this.grouplogin.Size = new System.Drawing.Size(307, 251);
            this.grouplogin.TabIndex = 0;
            this.grouplogin.TabStop = false;
            this.grouplogin.Text = "login";
            // 
            // buttonentrar
            // 
            this.buttonentrar.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonentrar.Location = new System.Drawing.Point(99, 205);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(75, 25);
            this.buttonentrar.TabIndex = 5;
            this.buttonentrar.Text = "entrar";
            this.buttonentrar.UseVisualStyleBackColor = true;
            this.buttonentrar.Click += new System.EventHandler(this.buttonentrar_Click);
            // 
            // textsenha
            // 
            this.textsenha.AutoSize = true;
            this.textsenha.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsenha.Location = new System.Drawing.Point(51, 143);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(50, 23);
            this.textsenha.TabIndex = 4;
            this.textsenha.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(121, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textusuário
            // 
            this.textusuário.AutoSize = true;
            this.textusuário.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusuário.Location = new System.Drawing.Point(50, 65);
            this.textusuário.Name = "textusuário";
            this.textusuário.Size = new System.Drawing.Size(59, 23);
            this.textusuário.TabIndex = 0;
            this.textusuário.Text = "Usuário";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Brown;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupcadastro
            // 
            this.groupcadastro.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupcadastro.Controls.Add(this.buttoncriar);
            this.groupcadastro.Controls.Add(this.textBox4);
            this.groupcadastro.Controls.Add(this.textBox3);
            this.groupcadastro.Controls.Add(this.textnovasenha);
            this.groupcadastro.Controls.Add(this.textnovousuario);
            this.groupcadastro.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupcadastro.Location = new System.Drawing.Point(476, 92);
            this.groupcadastro.Name = "groupcadastro";
            this.groupcadastro.Size = new System.Drawing.Size(303, 251);
            this.groupcadastro.TabIndex = 2;
            this.groupcadastro.TabStop = false;
            this.groupcadastro.Text = "cadastro";
            // 
            // buttoncriar
            // 
            this.buttoncriar.Location = new System.Drawing.Point(126, 205);
            this.buttoncriar.Name = "buttoncriar";
            this.buttoncriar.Size = new System.Drawing.Size(75, 23);
            this.buttoncriar.TabIndex = 4;
            this.buttoncriar.Text = "Criar";
            this.buttoncriar.UseVisualStyleBackColor = true;
            this.buttoncriar.Click += new System.EventHandler(this.buttoncriar_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 28);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(126, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textnovasenha
            // 
            this.textnovasenha.AutoSize = true;
            this.textnovasenha.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnovasenha.Location = new System.Drawing.Point(15, 143);
            this.textnovasenha.Name = "textnovasenha";
            this.textnovasenha.Size = new System.Drawing.Size(84, 23);
            this.textnovasenha.TabIndex = 1;
            this.textnovasenha.Text = "Nova senha";
            // 
            // textnovousuario
            // 
            this.textnovousuario.AutoSize = true;
            this.textnovousuario.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnovousuario.Location = new System.Drawing.Point(15, 69);
            this.textnovousuario.Name = "textnovousuario";
            this.textnovousuario.Size = new System.Drawing.Size(93, 23);
            this.textnovousuario.TabIndex = 0;
            this.textnovousuario.Text = "Novo usuário";
            // 
            // texttitulo
            // 
            this.texttitulo.AutoSize = true;
            this.texttitulo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texttitulo.Location = new System.Drawing.Point(337, 29);
            this.texttitulo.Name = "texttitulo";
            this.texttitulo.Size = new System.Drawing.Size(119, 35);
            this.texttitulo.TabIndex = 3;
            this.texttitulo.Text = "Cafezito";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(1, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(-15, -6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 32);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.texttitulo);
            this.Controls.Add(this.groupcadastro);
            this.Controls.Add(this.grouplogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grouplogin.ResumeLayout(false);
            this.grouplogin.PerformLayout();
            this.groupcadastro.ResumeLayout(false);
            this.groupcadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grouplogin;
        private System.Windows.Forms.Label textusuário;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textsenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupcadastro;
        private System.Windows.Forms.Label textnovasenha;
        private System.Windows.Forms.Label textnovousuario;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label texttitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.Button buttoncriar;
    }
}

