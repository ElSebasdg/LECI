namespace ChinSell
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
            this.username_input = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password_input = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_input
            // 
            this.username_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_input.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_input.HintForeColor = System.Drawing.Color.Empty;
            this.username_input.HintText = "";
            this.username_input.isPassword = false;
            this.username_input.LineFocusedColor = System.Drawing.Color.Blue;
            this.username_input.LineIdleColor = System.Drawing.Color.Gray;
            this.username_input.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.username_input.LineThickness = 3;
            this.username_input.Location = new System.Drawing.Point(222, 224);
            this.username_input.Margin = new System.Windows.Forms.Padding(4);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(379, 33);
            this.username_input.TabIndex = 0;
            this.username_input.Text = "Username";
            this.username_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username_input.Enter += new System.EventHandler(this.username_input_Enter);
            this.username_input.Leave += new System.EventHandler(this.username_input_Leave);
            // 
            // password_input
            // 
            this.password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_input.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_input.HintForeColor = System.Drawing.Color.Empty;
            this.password_input.HintText = "";
            this.password_input.isPassword = true;
            this.password_input.LineFocusedColor = System.Drawing.Color.Blue;
            this.password_input.LineIdleColor = System.Drawing.Color.Gray;
            this.password_input.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.password_input.LineThickness = 3;
            this.password_input.Location = new System.Drawing.Point(222, 286);
            this.password_input.Margin = new System.Windows.Forms.Padding(4);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(379, 33);
            this.password_input.TabIndex = 1;
            this.password_input.Text = "Password";
            this.password_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_input.Enter += new System.EventHandler(this.password_input_Enter);
            this.password_input.Leave += new System.EventHandler(this.password_input_Leave);
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Location = new System.Drawing.Point(370, 338);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(75, 23);
            this.BTN_LOGIN.TabIndex = 2;
            this.BTN_LOGIN.Text = "Login";
            this.BTN_LOGIN.UseVisualStyleBackColor = true;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(222, 204);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 13);
            this.username.TabIndex = 3;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(222, 266);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 4;
            this.password.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox username_input;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_input;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
    }
}

