namespace ARCH_PRODUCTO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUAP1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPSeleccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPOrdenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordContinenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPCalculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCostoTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.examenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUAP1ToolStripMenuItem,
            this.oPSeleccionesToolStripMenuItem,
            this.oPOrdenamientoToolStripMenuItem,
            this.oPCalculoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUAP1ToolStripMenuItem
            // 
            this.mENUAP1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.accesarToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.mENUAP1ToolStripMenuItem.Name = "mENUAP1ToolStripMenuItem";
            this.mENUAP1ToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mENUAP1ToolStripMenuItem.Text = "MENU AP1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // accesarToolStripMenuItem
            // 
            this.accesarToolStripMenuItem.Name = "accesarToolStripMenuItem";
            this.accesarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.accesarToolStripMenuItem.Text = "Accesar";
            this.accesarToolStripMenuItem.Click += new System.EventHandler(this.accesarToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.modificacionesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.mantenimientoToolStripMenuItem.Text = "Operaciones:";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bajasToolStripMenuItem.Text = "Bajas";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // modificacionesToolStripMenuItem
            // 
            this.modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            this.modificacionesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.modificacionesToolStripMenuItem.Text = "Modificaciones";
            this.modificacionesToolStripMenuItem.Click += new System.EventHandler(this.modificacionesToolStripMenuItem_Click);
            // 
            // oPSeleccionesToolStripMenuItem
            // 
            this.oPSeleccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionPorTipoToolStripMenuItem});
            this.oPSeleccionesToolStripMenuItem.Name = "oPSeleccionesToolStripMenuItem";
            this.oPSeleccionesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.oPSeleccionesToolStripMenuItem.Text = "OP Selecciones";
            // 
            // seleccionPorTipoToolStripMenuItem
            // 
            this.seleccionPorTipoToolStripMenuItem.Name = "seleccionPorTipoToolStripMenuItem";
            this.seleccionPorTipoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.seleccionPorTipoToolStripMenuItem.Text = "Seleccion por Tipo";
            this.seleccionPorTipoToolStripMenuItem.Click += new System.EventHandler(this.seleccionPorTipoToolStripMenuItem_Click);
            // 
            // oPOrdenamientoToolStripMenuItem
            // 
            this.oPOrdenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordPrecioToolStripMenuItem,
            this.ordContinenteToolStripMenuItem,
            this.examenToolStripMenuItem});
            this.oPOrdenamientoToolStripMenuItem.Name = "oPOrdenamientoToolStripMenuItem";
            this.oPOrdenamientoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.oPOrdenamientoToolStripMenuItem.Text = "OP Ordenamiento";
            // 
            // ordPrecioToolStripMenuItem
            // 
            this.ordPrecioToolStripMenuItem.Name = "ordPrecioToolStripMenuItem";
            this.ordPrecioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ordPrecioToolStripMenuItem.Text = "Ord Precio";
            this.ordPrecioToolStripMenuItem.Click += new System.EventHandler(this.ordPrecioToolStripMenuItem_Click);
            // 
            // ordContinenteToolStripMenuItem
            // 
            this.ordContinenteToolStripMenuItem.Name = "ordContinenteToolStripMenuItem";
            this.ordContinenteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ordContinenteToolStripMenuItem.Text = "Ord Continente";
            this.ordContinenteToolStripMenuItem.Click += new System.EventHandler(this.ordContinenteToolStripMenuItem_Click);
            // 
            // oPCalculoToolStripMenuItem
            // 
            this.oPCalculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularCostoTotalToolStripMenuItem});
            this.oPCalculoToolStripMenuItem.Name = "oPCalculoToolStripMenuItem";
            this.oPCalculoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.oPCalculoToolStripMenuItem.Text = "OP Calculo";
            // 
            // calcularCostoTotalToolStripMenuItem
            // 
            this.calcularCostoTotalToolStripMenuItem.Name = "calcularCostoTotalToolStripMenuItem";
            this.calcularCostoTotalToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.calcularCostoTotalToolStripMenuItem.Text = "Calcular Costo Total";
            this.calcularCostoTotalToolStripMenuItem.Click += new System.EventHandler(this.calcularCostoTotalToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(168, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 202);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Continente";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(900, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Operación Baja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(481, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Confirmar Baja";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(647, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Cerrar Baja";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(647, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Cerrar Modificaión";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(386, 334);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Confirmar Modificacion";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 285);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 43);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "CLASE PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1020, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CODEGUNNER";
            // 
            // examenToolStripMenuItem
            // 
            this.examenToolStripMenuItem.Name = "examenToolStripMenuItem";
            this.examenToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.examenToolStripMenuItem.Text = "Examen";
            this.examenToolStripMenuItem.Click += new System.EventHandler(this.examenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUAP1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem accesarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem oPSeleccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPOrdenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordPrecioToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem seleccionPorTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPCalculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCostoTotalToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem ordContinenteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem examenToolStripMenuItem;
    }
}

