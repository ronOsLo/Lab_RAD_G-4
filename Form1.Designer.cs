namespace Grupo4LaboratorioRAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.gdv = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.rbt = new System.Windows.Forms.RadioButton();
            this.txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).BeginInit();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(967, 624);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(183, 48);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(799, 145);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(362, 26);
            this.dtp.TabIndex = 1;
            // 
            // gdv
            // 
            this.gdv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gdv.Location = new System.Drawing.Point(342, 267);
            this.gdv.Name = "gdv";
            this.gdv.RowHeadersWidth = 62;
            this.gdv.RowTemplate.Height = 28;
            this.gdv.Size = new System.Drawing.Size(808, 304);
            this.gdv.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(351, 106);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 24);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Etiquetas";
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(342, 191);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(351, 28);
            this.cmb.TabIndex = 4;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.pnl2);
            this.pnl1.Controls.Add(this.lbl3);
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(313, 699);
            this.pnl1.TabIndex = 5;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(72, 58);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(226, 33);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Titulo de la aplicacion";
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl2.Controls.Add(this.lblMenu1);
            this.pnl2.Location = new System.Drawing.Point(3, 173);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(336, 57);
            this.pnl2.TabIndex = 7;
            // 
            // lblMenu1
            // 
            this.lblMenu1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu1.ForeColor = System.Drawing.Color.White;
            this.lblMenu1.Image = ((System.Drawing.Image)(resources.GetObject("lblMenu1.Image")));
            this.lblMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu1.Location = new System.Drawing.Point(36, 20);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(138, 26);
            this.lblMenu1.TabIndex = 8;
            this.lblMenu1.Text = "Menu1";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbt
            // 
            this.rbt.AutoSize = true;
            this.rbt.Location = new System.Drawing.Point(1024, 195);
            this.rbt.Name = "rbt";
            this.rbt.Size = new System.Drawing.Size(126, 24);
            this.rbt.TabIndex = 6;
            this.rbt.TabStop = true;
            this.rbt.Text = "radioButton1";
            this.rbt.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(342, 145);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(351, 26);
            this.txt.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(342, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 30);
            this.panel3.TabIndex = 8;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(671, 39);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(211, 31);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Titulo del Formulario";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(759, 624);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(183, 48);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "button2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(39, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(39, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menu3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 695);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.rbt);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.gdv);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Programa contable";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridView gdv;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.RadioButton rbt;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

