namespace CrudSerialDeserial
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Read = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cognome = new System.Windows.Forms.TextBox();
            this.lstbx_lista = new System.Windows.Forms.ListBox();
            this.txt_ncambia = new System.Windows.Forms.TextBox();
            this.txt_ccambia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(103, 142);
            this.Btn_Create.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(56, 19);
            this.Btn_Create.TabIndex = 0;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click_1);
            // 
            // Btn_Read
            // 
            this.Btn_Read.Location = new System.Drawing.Point(164, 142);
            this.Btn_Read.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Read.Name = "Btn_Read";
            this.Btn_Read.Size = new System.Drawing.Size(56, 19);
            this.Btn_Read.TabIndex = 1;
            this.Btn_Read.Text = "Read";
            this.Btn_Read.UseVisualStyleBackColor = true;
            this.Btn_Read.Click += new System.EventHandler(this.Btn_Read_Click_1);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(232, 142);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(56, 19);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 142);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(124, 84);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(76, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_cognome
            // 
            this.txt_cognome.Location = new System.Drawing.Point(250, 84);
            this.txt_cognome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cognome.Name = "txt_cognome";
            this.txt_cognome.Size = new System.Drawing.Size(76, 20);
            this.txt_cognome.TabIndex = 5;
            // 
            // lstbx_lista
            // 
            this.lstbx_lista.FormattingEnabled = true;
            this.lstbx_lista.Location = new System.Drawing.Point(412, 84);
            this.lstbx_lista.Name = "lstbx_lista";
            this.lstbx_lista.Size = new System.Drawing.Size(138, 134);
            this.lstbx_lista.TabIndex = 6;
            // 
            // txt_ncambia
            // 
            this.txt_ncambia.Location = new System.Drawing.Point(124, 198);
            this.txt_ncambia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ncambia.Name = "txt_ncambia";
            this.txt_ncambia.Size = new System.Drawing.Size(76, 20);
            this.txt_ncambia.TabIndex = 7;
            // 
            // txt_ccambia
            // 
            this.txt_ccambia.Location = new System.Drawing.Point(250, 198);
            this.txt_ccambia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ccambia.Name = "txt_ccambia";
            this.txt_ccambia.Size = new System.Drawing.Size(76, 20);
            this.txt_ccambia.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txt_ccambia);
            this.Controls.Add(this.txt_ncambia);
            this.Controls.Add(this.lstbx_lista);
            this.Controls.Add(this.txt_cognome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Read);
            this.Controls.Add(this.Btn_Create);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Read;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cognome;
        private System.Windows.Forms.ListBox lstbx_lista;
        private System.Windows.Forms.TextBox txt_ncambia;
        private System.Windows.Forms.TextBox txt_ccambia;
    }
}

