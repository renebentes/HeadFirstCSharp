namespace Cap3Guy
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJoeCash = new System.Windows.Forms.Label();
            this.lblBobCash = new System.Windows.Forms.Label();
            this.lblBankCash = new System.Windows.Forms.Label();
            this.btnGiveJoe = new System.Windows.Forms.Button();
            this.btnReceiveBob = new System.Windows.Forms.Button();
            this.btnJoeGivesBob = new System.Windows.Forms.Button();
            this.btnBobGivesJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJoeCash
            // 
            this.lblJoeCash.AutoSize = true;
            this.lblJoeCash.Location = new System.Drawing.Point(8, 9);
            this.lblJoeCash.Name = "lblJoeCash";
            this.lblJoeCash.Size = new System.Drawing.Size(35, 13);
            this.lblJoeCash.TabIndex = 0;
            this.lblJoeCash.Text = "label1";
            // 
            // lblBobCash
            // 
            this.lblBobCash.AutoSize = true;
            this.lblBobCash.Location = new System.Drawing.Point(8, 43);
            this.lblBobCash.Name = "lblBobCash";
            this.lblBobCash.Size = new System.Drawing.Size(35, 13);
            this.lblBobCash.TabIndex = 1;
            this.lblBobCash.Text = "label2";
            // 
            // lblBankCash
            // 
            this.lblBankCash.AutoSize = true;
            this.lblBankCash.Location = new System.Drawing.Point(8, 87);
            this.lblBankCash.Name = "lblBankCash";
            this.lblBankCash.Size = new System.Drawing.Size(35, 13);
            this.lblBankCash.TabIndex = 2;
            this.lblBankCash.Text = "label3";
            // 
            // btnGiveJoe
            // 
            this.btnGiveJoe.Location = new System.Drawing.Point(31, 132);
            this.btnGiveJoe.Name = "btnGiveJoe";
            this.btnGiveJoe.Size = new System.Drawing.Size(89, 37);
            this.btnGiveJoe.TabIndex = 3;
            this.btnGiveJoe.Text = "Dar R$10 para Joe";
            this.btnGiveJoe.UseVisualStyleBackColor = true;
            this.btnGiveJoe.Click += new System.EventHandler(this.btnGiveJoe_Click);
            // 
            // btnReceiveBob
            // 
            this.btnReceiveBob.Location = new System.Drawing.Point(165, 132);
            this.btnReceiveBob.Name = "btnReceiveBob";
            this.btnReceiveBob.Size = new System.Drawing.Size(89, 37);
            this.btnReceiveBob.TabIndex = 4;
            this.btnReceiveBob.Text = "Receber R$5 de Bob";
            this.btnReceiveBob.UseVisualStyleBackColor = true;
            this.btnReceiveBob.Click += new System.EventHandler(this.btnReceiveBob_Click);
            // 
            // btnJoeGivesBob
            // 
            this.btnJoeGivesBob.Location = new System.Drawing.Point(31, 175);
            this.btnJoeGivesBob.Name = "btnJoeGivesBob";
            this.btnJoeGivesBob.Size = new System.Drawing.Size(89, 37);
            this.btnJoeGivesBob.TabIndex = 5;
            this.btnJoeGivesBob.Text = "Joe dá R$10 para Bob";
            this.btnJoeGivesBob.UseVisualStyleBackColor = true;
            this.btnJoeGivesBob.Click += new System.EventHandler(this.btnJoeGivesBob_Click);
            // 
            // btnBobGivesJoe
            // 
            this.btnBobGivesJoe.Location = new System.Drawing.Point(165, 175);
            this.btnBobGivesJoe.Name = "btnBobGivesJoe";
            this.btnBobGivesJoe.Size = new System.Drawing.Size(89, 37);
            this.btnBobGivesJoe.TabIndex = 5;
            this.btnBobGivesJoe.Text = "Bob dá R$10 para Joe";
            this.btnBobGivesJoe.UseVisualStyleBackColor = true;
            this.btnBobGivesJoe.Click += new System.EventHandler(this.btnBobGivesJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.btnBobGivesJoe);
            this.Controls.Add(this.btnJoeGivesBob);
            this.Controls.Add(this.btnReceiveBob);
            this.Controls.Add(this.btnGiveJoe);
            this.Controls.Add(this.lblBankCash);
            this.Controls.Add(this.lblBobCash);
            this.Controls.Add(this.lblJoeCash);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoeCash;
        private System.Windows.Forms.Label lblBobCash;
        private System.Windows.Forms.Label lblBankCash;
        private System.Windows.Forms.Button btnGiveJoe;
        private System.Windows.Forms.Button btnReceiveBob;
        private System.Windows.Forms.Button btnJoeGivesBob;
        private System.Windows.Forms.Button btnBobGivesJoe;
    }
}

