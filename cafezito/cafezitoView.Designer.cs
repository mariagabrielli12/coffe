namespace cafezito
{
    partial class CafezitoView
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
            this.textmenu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncomprar = new System.Windows.Forms.Button();
            this.ltvcomprar = new System.Windows.Forms.ListView();
            this.tdc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbtiposdecafe = new System.Windows.Forms.TextBox();
            this.txbacompanhamentos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textmenu
            // 
            this.textmenu.AutoSize = true;
            this.textmenu.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmenu.Location = new System.Drawing.Point(318, 37);
            this.textmenu.Name = "textmenu";
            this.textmenu.Size = new System.Drawing.Size(100, 44);
            this.textmenu.TabIndex = 0;
            this.textmenu.Text = "Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 19);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(0, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 19);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipos de café:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Acompanhamentos:";
            // 
            // btncomprar
            // 
            this.btncomprar.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomprar.Location = new System.Drawing.Point(343, 392);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(75, 23);
            this.btncomprar.TabIndex = 11;
            this.btncomprar.Text = "Comprar";
            this.btncomprar.UseVisualStyleBackColor = true;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click_1);
            // 
            // ltvcomprar
            // 
            this.ltvcomprar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tdc,
            this.acm});
            this.ltvcomprar.HideSelection = false;
            this.ltvcomprar.Location = new System.Drawing.Point(264, 273);
            this.ltvcomprar.Name = "ltvcomprar";
            this.ltvcomprar.Size = new System.Drawing.Size(241, 97);
            this.ltvcomprar.TabIndex = 12;
            this.ltvcomprar.UseCompatibleStateImageBehavior = false;
            this.ltvcomprar.View = System.Windows.Forms.View.Details;
            this.ltvcomprar.SelectedIndexChanged += new System.EventHandler(this.ltvcomprar_SelectedIndexChanged);
            // 
            // tdc
            // 
            this.tdc.Text = "Tipos de Café";
            this.tdc.Width = 90;
            // 
            // acm
            // 
            this.acm.Text = "Acompanhamentos";
            this.acm.Width = 121;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(680, 136);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 13;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click_1);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(680, 93);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click_1);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(680, 180);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 16;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 17;
            // 
            // txbtiposdecafe
            // 
            this.txbtiposdecafe.Location = new System.Drawing.Point(402, 165);
            this.txbtiposdecafe.Name = "txbtiposdecafe";
            this.txbtiposdecafe.Size = new System.Drawing.Size(100, 20);
            this.txbtiposdecafe.TabIndex = 18;
            // 
            // txbacompanhamentos
            // 
            this.txbacompanhamentos.Location = new System.Drawing.Point(405, 225);
            this.txbacompanhamentos.Name = "txbacompanhamentos";
            this.txbacompanhamentos.Size = new System.Drawing.Size(100, 20);
            this.txbacompanhamentos.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cafés:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Scheherazade", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Café Expresso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 22;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.Font = new System.Drawing.Font("Scheherazade", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 27);
            this.label10.TabIndex = 26;
            this.label10.Text = "Latte Macchiato";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Scheherazade", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 27);
            this.label11.TabIndex = 27;
            this.label11.Text = "Café Gelado\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.Font = new System.Drawing.Font("Scheherazade", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 27);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ristretto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 27);
            this.label13.TabIndex = 29;
            this.label13.Text = "Acompanhamentos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Font = new System.Drawing.Font("Scheherazade", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 27);
            this.label14.TabIndex = 30;
            this.label14.Text = "Pão de Queijo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DimGray;
            this.label16.Font = new System.Drawing.Font("Scheherazade", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 27);
            this.label16.TabIndex = 32;
            this.label16.Text = "Coxinha";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DimGray;
            this.label17.Font = new System.Drawing.Font("Scheherazade", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(35, 343);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 27);
            this.label17.TabIndex = 33;
            this.label17.Text = "Pão na Chapa";
            // 
            // CafezitoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbacompanhamentos);
            this.Controls.Add(this.txbtiposdecafe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.ltvcomprar);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textmenu);
            this.Name = "CafezitoView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textmenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.ListView ltvcomprar;
        private System.Windows.Forms.ColumnHeader tdc;
        private System.Windows.Forms.ColumnHeader acm;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbtiposdecafe;
        private System.Windows.Forms.TextBox txbacompanhamentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

