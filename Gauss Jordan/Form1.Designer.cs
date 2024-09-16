namespace Gauss_Jordan
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
            this.inputPosicion11 = new System.Windows.Forms.TextBox();
            this.inputPosicion13 = new System.Windows.Forms.TextBox();
            this.inputPosicion12 = new System.Windows.Forms.TextBox();
            this.inputPosicion14 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPosicion34 = new System.Windows.Forms.TextBox();
            this.inputPosicion33 = new System.Windows.Forms.TextBox();
            this.inputPosicion32 = new System.Windows.Forms.TextBox();
            this.inputPosicion31 = new System.Windows.Forms.TextBox();
            this.inputPosicion24 = new System.Windows.Forms.TextBox();
            this.inputPosicion23 = new System.Windows.Forms.TextBox();
            this.inputPosicion22 = new System.Windows.Forms.TextBox();
            this.inputPosicion21 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Matrizes = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputY = new System.Windows.Forms.TextBox();
            this.inputZ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrizes)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPosicion11
            // 
            this.inputPosicion11.Location = new System.Drawing.Point(36, 45);
            this.inputPosicion11.Name = "inputPosicion11";
            this.inputPosicion11.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion11.TabIndex = 0;
            // 
            // inputPosicion13
            // 
            this.inputPosicion13.Location = new System.Drawing.Point(185, 41);
            this.inputPosicion13.Name = "inputPosicion13";
            this.inputPosicion13.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion13.TabIndex = 1;
            // 
            // inputPosicion12
            // 
            this.inputPosicion12.Location = new System.Drawing.Point(107, 41);
            this.inputPosicion12.Name = "inputPosicion12";
            this.inputPosicion12.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion12.TabIndex = 2;
            // 
            // inputPosicion14
            // 
            this.inputPosicion14.Location = new System.Drawing.Point(260, 45);
            this.inputPosicion14.Name = "inputPosicion14";
            this.inputPosicion14.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion14.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputPosicion13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputPosicion34);
            this.panel1.Controls.Add(this.inputPosicion33);
            this.panel1.Controls.Add(this.inputPosicion32);
            this.panel1.Controls.Add(this.inputPosicion31);
            this.panel1.Controls.Add(this.inputPosicion24);
            this.panel1.Controls.Add(this.inputPosicion23);
            this.panel1.Controls.Add(this.inputPosicion22);
            this.panel1.Controls.Add(this.inputPosicion21);
            this.panel1.Controls.Add(this.inputPosicion14);
            this.panel1.Controls.Add(this.inputPosicion11);
            this.panel1.Controls.Add(this.inputPosicion12);
            this.panel1.Location = new System.Drawing.Point(60, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 201);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "X3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "X2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X1";
            // 
            // inputPosicion34
            // 
            this.inputPosicion34.Location = new System.Drawing.Point(260, 144);
            this.inputPosicion34.Name = "inputPosicion34";
            this.inputPosicion34.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion34.TabIndex = 11;
            // 
            // inputPosicion33
            // 
            this.inputPosicion33.Location = new System.Drawing.Point(185, 144);
            this.inputPosicion33.Name = "inputPosicion33";
            this.inputPosicion33.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion33.TabIndex = 10;
            // 
            // inputPosicion32
            // 
            this.inputPosicion32.Location = new System.Drawing.Point(107, 144);
            this.inputPosicion32.Name = "inputPosicion32";
            this.inputPosicion32.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion32.TabIndex = 9;
            // 
            // inputPosicion31
            // 
            this.inputPosicion31.Location = new System.Drawing.Point(36, 144);
            this.inputPosicion31.Name = "inputPosicion31";
            this.inputPosicion31.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion31.TabIndex = 8;
            // 
            // inputPosicion24
            // 
            this.inputPosicion24.Location = new System.Drawing.Point(260, 95);
            this.inputPosicion24.Name = "inputPosicion24";
            this.inputPosicion24.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion24.TabIndex = 7;
            // 
            // inputPosicion23
            // 
            this.inputPosicion23.Location = new System.Drawing.Point(185, 95);
            this.inputPosicion23.Name = "inputPosicion23";
            this.inputPosicion23.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion23.TabIndex = 6;
            // 
            // inputPosicion22
            // 
            this.inputPosicion22.Location = new System.Drawing.Point(107, 95);
            this.inputPosicion22.Name = "inputPosicion22";
            this.inputPosicion22.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion22.TabIndex = 5;
            // 
            // inputPosicion21
            // 
            this.inputPosicion21.Location = new System.Drawing.Point(36, 95);
            this.inputPosicion21.Name = "inputPosicion21";
            this.inputPosicion21.Size = new System.Drawing.Size(45, 20);
            this.inputPosicion21.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ingrese la Matriz Aumentada";
            // 
            // Matrizes
            // 
            this.Matrizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1,
            this.x2,
            this.x3,
            this.b});
            this.Matrizes.Location = new System.Drawing.Point(536, 215);
            this.Matrizes.Name = "Matrizes";
            this.Matrizes.Size = new System.Drawing.Size(785, 370);
            this.Matrizes.TabIndex = 6;
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.Name = "x1";
            // 
            // x2
            // 
            this.x2.HeaderText = "X2";
            this.x2.Name = "x2";
            // 
            // x3
            // 
            this.x3.HeaderText = "X3";
            this.x3.Name = "x3";
            // 
            // b
            // 
            this.b.HeaderText = "B";
            this.b.Name = "b";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(764, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Proceso de conversion de la Matriz";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(168, 471);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(135, 37);
            this.calcular.TabIndex = 8;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Intrucciones de Uso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(643, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "2- ingresar los coeficientes de cada uno por ejemplo 2x +3y -z, usted tendria que" +
    " ingresar 2, 3 , 1 de manera \r\n     horizontal dependiendo la fila en que esta p" +
    "osicionado su polinomio\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "1- Ingresar valores Numericos\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "3- darle al boton de calcular";
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(74, 546);
            this.inputX.Name = "inputX";
            this.inputX.ReadOnly = true;
            this.inputX.Size = new System.Drawing.Size(59, 20);
            this.inputX.TabIndex = 13;
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(207, 546);
            this.inputY.Name = "inputY";
            this.inputY.ReadOnly = true;
            this.inputY.Size = new System.Drawing.Size(59, 20);
            this.inputY.TabIndex = 14;
            // 
            // inputZ
            // 
            this.inputZ.Location = new System.Drawing.Point(342, 546);
            this.inputZ.Name = "inputZ";
            this.inputZ.ReadOnly = true;
            this.inputZ.Size = new System.Drawing.Size(59, 20);
            this.inputZ.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 549);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 549);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(309, 549);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 646);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.inputZ);
            this.Controls.Add(this.inputY);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Matrizes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPosicion11;
        private System.Windows.Forms.TextBox inputPosicion13;
        private System.Windows.Forms.TextBox inputPosicion12;
        private System.Windows.Forms.TextBox inputPosicion14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputPosicion24;
        private System.Windows.Forms.TextBox inputPosicion23;
        private System.Windows.Forms.TextBox inputPosicion22;
        private System.Windows.Forms.TextBox inputPosicion21;
        private System.Windows.Forms.TextBox inputPosicion34;
        private System.Windows.Forms.TextBox inputPosicion33;
        private System.Windows.Forms.TextBox inputPosicion32;
        private System.Windows.Forms.TextBox inputPosicion31;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Matrizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputY;
        private System.Windows.Forms.TextBox inputZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

