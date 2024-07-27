namespace ChinSell
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.username_txtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.numTele_txtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_tele = new System.Windows.Forms.Label();
            this.dgv_myCatalogo = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_meusProdutos = new System.Windows.Forms.Label();
            this.btn_adicionarProduto = new System.Windows.Forms.Button();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.txtBox_titulo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBox_preco = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_preço = new System.Windows.Forms.Label();
            this.txtBox_marca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_subcategoria = new System.Windows.Forms.ComboBox();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.btn_procurarimagem = new System.Windows.Forms.Button();
            this.txtBox_imagemPath = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_editarProduto = new System.Windows.Forms.Button();
            this.lbl_idproduto = new System.Windows.Forms.Label();
            this.btn_editconfirm = new System.Windows.Forms.Button();
            this.txtbox_idproduto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_idpesquisa = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_eliminarproduto = new System.Windows.Forms.Button();
            this.btn_confirmareliminar = new System.Windows.Forms.Button();
            this.btn_pesquisarideliminate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_myCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 266);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(2, 325);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(93, 13);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Nome de usuário: ";
            // 
            // username_txtBox
            // 
            this.username_txtBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.username_txtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_txtBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.username_txtBox.BorderThickness = 3;
            this.username_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txtBox.Enabled = false;
            this.username_txtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username_txtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_txtBox.isPassword = false;
            this.username_txtBox.Location = new System.Drawing.Point(123, 294);
            this.username_txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(235, 44);
            this.username_txtBox.TabIndex = 3;
            this.username_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numTele_txtBox
            // 
            this.numTele_txtBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.numTele_txtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numTele_txtBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.numTele_txtBox.BorderThickness = 3;
            this.numTele_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTele_txtBox.Enabled = false;
            this.numTele_txtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.numTele_txtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numTele_txtBox.isPassword = false;
            this.numTele_txtBox.Location = new System.Drawing.Point(123, 357);
            this.numTele_txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.numTele_txtBox.Name = "numTele_txtBox";
            this.numTele_txtBox.Size = new System.Drawing.Size(235, 44);
            this.numTele_txtBox.TabIndex = 5;
            this.numTele_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_tele
            // 
            this.lbl_tele.AutoSize = true;
            this.lbl_tele.Location = new System.Drawing.Point(2, 377);
            this.lbl_tele.Name = "lbl_tele";
            this.lbl_tele.Size = new System.Drawing.Size(114, 13);
            this.lbl_tele.TabIndex = 4;
            this.lbl_tele.Text = "Telémovel do usuário: ";
            // 
            // dgv_myCatalogo
            // 
            this.dgv_myCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_myCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.identifier,
            this.Marca,
            this.Pic});
            this.dgv_myCatalogo.Location = new System.Drawing.Point(510, 143);
            this.dgv_myCatalogo.Name = "dgv_myCatalogo";
            this.dgv_myCatalogo.RowHeadersWidth = 51;
            this.dgv_myCatalogo.RowTemplate.Height = 140;
            this.dgv_myCatalogo.Size = new System.Drawing.Size(538, 628);
            this.dgv_myCatalogo.TabIndex = 6;
            this.dgv_myCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_myCatalogo_CellContentClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Título";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Preço";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // identifier
            // 
            this.identifier.DataPropertyName = "produto_id";
            this.identifier.HeaderText = "ID";
            this.identifier.Name = "identifier";
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Pic
            // 
            this.Pic.DataPropertyName = "Pic";
            this.Pic.HeaderText = "Pic";
            this.Pic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Pic.MinimumWidth = 6;
            this.Pic.Name = "Pic";
            this.Pic.Width = 125;
            // 
            // lbl_meusProdutos
            // 
            this.lbl_meusProdutos.AutoSize = true;
            this.lbl_meusProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meusProdutos.Location = new System.Drawing.Point(682, 78);
            this.lbl_meusProdutos.Name = "lbl_meusProdutos";
            this.lbl_meusProdutos.Size = new System.Drawing.Size(254, 39);
            this.lbl_meusProdutos.TabIndex = 7;
            this.lbl_meusProdutos.Text = "Meus Produtos:";
            // 
            // btn_adicionarProduto
            // 
            this.btn_adicionarProduto.Location = new System.Drawing.Point(29, 429);
            this.btn_adicionarProduto.Name = "btn_adicionarProduto";
            this.btn_adicionarProduto.Size = new System.Drawing.Size(109, 44);
            this.btn_adicionarProduto.TabIndex = 8;
            this.btn_adicionarProduto.Text = "Adicionar um produto";
            this.btn_adicionarProduto.UseVisualStyleBackColor = true;
            this.btn_adicionarProduto.Click += new System.EventHandler(this.btb_adicionarProduto_Click);
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Location = new System.Drawing.Point(59, 537);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(38, 13);
            this.lbl_Título.TabIndex = 9;
            this.lbl_Título.Text = "Título:";
            this.lbl_Título.Visible = false;
            // 
            // txtBox_titulo
            // 
            this.txtBox_titulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_titulo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBox_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_titulo.HintForeColor = System.Drawing.Color.Empty;
            this.txtBox_titulo.HintText = "";
            this.txtBox_titulo.isPassword = false;
            this.txtBox_titulo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBox_titulo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBox_titulo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBox_titulo.LineThickness = 3;
            this.txtBox_titulo.Location = new System.Drawing.Point(113, 528);
            this.txtBox_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_titulo.Name = "txtBox_titulo";
            this.txtBox_titulo.Size = new System.Drawing.Size(290, 33);
            this.txtBox_titulo.TabIndex = 10;
            this.txtBox_titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_titulo.Visible = false;
            this.txtBox_titulo.OnValueChanged += new System.EventHandler(this.txtBox_titulo_OnValueChanged);
            // 
            // txtBox_preco
            // 
            this.txtBox_preco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_preco.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBox_preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_preco.HintForeColor = System.Drawing.Color.Empty;
            this.txtBox_preco.HintText = "";
            this.txtBox_preco.isPassword = false;
            this.txtBox_preco.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBox_preco.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBox_preco.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBox_preco.LineThickness = 3;
            this.txtBox_preco.Location = new System.Drawing.Point(113, 578);
            this.txtBox_preco.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_preco.Name = "txtBox_preco";
            this.txtBox_preco.Size = new System.Drawing.Size(290, 33);
            this.txtBox_preco.TabIndex = 12;
            this.txtBox_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_preco.Visible = false;
            this.txtBox_preco.OnValueChanged += new System.EventHandler(this.txtBox_preco_OnValueChanged);
            this.txtBox_preco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_preco_KeyPress);
            // 
            // lbl_preço
            // 
            this.lbl_preço.AutoSize = true;
            this.lbl_preço.Location = new System.Drawing.Point(57, 585);
            this.lbl_preço.Name = "lbl_preço";
            this.lbl_preço.Size = new System.Drawing.Size(38, 13);
            this.lbl_preço.TabIndex = 11;
            this.lbl_preço.Text = "Preço:";
            this.lbl_preço.Visible = false;
            // 
            // txtBox_marca
            // 
            this.txtBox_marca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_marca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBox_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_marca.HintForeColor = System.Drawing.Color.Empty;
            this.txtBox_marca.HintText = "";
            this.txtBox_marca.isPassword = false;
            this.txtBox_marca.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBox_marca.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBox_marca.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBox_marca.LineThickness = 3;
            this.txtBox_marca.Location = new System.Drawing.Point(113, 628);
            this.txtBox_marca.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_marca.Name = "txtBox_marca";
            this.txtBox_marca.Size = new System.Drawing.Size(290, 33);
            this.txtBox_marca.TabIndex = 14;
            this.txtBox_marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_marca.Visible = false;
            this.txtBox_marca.OnValueChanged += new System.EventHandler(this.txtBox_marca_OnValueChanged);
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(57, 638);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 13);
            this.lbl_marca.TabIndex = 13;
            this.lbl_marca.Text = "Marca:";
            this.lbl_marca.Visible = false;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(44, 690);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(55, 13);
            this.lbl_categoria.TabIndex = 15;
            this.lbl_categoria.Text = "Categoria:";
            this.lbl_categoria.Visible = false;
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Location = new System.Drawing.Point(113, 687);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(213, 21);
            this.comboBox_categoria.TabIndex = 17;
            this.comboBox_categoria.Visible = false;
            this.comboBox_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_categoria_SelectedIndexChanged);
            // 
            // comboBox_subcategoria
            // 
            this.comboBox_subcategoria.FormattingEnabled = true;
            this.comboBox_subcategoria.Location = new System.Drawing.Point(113, 726);
            this.comboBox_subcategoria.Name = "comboBox_subcategoria";
            this.comboBox_subcategoria.Size = new System.Drawing.Size(213, 21);
            this.comboBox_subcategoria.TabIndex = 19;
            this.comboBox_subcategoria.Visible = false;
            this.comboBox_subcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_subcategoria_SelectedIndexChanged);
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.Location = new System.Drawing.Point(24, 729);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(77, 13);
            this.lbl_subcategoria.TabIndex = 18;
            this.lbl_subcategoria.Text = "Sub Categoria:";
            this.lbl_subcategoria.Visible = false;
            // 
            // btn_procurarimagem
            // 
            this.btn_procurarimagem.Location = new System.Drawing.Point(29, 761);
            this.btn_procurarimagem.Name = "btn_procurarimagem";
            this.btn_procurarimagem.Size = new System.Drawing.Size(75, 49);
            this.btn_procurarimagem.TabIndex = 20;
            this.btn_procurarimagem.Text = "Procurar Imagem:";
            this.btn_procurarimagem.UseVisualStyleBackColor = true;
            this.btn_procurarimagem.Visible = false;
            this.btn_procurarimagem.Click += new System.EventHandler(this.btn_procurarimagem_Click);
            // 
            // txtBox_imagemPath
            // 
            this.txtBox_imagemPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_imagemPath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBox_imagemPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_imagemPath.HintForeColor = System.Drawing.Color.Empty;
            this.txtBox_imagemPath.HintText = "";
            this.txtBox_imagemPath.isPassword = false;
            this.txtBox_imagemPath.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBox_imagemPath.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBox_imagemPath.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBox_imagemPath.LineThickness = 3;
            this.txtBox_imagemPath.Location = new System.Drawing.Point(101, 777);
            this.txtBox_imagemPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_imagemPath.Name = "txtBox_imagemPath";
            this.txtBox_imagemPath.Size = new System.Drawing.Size(290, 33);
            this.txtBox_imagemPath.TabIndex = 21;
            this.txtBox_imagemPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_imagemPath.Visible = false;
            this.txtBox_imagemPath.OnValueChanged += new System.EventHandler(this.txtBox_imagemPath_OnValueChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(633, 789);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 36);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Confirmar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_editarProduto
            // 
            this.btn_editarProduto.Location = new System.Drawing.Point(162, 429);
            this.btn_editarProduto.Name = "btn_editarProduto";
            this.btn_editarProduto.Size = new System.Drawing.Size(105, 44);
            this.btn_editarProduto.TabIndex = 23;
            this.btn_editarProduto.Text = "Editar um produto";
            this.btn_editarProduto.UseVisualStyleBackColor = true;
            this.btn_editarProduto.Click += new System.EventHandler(this.btn_editarProduto_Click);
            // 
            // lbl_idproduto
            // 
            this.lbl_idproduto.AutoSize = true;
            this.lbl_idproduto.Location = new System.Drawing.Point(26, 487);
            this.lbl_idproduto.Name = "lbl_idproduto";
            this.lbl_idproduto.Size = new System.Drawing.Size(75, 13);
            this.lbl_idproduto.TabIndex = 24;
            this.lbl_idproduto.Text = "ID do produto:";
            this.lbl_idproduto.Visible = false;
            this.lbl_idproduto.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_editconfirm
            // 
            this.btn_editconfirm.Location = new System.Drawing.Point(510, 789);
            this.btn_editconfirm.Name = "btn_editconfirm";
            this.btn_editconfirm.Size = new System.Drawing.Size(117, 36);
            this.btn_editconfirm.TabIndex = 26;
            this.btn_editconfirm.Text = "Confirmar edição";
            this.btn_editconfirm.UseVisualStyleBackColor = true;
            this.btn_editconfirm.Visible = false;
            this.btn_editconfirm.Click += new System.EventHandler(this.btn_editconfirm_Click);
            // 
            // txtbox_idproduto
            // 
            this.txtbox_idproduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_idproduto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbox_idproduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_idproduto.HintForeColor = System.Drawing.Color.Empty;
            this.txtbox_idproduto.HintText = "";
            this.txtbox_idproduto.isPassword = false;
            this.txtbox_idproduto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtbox_idproduto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbox_idproduto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbox_idproduto.LineThickness = 3;
            this.txtbox_idproduto.Location = new System.Drawing.Point(113, 479);
            this.txtbox_idproduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_idproduto.Name = "txtbox_idproduto";
            this.txtbox_idproduto.Size = new System.Drawing.Size(235, 33);
            this.txtbox_idproduto.TabIndex = 25;
            this.txtbox_idproduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_idproduto.Visible = false;
            this.txtbox_idproduto.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // btn_idpesquisa
            // 
            this.btn_idpesquisa.Location = new System.Drawing.Point(355, 487);
            this.btn_idpesquisa.Name = "btn_idpesquisa";
            this.btn_idpesquisa.Size = new System.Drawing.Size(66, 34);
            this.btn_idpesquisa.TabIndex = 27;
            this.btn_idpesquisa.Text = "Pesquisar ID";
            this.btn_idpesquisa.UseVisualStyleBackColor = true;
            this.btn_idpesquisa.Visible = false;
            this.btn_idpesquisa.Click += new System.EventHandler(this.btn_idpesquisa_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(937, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(111, 56);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.Text = "Refresh form";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_eliminarproduto
            // 
            this.btn_eliminarproduto.Location = new System.Drawing.Point(286, 429);
            this.btn_eliminarproduto.Name = "btn_eliminarproduto";
            this.btn_eliminarproduto.Size = new System.Drawing.Size(105, 45);
            this.btn_eliminarproduto.TabIndex = 29;
            this.btn_eliminarproduto.Text = "Eliminar produto";
            this.btn_eliminarproduto.UseVisualStyleBackColor = true;
            this.btn_eliminarproduto.Click += new System.EventHandler(this.btn_eliminarproduto_Click);
            // 
            // btn_confirmareliminar
            // 
            this.btn_confirmareliminar.Location = new System.Drawing.Point(756, 789);
            this.btn_confirmareliminar.Name = "btn_confirmareliminar";
            this.btn_confirmareliminar.Size = new System.Drawing.Size(117, 36);
            this.btn_confirmareliminar.TabIndex = 30;
            this.btn_confirmareliminar.Text = "Eliminar";
            this.btn_confirmareliminar.UseVisualStyleBackColor = true;
            this.btn_confirmareliminar.Visible = false;
            this.btn_confirmareliminar.Click += new System.EventHandler(this.btn_confirmareliminar_Click);
            // 
            // btn_pesquisarideliminate
            // 
            this.btn_pesquisarideliminate.Location = new System.Drawing.Point(355, 487);
            this.btn_pesquisarideliminate.Name = "btn_pesquisarideliminate";
            this.btn_pesquisarideliminate.Size = new System.Drawing.Size(66, 55);
            this.btn_pesquisarideliminate.TabIndex = 31;
            this.btn_pesquisarideliminate.Text = "Pesquisar ID para eliminar";
            this.btn_pesquisarideliminate.UseVisualStyleBackColor = true;
            this.btn_pesquisarideliminate.Visible = false;
            this.btn_pesquisarideliminate.Click += new System.EventHandler(this.btn_pesquisarideliminate_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1096, 857);
            this.Controls.Add(this.btn_pesquisarideliminate);
            this.Controls.Add(this.btn_confirmareliminar);
            this.Controls.Add(this.btn_eliminarproduto);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_idpesquisa);
            this.Controls.Add(this.btn_editconfirm);
            this.Controls.Add(this.txtbox_idproduto);
            this.Controls.Add(this.lbl_idproduto);
            this.Controls.Add(this.btn_editarProduto);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtBox_imagemPath);
            this.Controls.Add(this.btn_procurarimagem);
            this.Controls.Add(this.comboBox_subcategoria);
            this.Controls.Add(this.lbl_subcategoria);
            this.Controls.Add(this.comboBox_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txtBox_marca);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.txtBox_preco);
            this.Controls.Add(this.lbl_preço);
            this.Controls.Add(this.txtBox_titulo);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.btn_adicionarProduto);
            this.Controls.Add(this.lbl_meusProdutos);
            this.Controls.Add(this.dgv_myCatalogo);
            this.Controls.Add(this.numTele_txtBox);
            this.Controls.Add(this.lbl_tele);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_myCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_user;
        private Bunifu.Framework.UI.BunifuMetroTextbox username_txtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox numTele_txtBox;
        private System.Windows.Forms.Label lbl_tele;
        private System.Windows.Forms.DataGridView dgv_myCatalogo;
        private System.Windows.Forms.Label lbl_meusProdutos;
        private System.Windows.Forms.Button btn_adicionarProduto;
        private System.Windows.Forms.Label lbl_Título;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBox_titulo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBox_preco;
        private System.Windows.Forms.Label lbl_preço;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBox_marca;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.ComboBox comboBox_subcategoria;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.Button btn_procurarimagem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBox_imagemPath;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_editarProduto;
        private System.Windows.Forms.Label lbl_idproduto;
        private System.Windows.Forms.Button btn_editconfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_idproduto;
        private System.Windows.Forms.Button btn_idpesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewImageColumn Pic;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_eliminarproduto;
        private System.Windows.Forms.Button btn_confirmareliminar;
        private System.Windows.Forms.Button btn_pesquisarideliminate;
    }
}