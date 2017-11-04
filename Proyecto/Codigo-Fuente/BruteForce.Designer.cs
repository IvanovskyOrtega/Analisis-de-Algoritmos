using System.Windows.Forms;

namespace ProyectoADA
{
    partial class BruteForce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BruteForce));
            this.volverButton = new System.Windows.Forms.Button();
            this.fbLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.gametimeLabel = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.gtLabel = new System.Windows.Forms.Label();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // fbLabel
            // 
            this.fbLabel.AutoSize = true;
            this.fbLabel.BackColor = System.Drawing.Color.Transparent;
            this.fbLabel.Font = new System.Drawing.Font("Emulogic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbLabel.ForeColor = System.Drawing.Color.White;
            this.fbLabel.Location = new System.Drawing.Point(388, 36);
            this.fbLabel.Name = "fbLabel";
            this.fbLabel.Size = new System.Drawing.Size(563, 30);
            this.fbLabel.TabIndex = 1;
            this.fbLabel.Text = "ALGORITMO FUERZA BRUTA";
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
            // gametimeLabel
            // 
            this.gametimeLabel.AutoSize = true;
            this.gametimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.gametimeLabel.Font = new System.Drawing.Font("Emulogic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gametimeLabel.ForeColor = System.Drawing.Color.White;
            this.gametimeLabel.Location = new System.Drawing.Point(846, 473);
            this.gametimeLabel.Name = "gametimeLabel";
            this.gametimeLabel.Size = new System.Drawing.Size(265, 20);
            this.gametimeLabel.TabIndex = 6;
            this.gametimeLabel.Text = "Tiempo de Juego:";
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
            // gtLabel
            // 
            this.gtLabel.AutoSize = true;
            this.gtLabel.BackColor = System.Drawing.Color.Transparent;
            this.gtLabel.Font = new System.Drawing.Font("Emulogic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtLabel.ForeColor = System.Drawing.Color.White;
            this.gtLabel.Location = new System.Drawing.Point(1139, 469);
            this.gtLabel.Name = "gtLabel";
            this.gtLabel.Size = new System.Drawing.Size(31, 25);
            this.gtLabel.TabIndex = 12;
            this.gtLabel.Text = "0";
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Font = new System.Drawing.Font("Emulogic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRichTextBox.Location = new System.Drawing.Point(21, 247);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.Size = new System.Drawing.Size(252, 285);
            this.logRichTextBox.TabIndex = 13;
            this.logRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Emulogic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "movimientos:";
            // 
            // BruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoADA.Properties.Resources._333222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.gtLabel);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.gametimeLabel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbLabel);
            this.Controls.Add(this.volverButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BruteForce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy Vs Brute force: Brute Force Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label fbLabel;
        private System.Windows.Forms.Label label1;
        private TextBox Input;
        private Button Start;
        private Label gametimeLabel;
        private Label Error;
        private Label gtLabel;
        private RichTextBox logRichTextBox;
        private Label label2;
    }
}