namespace WindowsFormsApplication1
{
    partial class Frm_login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mTB_senha = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Brasao_novaiguaçu;
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // btn_cancela
            // 
            this.btn_cancela.Location = new System.Drawing.Point(393, 179);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(75, 23);
            this.btn_cancela.TabIndex = 7;
            this.btn_cancela.Text = "Cancela";
            this.btn_cancela.UseVisualStyleBackColor = true;
            this.btn_cancela.Click += new System.EventHandler(this.btn_cancela_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Entra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(231, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pre-matricula para 2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 64);
            this.label1.TabIndex = 33;
            this.label1.Text = "ESTADO DO RIO DE JANEIRO\r\nPREFEITURA DA CIDADE DE NOVA IGUAÇU\r\nSECRETARIA MUNICIP" +
    "AL DE EDUCAÇÃO\r\nASSESSORIA TÉCNICA DE GESTÃO PEDAGÓGICA";
            // 
            // mTB_senha
            // 
            this.mTB_senha.Location = new System.Drawing.Point(233, 154);
            this.mTB_senha.Name = "mTB_senha";
            this.mTB_senha.PasswordChar = '*';
            this.mTB_senha.Size = new System.Drawing.Size(274, 20);
            this.mTB_senha.TabIndex = 1;
            this.mTB_senha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTB_senha_MaskInputRejected);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(566, 208);
            this.ControlBox = false;
            this.Controls.Add(this.mTB_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTB_senha;
    }
}