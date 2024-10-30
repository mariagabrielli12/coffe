using System.Windows.Forms;

namespace cafezito
{
    partial class FormLogin
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
        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupcadastro = new System.Windows.Forms.GroupBox();
            this.btncriar = new System.Windows.Forms.Button();
            this.txbcadsenha = new System.Windows.Forms.TextBox();
            this.txbcaduser = new System.Windows.Forms.TextBox();
            this.textnovasenha = new System.Windows.Forms.Label();
            this.txbuser = new System.Windows.Forms.Label();
            this.texttitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.groupcadastro.SuspendLayout();
            this.SuspendLayout();
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
            this.groupcadastro.Controls.Add(this.btnlogin);
            this.groupcadastro.Controls.Add(this.btncriar);
            this.groupcadastro.Controls.Add(this.txbcadsenha);
            this.groupcadastro.Controls.Add(this.txbcaduser);
            this.groupcadastro.Controls.Add(this.textnovasenha);
            this.groupcadastro.Controls.Add(this.txbuser);
            this.groupcadastro.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupcadastro.Location = new System.Drawing.Point(239, 96);
            this.groupcadastro.Name = "groupcadastro";
            this.groupcadastro.Size = new System.Drawing.Size(303, 249);
            this.groupcadastro.TabIndex = 2;
            this.groupcadastro.TabStop = false;
            this.groupcadastro.Text = "cadastro";
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(42, 197);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(75, 23);
            this.btncriar.TabIndex = 4;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.buttoncriar_Click_1);
            // 
            // txbcadsenha
            // 
            this.txbcadsenha.Location = new System.Drawing.Point(117, 138);
            this.txbcadsenha.Name = "txbcadsenha";
            this.txbcadsenha.Size = new System.Drawing.Size(108, 28);
            this.txbcadsenha.TabIndex = 3;
            this.txbcadsenha.UseWaitCursor = true;
            this.txbcadsenha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txbcaduser
            // 
            this.txbcaduser.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcaduser.Location = new System.Drawing.Point(126, 65);
            this.txbcaduser.Name = "txbcaduser";
            this.txbcaduser.Size = new System.Drawing.Size(88, 27);
            this.txbcaduser.TabIndex = 2;
            this.txbcaduser.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
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
            // txbuser
            // 
            this.txbuser.AutoSize = true;
            this.txbuser.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbuser.Location = new System.Drawing.Point(15, 69);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(93, 23);
            this.txbuser.TabIndex = 0;
            this.txbuser.Text = "Novo usuário";
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
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(173, 197);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(61, 23);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // FormLogin
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
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.groupcadastro.ResumeLayout(false);
            this.groupcadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupcadastro;
        private System.Windows.Forms.Label textnovasenha;
        private System.Windows.Forms.Label txbuser;
        private System.Windows.Forms.TextBox txbcadsenha;
        private System.Windows.Forms.TextBox txbcaduser;
        private System.Windows.Forms.Label texttitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncriar;
        private Button btnlogin;
    }
}
