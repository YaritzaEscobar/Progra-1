
namespace ConversorParcial
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
            this.btnConvertirConversor = new System.Windows.Forms.Button();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertirConversor
            // 
            this.btnConvertirConversor.Location = new System.Drawing.Point(211, 299);
            this.btnConvertirConversor.Name = "btnConvertirConversor";
            this.btnConvertirConversor.Size = new System.Drawing.Size(131, 57);
            this.btnConvertirConversor.TabIndex = 0;
            this.btnConvertirConversor.Text = "Convertir";
            this.btnConvertirConversor.UseVisualStyleBackColor = true;
            this.btnConvertirConversor.Click += new System.EventHandler(this.cboConvertirConversor_Click);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Location = new System.Drawing.Point(136, 47);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(31, 13);
            this.lblTipoConversor.TabIndex = 1;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A:";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Medidas de areas"});
            this.cboTipoConversor.Location = new System.Drawing.Point(211, 38);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(121, 21);
            this.cboTipoConversor.TabIndex = 4;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Items.AddRange(new object[] {
            "Metro cuadrado",
            "Vara cuadrada",
            "Yarda cuadrada",
            "Tareas",
            "Manzana",
            "Hectárea",
            "Pie cuadrado"});
            this.cboDeConversor.Location = new System.Drawing.Point(211, 103);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(121, 21);
            this.cboDeConversor.TabIndex = 5;
            this.cboDeConversor.SelectedIndexChanged += new System.EventHandler(this.cboDeConversor_SelectedIndexChanged);
            // 
            // cboAConversor
            // 
            this.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Items.AddRange(new object[] {
            "Metro cuadrado",
            "Vara cuadrada",
            "Yarda cuadrada",
            "Tareas",
            "Manzana",
            "Hectárea",
            "Pie cuadrado"});
            this.cboAConversor.Location = new System.Drawing.Point(211, 164);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(121, 21);
            this.cboAConversor.TabIndex = 6;
            this.cboAConversor.SelectedIndexChanged += new System.EventHandler(this.cboAConversor_SelectedIndexChanged);
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Location = new System.Drawing.Point(414, 284);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(61, 13);
            this.lblRespuestaConversor.TabIndex = 7;
            this.lblRespuestaConversor.Text = "Respuesta:";
            this.lblRespuestaConversor.Click += new System.EventHandler(this.lblRespuestaConversor_Click);
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Location = new System.Drawing.Point(124, 235);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadConversor.TabIndex = 8;
            this.lblCantidadConversor.Text = "Cantidad:";
            this.lblCantidadConversor.Click += new System.EventHandler(this.lblCantidadConversor_Click);
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(211, 227);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadConversor.TabIndex = 9;
            this.txtCantidadConversor.TextChanged += new System.EventHandler(this.txtCantidadConversor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 455);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.btnConvertirConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
    }
}

