
namespace EjemploStorageBlob
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontenedor = new System.Windows.Forms.TextBox();
            this.btncrearcontenedor = new System.Windows.Forms.Button();
            this.btnsubirblob = new System.Windows.Forms.Button();
            this.btneliminarblob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstcontenedores = new System.Windows.Forms.ListBox();
            this.lsvblobs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contenedor";
            // 
            // txtcontenedor
            // 
            this.txtcontenedor.Location = new System.Drawing.Point(156, 23);
            this.txtcontenedor.Name = "txtcontenedor";
            this.txtcontenedor.Size = new System.Drawing.Size(151, 31);
            this.txtcontenedor.TabIndex = 1;
            // 
            // btncrearcontenedor
            // 
            this.btncrearcontenedor.Location = new System.Drawing.Point(31, 77);
            this.btncrearcontenedor.Name = "btncrearcontenedor";
            this.btncrearcontenedor.Size = new System.Drawing.Size(276, 52);
            this.btncrearcontenedor.TabIndex = 2;
            this.btncrearcontenedor.Text = "Crear contenedor";
            this.btncrearcontenedor.UseVisualStyleBackColor = true;
            this.btncrearcontenedor.Click += new System.EventHandler(this.btncrearcontenedor_Click);
            // 
            // btnsubirblob
            // 
            this.btnsubirblob.Location = new System.Drawing.Point(31, 153);
            this.btnsubirblob.Name = "btnsubirblob";
            this.btnsubirblob.Size = new System.Drawing.Size(276, 52);
            this.btnsubirblob.TabIndex = 3;
            this.btnsubirblob.Text = "Subir blob";
            this.btnsubirblob.UseVisualStyleBackColor = true;
            this.btnsubirblob.Click += new System.EventHandler(this.btnsubirblob_Click);
            // 
            // btneliminarblob
            // 
            this.btneliminarblob.ForeColor = System.Drawing.Color.Red;
            this.btneliminarblob.Location = new System.Drawing.Point(31, 229);
            this.btneliminarblob.Name = "btneliminarblob";
            this.btneliminarblob.Size = new System.Drawing.Size(276, 52);
            this.btneliminarblob.TabIndex = 4;
            this.btneliminarblob.Text = "Eliminar blob";
            this.btneliminarblob.UseVisualStyleBackColor = true;
            this.btneliminarblob.Click += new System.EventHandler(this.btneliminarblob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contenedores";
            // 
            // lstcontenedores
            // 
            this.lstcontenedores.FormattingEnabled = true;
            this.lstcontenedores.ItemHeight = 25;
            this.lstcontenedores.Location = new System.Drawing.Point(351, 52);
            this.lstcontenedores.Name = "lstcontenedores";
            this.lstcontenedores.Size = new System.Drawing.Size(207, 229);
            this.lstcontenedores.TabIndex = 6;
            this.lstcontenedores.SelectedIndexChanged += new System.EventHandler(this.lstcontenedores_SelectedIndexChanged);
            // 
            // lsvblobs
            // 
            this.lsvblobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvblobs.HideSelection = false;
            this.lsvblobs.Location = new System.Drawing.Point(31, 305);
            this.lsvblobs.Name = "lsvblobs";
            this.lsvblobs.Size = new System.Drawing.Size(527, 293);
            this.lsvblobs.TabIndex = 7;
            this.lsvblobs.UseCompatibleStateImageBehavior = false;
            this.lsvblobs.View = System.Windows.Forms.View.Details;
            this.lsvblobs.SelectedIndexChanged += new System.EventHandler(this.lsvblobs_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "URI";
            this.columnHeader1.Width = 430;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SIZE";
            this.columnHeader2.Width = 93;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(575, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(743, 575);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 610);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lsvblobs);
            this.Controls.Add(this.lstcontenedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btneliminarblob);
            this.Controls.Add(this.btnsubirblob);
            this.Controls.Add(this.btncrearcontenedor);
            this.Controls.Add(this.txtcontenedor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontenedor;
        private System.Windows.Forms.Button btncrearcontenedor;
        private System.Windows.Forms.Button btnsubirblob;
        private System.Windows.Forms.Button btneliminarblob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstcontenedores;
        private System.Windows.Forms.ListView lsvblobs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

