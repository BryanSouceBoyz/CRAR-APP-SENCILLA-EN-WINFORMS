namespace Aplicacion_Sencilla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnombre = new TextBox();
            txtedad = new TextBox();
            btnguadar = new Button();
            btnlimpiar = new Button();
            grilla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 66);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(126, 24);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(206, 27);
            txtnombre.TabIndex = 3;
            txtnombre.TextChanged += textBox1_TextChanged;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(126, 66);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(206, 27);
            txtedad.TabIndex = 4;
            // 
            // btnguadar
            // 
            btnguadar.Location = new Point(371, 66);
            btnguadar.Name = "btnguadar";
            btnguadar.Size = new Size(94, 34);
            btnguadar.TabIndex = 5;
            btnguadar.Text = "Guardar";
            btnguadar.UseVisualStyleBackColor = true;
            btnguadar.Click += btnguadar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(371, 24);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 6;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(32, 143);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(433, 213);
            grilla.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grilla);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguadar);
            Controls.Add(txtedad);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Nombre";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnombre;
        private TextBox txtedad;
        private Button btnguadar;
        private Button btnlimpiar;
        private DataGridView grilla;
    }
}
