using System.Windows.Forms;

namespace ProyectoADA
{
    partial class Greedy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greedy));
            this.volverButton = new System.Windows.Forms.Button();
            this.greedyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Label();
            this.movLabel = new System.Windows.Forms.Label();
            this.ceros = new System.Windows.Forms.Label();
            this.mov = new System.Windows.Forms.Label();
            this.registro = new System.Windows.Forms.RichTextBox();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volverButton
            // 
            this.volverButton.BackColor = System.Drawing.Color.Lime;
            this.volverButton.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverButton.ForeColor = System.Drawing.Color.White;
            this.volverButton.Location = new System.Drawing.Point(540, 520);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(200, 46);
            this.volverButton.TabIndex = 0;
            this.volverButton.Text = "VOLVER";
            this.volverButton.UseVisualStyleBackColor = false;
            this.volverButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // greedyLabel
            // 
            this.greedyLabel.AutoSize = true;
            this.greedyLabel.BackColor = System.Drawing.Color.Transparent;
            this.greedyLabel.Font = new System.Drawing.Font("Emulogic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greedyLabel.ForeColor = System.Drawing.Color.White;
            this.greedyLabel.Location = new System.Drawing.Point(433, 35);
            this.greedyLabel.Name = "greedyLabel";
            this.greedyLabel.Size = new System.Drawing.Size(413, 30);
            this.greedyLabel.TabIndex = 1;
            this.greedyLabel.Text = "ALGORITMO GREEDY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Emulogic", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESA UNA CADENA DE CEROS Y UNOS:";
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Emulogic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(575, 144);
            this.Input.MaxLength = 10;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(198, 23);
            this.Input.TabIndex = 4;
            this.Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Start.Enabled = false;
            this.Start.Font = new System.Drawing.Font("Emulogic", 7.749999F);
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(779, 138);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(134, 32);
            this.Start.TabIndex = 5;
            this.Start.Text = "COMENZAR";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.BackColor = System.Drawing.Color.Transparent;
            this.tiempo.Font = new System.Drawing.Font("Emulogic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.ForeColor = System.Drawing.Color.White;
            this.tiempo.Location = new System.Drawing.Point(846, 473);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(265, 20);
            this.tiempo.TabIndex = 6;
            this.tiempo.Text = "Tiempo de Juego:";
            // 
            // movLabel
            // 
            this.movLabel.AutoSize = true;
            this.movLabel.BackColor = System.Drawing.Color.Transparent;
            this.movLabel.Font = new System.Drawing.Font("Emulogic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movLabel.ForeColor = System.Drawing.Color.White;
            this.movLabel.Location = new System.Drawing.Point(46, 226);
            this.movLabel.Name = "movLabel";
            this.movLabel.Size = new System.Drawing.Size(201, 20);
            this.movLabel.TabIndex = 7;
            this.movLabel.Text = "movimientos:";
            // 
            // ceros
            // 
            this.ceros.AutoSize = true;
            this.ceros.BackColor = System.Drawing.Color.Transparent;
            this.ceros.Font = new System.Drawing.Font("Emulogic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceros.ForeColor = System.Drawing.Color.White;
            this.ceros.Location = new System.Drawing.Point(846, 429);
            this.ceros.Name = "ceros";
            this.ceros.Size = new System.Drawing.Size(313, 20);
            this.ceros.TabIndex = 8;
            this.ceros.Text = "ESPACIOS A RECORER:";
            // 
            // mov
            // 
            this.mov.AutoSize = true;
            this.mov.BackColor = System.Drawing.Color.Transparent;
            this.mov.Font = new System.Drawing.Font("Emulogic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov.ForeColor = System.Drawing.Color.White;
            this.mov.Location = new System.Drawing.Point(847, 451);
            this.mov.Name = "mov";
            this.mov.Size = new System.Drawing.Size(201, 20);
            this.mov.TabIndex = 9;
            this.mov.Text = "Movimientos:";
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.Color.White;
            this.registro.Font = new System.Drawing.Font("Emulogic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.registro.Location = new System.Drawing.Point(21, 249);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(251, 280);
            this.registro.TabIndex = 10;
            this.registro.Text = "";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.Font = new System.Drawing.Font("Emulogic", 7.749999F, System.Drawing.FontStyle.Bold);
            this.Error.ForeColor = System.Drawing.Color.White;
            this.Error.Location = new System.Drawing.Point(91, 178);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 15);
            this.Error.TabIndex = 11;
            // 
            // Greedy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoADA.Properties.Resources._333222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.mov);
            this.Controls.Add(this.ceros);
            this.Controls.Add(this.movLabel);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greedyLabel);
            this.Controls.Add(this.volverButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Greedy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy Vs Brute force: Greedy Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label greedyLabel;
        private System.Windows.Forms.Label label1;
        private TextBox Input;
        private Button Start;
        private Label tiempo;
        private Label movLabel;
        private Label ceros;
        private Label mov;
        private RichTextBox registro;
        private Label Error;
    }
}