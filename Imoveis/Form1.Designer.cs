namespace Imoveis
{
    partial class frmBusca
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
            this.cmbBusca = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvBusca = new System.Windows.Forms.DataGridView();
            this.imgSair = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBusca
            // 
            this.cmbBusca.FormattingEnabled = true;
            this.cmbBusca.Items.AddRange(new object[] {
            "Cidade",
            "Valor",
            "Bairro",
            "Tipo"});
            this.cmbBusca.Location = new System.Drawing.Point(8, 260);
            this.cmbBusca.Name = "cmbBusca";
            this.cmbBusca.Size = new System.Drawing.Size(169, 21);
            this.cmbBusca.TabIndex = 2;
            this.cmbBusca.Text = "Selecione o filtro";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(183, 261);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(347, 20);
            this.txtBusca.TabIndex = 3;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgvBusca
            // 
            this.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusca.Location = new System.Drawing.Point(8, 287);
            this.dgvBusca.Name = "dgvBusca";
            this.dgvBusca.Size = new System.Drawing.Size(757, 269);
            this.dgvBusca.TabIndex = 4;
            // 
            // imgSair
            // 
            this.imgSair.Image = global::Imoveis.Properties.Resources.Sair;
            this.imgSair.Location = new System.Drawing.Point(715, 8);
            this.imgSair.Name = "imgSair";
            this.imgSair.Size = new System.Drawing.Size(50, 42);
            this.imgSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSair.TabIndex = 5;
            this.imgSair.TabStop = false;
            this.imgSair.Click += new System.EventHandler(this.imgSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Imoveis.Properties.Resources._1079601_477153225713483_180034804_n;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(688, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(770, 568);
            this.Controls.Add(this.imgSair);
            this.Controls.Add(this.dgvBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cmbBusca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusca";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvBusca;
        private System.Windows.Forms.PictureBox imgSair;
    }
}

