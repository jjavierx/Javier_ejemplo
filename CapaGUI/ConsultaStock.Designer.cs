namespace CapaGUI
{
    partial class ConsultaStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_stock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.DataGriewProducto = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(62, 31);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_buscar.TabIndex = 1;
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(177, 31);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(92, 23);
            this.btn_stock.TabIndex = 2;
            this.btn_stock.Text = "Buscar Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(62, 188);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 4;
            // 
            // DataGriewProducto
            // 
            this.DataGriewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewProducto.Location = new System.Drawing.Point(33, 71);
            this.DataGriewProducto.Name = "DataGriewProducto";
            this.DataGriewProducto.Size = new System.Drawing.Size(187, 96);
            this.DataGriewProducto.TabIndex = 5;
            this.DataGriewProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewProducto_CellClick);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(177, 186);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // ConsultaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 279);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.DataGriewProducto);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaStock";
            this.Text = "ConsultaStock";
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.DataGridView DataGriewProducto;
        private System.Windows.Forms.Button btn_actualizar;
    }
}