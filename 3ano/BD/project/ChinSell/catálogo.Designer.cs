namespace ChinSell
{
    partial class catálogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catálogo));
            this.lbl_catalogo = new System.Windows.Forms.Label();
            this.p2g4DataSet = new ChinSell.p2g4DataSet();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new ChinSell.p2g4DataSetTableAdapters.PRODUTOTableAdapter();
            this.dgb_catalogo = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.Comprar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_gotoprofile = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_comprartheproduct = new System.Windows.Forms.Button();
            this.txtbox_idproduto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_idproduto = new System.Windows.Forms.Label();
            this.btn_finalizarcompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p2g4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_catalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_catalogo
            // 
            this.lbl_catalogo.AutoSize = true;
            this.lbl_catalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_catalogo.Location = new System.Drawing.Point(280, 9);
            this.lbl_catalogo.Name = "lbl_catalogo";
            this.lbl_catalogo.Size = new System.Drawing.Size(214, 35);
            this.lbl_catalogo.TabIndex = 0;
            this.lbl_catalogo.Text = "Catálogo geral";
            // 
            // p2g4DataSet
            // 
            this.p2g4DataSet.DataSetName = "p2g4DataSet";
            this.p2g4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.p2g4DataSet;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // dgb_catalogo
            // 
            this.dgb_catalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_catalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.product_ID,
            this.Price,
            this.Brand,
            this.Pic,
            this.Comprar});
            this.dgb_catalogo.Location = new System.Drawing.Point(29, 150);
            this.dgb_catalogo.Name = "dgb_catalogo";
            this.dgb_catalogo.RowTemplate.Height = 200;
            this.dgb_catalogo.Size = new System.Drawing.Size(905, 497);
            this.dgb_catalogo.TabIndex = 1;
            // 
            // title
            // 
            this.title.DataPropertyName = "Título";
            this.title.HeaderText = "title";
            this.title.Name = "title";
            // 
            // product_ID
            // 
            this.product_ID.DataPropertyName = "produto_id";
            this.product_ID.HeaderText = "product_ID";
            this.product_ID.Name = "product_ID";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Preço";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Marca";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // Pic
            // 
            this.Pic.DataPropertyName = "Pic";
            this.Pic.HeaderText = "Pic";
            this.Pic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Pic.Name = "Pic";
            this.Pic.Width = 200;
            // 
            // Comprar
            // 
            this.Comprar.HeaderText = "Comprar";
            this.Comprar.Name = "Comprar";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(842, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl_gotoprofile
            // 
            this.lbl_gotoprofile.AutoSize = true;
            this.lbl_gotoprofile.Location = new System.Drawing.Point(829, 86);
            this.lbl_gotoprofile.Name = "lbl_gotoprofile";
            this.lbl_gotoprofile.Size = new System.Drawing.Size(95, 13);
            this.lbl_gotoprofile.TabIndex = 3;
            this.lbl_gotoprofile.Text = "Ir para o meu Perfil";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(931, 23);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 38);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "btn_refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(33, 78);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(98, 49);
            this.btn_comprar.TabIndex = 5;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_comprartheproduct
            // 
            this.btn_comprartheproduct.Location = new System.Drawing.Point(501, 78);
            this.btn_comprartheproduct.Name = "btn_comprartheproduct";
            this.btn_comprartheproduct.Size = new System.Drawing.Size(66, 55);
            this.btn_comprartheproduct.TabIndex = 35;
            this.btn_comprartheproduct.Text = "Pesquisar ID";
            this.btn_comprartheproduct.UseVisualStyleBackColor = true;
            this.btn_comprartheproduct.Visible = false;
            this.btn_comprartheproduct.Click += new System.EventHandler(this.btn_comprartheproduct_Click);
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
            this.txtbox_idproduto.Location = new System.Drawing.Point(259, 86);
            this.txtbox_idproduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_idproduto.Name = "txtbox_idproduto";
            this.txtbox_idproduto.Size = new System.Drawing.Size(235, 33);
            this.txtbox_idproduto.TabIndex = 33;
            this.txtbox_idproduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_idproduto.Visible = false;
            // 
            // lbl_idproduto
            // 
            this.lbl_idproduto.AutoSize = true;
            this.lbl_idproduto.Location = new System.Drawing.Point(172, 94);
            this.lbl_idproduto.Name = "lbl_idproduto";
            this.lbl_idproduto.Size = new System.Drawing.Size(75, 13);
            this.lbl_idproduto.TabIndex = 32;
            this.lbl_idproduto.Text = "ID do produto:";
            this.lbl_idproduto.Visible = false;
            // 
            // btn_finalizarcompra
            // 
            this.btn_finalizarcompra.Location = new System.Drawing.Point(582, 78);
            this.btn_finalizarcompra.Name = "btn_finalizarcompra";
            this.btn_finalizarcompra.Size = new System.Drawing.Size(121, 52);
            this.btn_finalizarcompra.TabIndex = 36;
            this.btn_finalizarcompra.Text = "Finalizar compra";
            this.btn_finalizarcompra.UseVisualStyleBackColor = true;
            this.btn_finalizarcompra.Visible = false;
            this.btn_finalizarcompra.Click += new System.EventHandler(this.btn_finalizarcompra_Click);
            // 
            // catálogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 676);
            this.Controls.Add(this.btn_finalizarcompra);
            this.Controls.Add(this.btn_comprartheproduct);
            this.Controls.Add(this.txtbox_idproduto);
            this.Controls.Add(this.lbl_idproduto);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_gotoprofile);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.dgb_catalogo);
            this.Controls.Add(this.lbl_catalogo);
            this.Name = "catálogo";
            this.Text = "catálogo";
            this.Load += new System.EventHandler(this.catálogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p2g4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_catalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_catalogo;
        private p2g4DataSet p2g4DataSet;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private p2g4DataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.DataGridView dgb_catalogo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_gotoprofile;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewImageColumn Pic;
        private System.Windows.Forms.DataGridViewButtonColumn Comprar;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_comprartheproduct;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbox_idproduto;
        private System.Windows.Forms.Label lbl_idproduto;
        private System.Windows.Forms.Button btn_finalizarcompra;
    }
}