using System.Windows.Forms;

namespace ProyectoADA
{
    partial class BFvsG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BFvsG));
            this.volverButton = new System.Windows.Forms.Button();
            this.gvsfbLabel = new System.Windows.Forms.Label();
            this.cargarArchivo = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.fbTextBox = new System.Windows.Forms.RichTextBox();
            this.greedyTextBox = new System.Windows.Forms.RichTextBox();
            this.progressGreedy = new System.Windows.Forms.ProgressBar();
            this.progressFB = new System.Windows.Forms.ProgressBar();
            this.winnerLabel = new System.Windows.Forms.Label();
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
            // gvsfbLabel
            // 
            this.gvsfbLabel.AutoSize = true;
            this.gvsfbLabel.BackColor = System.Drawing.Color.Transparent;
            this.gvsfbLabel.Font = new System.Drawing.Font("Emulogic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvsfbLabel.ForeColor = System.Drawing.Color.White;
            this.gvsfbLabel.Location = new System.Drawing.Point(360, 9);
            this.gvsfbLabel.Name = "gvsfbLabel";
            this.gvsfbLabel.Size = new System.Drawing.Size(563, 30);
            this.gvsfbLabel.TabIndex = 1;
            this.gvsfbLabel.Text = "GREEDY VS FUERZA BRUTA";
            // 
            // cargarArchivo
            // 
            this.cargarArchivo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cargarArchivo.Font = new System.Drawing.Font("Emulogic", 7.749999F);
            this.cargarArchivo.ForeColor = System.Drawing.Color.White;
            this.cargarArchivo.Location = new System.Drawing.Point(540, 55);
            this.cargarArchivo.Name = "cargarArchivo";
            this.cargarArchivo.Size = new System.Drawing.Size(211, 32);
            this.cargarArchivo.TabIndex = 5;
            this.cargarArchivo.Text = "Cargar archivo";
            this.cargarArchivo.UseVisualStyleBackColor = false;
            this.cargarArchivo.Click += new System.EventHandler(this.button1_Click_1);
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
            // fbTextBox
            // 
            this.fbTextBox.BackColor = System.Drawing.Color.White;
            this.fbTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbTextBox.ForeColor = System.Drawing.Color.Black;
            this.fbTextBox.Location = new System.Drawing.Point(12, 91);
            this.fbTextBox.Name = "fbTextBox";
            this.fbTextBox.ReadOnly = true;
            this.fbTextBox.Size = new System.Drawing.Size(522, 578);
            this.fbTextBox.TabIndex = 13;
            this.fbTextBox.Text = resources.GetString("fbTextBox.Text");
            // 
            // greedyTextBox
            // 
            this.greedyTextBox.BackColor = System.Drawing.Color.White;
            this.greedyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greedyTextBox.Location = new System.Drawing.Point(744, 91);
            this.greedyTextBox.Name = "greedyTextBox";
            this.greedyTextBox.Size = new System.Drawing.Size(500, 578);
            this.greedyTextBox.TabIndex = 14;
            this.greedyTextBox.Text = resources.GetString("greedyTextBox.Text");
            // 
            // progressGreedy
            // 
            this.progressGreedy.Location = new System.Drawing.Point(771, 619);
            this.progressGreedy.Name = "progressGreedy";
            this.progressGreedy.Size = new System.Drawing.Size(445, 37);
            this.progressGreedy.TabIndex = 17;
            // 
            // progressFB
            // 
            this.progressFB.Location = new System.Drawing.Point(48, 619);
            this.progressFB.Name = "progressFB";
            this.progressFB.Size = new System.Drawing.Size(445, 37);
            this.progressFB.TabIndex = 18;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.BackColor = System.Drawing.Color.White;
            this.winnerLabel.Font = new System.Drawing.Font("Emulogic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.Crimson;
            this.winnerLabel.Location = new System.Drawing.Point(849, 568);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(312, 35);
            this.winnerLabel.TabIndex = 19;
            this.winnerLabel.Text = "greedy wins";
            this.winnerLabel.Visible = false;
            // 
            // BFvsG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoADA.Properties.Resources._333222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.progressFB);
            this.Controls.Add(this.progressGreedy);
            this.Controls.Add(this.greedyTextBox);
            this.Controls.Add(this.fbTextBox);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.cargarArchivo);
            this.Controls.Add(this.gvsfbLabel);
            this.Controls.Add(this.volverButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BFvsG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy Vs Brute force:  GvsBF";
            this.Load += new System.EventHandler(this.BFvsG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label gvsfbLabel;
        private Button cargarArchivo;
        private Label Error;
        private RichTextBox fbTextBox;
        private RichTextBox greedyTextBox;
        private ProgressBar progressGreedy;
        private ProgressBar progressFB;
        private Label winnerLabel;
    }
}