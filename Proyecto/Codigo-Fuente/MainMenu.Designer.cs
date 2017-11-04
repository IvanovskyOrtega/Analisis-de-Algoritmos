using System.Drawing;

namespace ProyectoADA
{
    partial class GreedyVSBruteforce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreedyVSBruteforce));
            this.greedyLabel = new System.Windows.Forms.Label();
            this.fbLabel = new System.Windows.Forms.Label();
            this.gvsfbLabel = new System.Windows.Forms.Label();
            this.greedyRadioButton = new System.Windows.Forms.RadioButton();
            this.fbRadioButton = new System.Windows.Forms.RadioButton();
            this.gvsfbRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.ipnLogo = new System.Windows.Forms.PictureBox();
            this.escomLogo = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ipnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escomLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // greedyLabel
            // 
            this.greedyLabel.AutoSize = true;
            this.greedyLabel.BackColor = System.Drawing.Color.Transparent;
            this.greedyLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greedyLabel.ForeColor = System.Drawing.Color.Transparent;
            this.greedyLabel.Location = new System.Drawing.Point(440, 340);
            this.greedyLabel.Name = "greedyLabel";
            this.greedyLabel.Size = new System.Drawing.Size(364, 27);
            this.greedyLabel.TabIndex = 0;
            this.greedyLabel.Text = "ALGORITMO GREEDY";
            // 
            // fbLabel
            // 
            this.fbLabel.AutoSize = true;
            this.fbLabel.BackColor = System.Drawing.Color.Transparent;
            this.fbLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fbLabel.Location = new System.Drawing.Point(440, 395);
            this.fbLabel.Name = "fbLabel";
            this.fbLabel.Size = new System.Drawing.Size(496, 27);
            this.fbLabel.TabIndex = 1;
            this.fbLabel.Text = "ALGORITMO FUERZA BRUTA";
            // 
            // gvsfbLabel
            // 
            this.gvsfbLabel.AutoSize = true;
            this.gvsfbLabel.BackColor = System.Drawing.Color.Transparent;
            this.gvsfbLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvsfbLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gvsfbLabel.Location = new System.Drawing.Point(440, 450);
            this.gvsfbLabel.Name = "gvsfbLabel";
            this.gvsfbLabel.Size = new System.Drawing.Size(540, 27);
            this.gvsfbLabel.TabIndex = 2;
            this.gvsfbLabel.Text = "GREEDY V.S. FUERZA BRUTA";
            // 
            // greedyRadioButton
            // 
            this.greedyRadioButton.AutoSize = true;
            this.greedyRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.greedyRadioButton.Location = new System.Drawing.Point(410, 350);
            this.greedyRadioButton.Name = "greedyRadioButton";
            this.greedyRadioButton.Size = new System.Drawing.Size(14, 13);
            this.greedyRadioButton.TabIndex = 3;
            this.greedyRadioButton.TabStop = true;
            this.greedyRadioButton.UseVisualStyleBackColor = false;
            // 
            // fbRadioButton
            // 
            this.fbRadioButton.AutoSize = true;
            this.fbRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.fbRadioButton.Location = new System.Drawing.Point(410, 405);
            this.fbRadioButton.Name = "fbRadioButton";
            this.fbRadioButton.Size = new System.Drawing.Size(14, 13);
            this.fbRadioButton.TabIndex = 4;
            this.fbRadioButton.TabStop = true;
            this.fbRadioButton.UseVisualStyleBackColor = false;
            // 
            // gvsfbRadioButton
            // 
            this.gvsfbRadioButton.AutoSize = true;
            this.gvsfbRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.gvsfbRadioButton.Location = new System.Drawing.Point(410, 460);
            this.gvsfbRadioButton.Name = "gvsfbRadioButton";
            this.gvsfbRadioButton.Size = new System.Drawing.Size(14, 13);
            this.gvsfbRadioButton.TabIndex = 5;
            this.gvsfbRadioButton.TabStop = true;
            this.gvsfbRadioButton.UseVisualStyleBackColor = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Lime;
            this.startButton.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.startButton.Location = new System.Drawing.Point(540, 503);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 45);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "INICIAR";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipnLogo
            // 
            this.ipnLogo.BackColor = System.Drawing.Color.Transparent;
            this.ipnLogo.BackgroundImage = global::ProyectoADA.Properties.Resources.IPN_logo_BB9124D61B_seeklogo_com;
            this.ipnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ipnLogo.Location = new System.Drawing.Point(80, 30);
            this.ipnLogo.Name = "ipnLogo";
            this.ipnLogo.Size = new System.Drawing.Size(151, 186);
            this.ipnLogo.TabIndex = 7;
            this.ipnLogo.TabStop = false;
            // 
            // escomLogo
            // 
            this.escomLogo.BackColor = System.Drawing.Color.Transparent;
            this.escomLogo.BackgroundImage = global::ProyectoADA.Properties.Resources.logoescomG;
            this.escomLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.escomLogo.Location = new System.Drawing.Point(1000, 30);
            this.escomLogo.Name = "escomLogo";
            this.escomLogo.Size = new System.Drawing.Size(200, 158);
            this.escomLogo.TabIndex = 8;
            this.escomLogo.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Emulogic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(1, 462);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(331, 91);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "ANALISIS DE ALGORITMOS\r\n3CM2\r\nPROF: EDGARDO AGRIAN FRANCO MARTINEZ\r\nALUMNOS:\r\n-AR" +
    "ROYO MARTINEZ MARCO ANTONIO\r\n-ORTEGA VICTORIANO IVAN\r\n-ROJAS ESQUIVEL MIGUEL";
            // 
            // GreedyVSBruteforce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoADA.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.escomLogo);
            this.Controls.Add(this.ipnLogo);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gvsfbRadioButton);
            this.Controls.Add(this.fbRadioButton);
            this.Controls.Add(this.greedyRadioButton);
            this.Controls.Add(this.gvsfbLabel);
            this.Controls.Add(this.fbLabel);
            this.Controls.Add(this.greedyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GreedyVSBruteforce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy VS Bruteforce";
            ((System.ComponentModel.ISupportInitialize)(this.ipnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escomLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greedyLabel;
        private System.Windows.Forms.Label fbLabel;
        private System.Windows.Forms.Label gvsfbLabel;
        private System.Windows.Forms.RadioButton greedyRadioButton;
        private System.Windows.Forms.RadioButton fbRadioButton;
        private System.Windows.Forms.RadioButton gvsfbRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox ipnLogo;
        private System.Windows.Forms.PictureBox escomLogo;
        private System.Windows.Forms.Label infoLabel;
    }
}

