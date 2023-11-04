
namespace SquadHub
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.btTelaCad = new System.Windows.Forms.Button();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btMostrarSenhaLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTelaCad
            // 
            this.btTelaCad.BackColor = System.Drawing.Color.Transparent;
            this.btTelaCad.FlatAppearance.BorderSize = 0;
            this.btTelaCad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaCad.Location = new System.Drawing.Point(495, 801);
            this.btTelaCad.Name = "btTelaCad";
            this.btTelaCad.Size = new System.Drawing.Size(343, 22);
            this.btTelaCad.TabIndex = 0;
            this.btTelaCad.UseVisualStyleBackColor = false;
            this.btTelaCad.Click += new System.EventHandler(this.btTelaCad_Click);
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailLogin.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailLogin.ForeColor = System.Drawing.Color.White;
            this.txtEmailLogin.Location = new System.Drawing.Point(774, 512);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(660, 68);
            this.txtEmailLogin.TabIndex = 3;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtSenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenhaLogin.ForeColor = System.Drawing.Color.White;
            this.txtSenhaLogin.Location = new System.Drawing.Point(774, 608);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(660, 68);
            this.txtSenhaLogin.TabIndex = 4;
            this.txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEntrar.FlatAppearance.BorderSize = 0;
            this.btEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrar.Location = new System.Drawing.Point(1146, 784);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(277, 57);
            this.btEntrar.TabIndex = 5;
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btMostrarSenhaLogin
            // 
            this.btMostrarSenhaLogin.BackColor = System.Drawing.Color.Transparent;
            this.btMostrarSenhaLogin.FlatAppearance.BorderSize = 0;
            this.btMostrarSenhaLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMostrarSenhaLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMostrarSenhaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrarSenhaLogin.Location = new System.Drawing.Point(1453, 627);
            this.btMostrarSenhaLogin.Name = "btMostrarSenhaLogin";
            this.btMostrarSenhaLogin.Size = new System.Drawing.Size(43, 30);
            this.btMostrarSenhaLogin.TabIndex = 18;
            this.btMostrarSenhaLogin.UseVisualStyleBackColor = false;
            this.btMostrarSenhaLogin.Click += new System.EventHandler(this.btMostrarSenhaLogin_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btMostrarSenhaLogin);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.btTelaCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTelaCad;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btMostrarSenhaLogin;
    }
}

