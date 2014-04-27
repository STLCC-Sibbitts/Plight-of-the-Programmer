namespace Plight_of_the_Programmer
{
    partial class GameWindow
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Enabled = false;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(800, 600);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Visible = false;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Power Red and Green", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Green;
            this.btnPlay.Location = new System.Drawing.Point(360, 360);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(214, 100);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "> Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.pbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMenu.Image = global::Plight_of_the_Programmer.Properties.Resources.Menu;
            this.pbMenu.Location = new System.Drawing.Point(0, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(800, 600);
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // btnCharacter
            // 
            this.btnCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.btnCharacter.FlatAppearance.BorderSize = 0;
            this.btnCharacter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.btnCharacter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.btnCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharacter.Font = new System.Drawing.Font("Power Red and Green", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharacter.ForeColor = System.Drawing.Color.Green;
            this.btnCharacter.Location = new System.Drawing.Point(360, 460);
            this.btnCharacter.Name = "btnCharacter";
            this.btnCharacter.Size = new System.Drawing.Size(385, 100);
            this.btnCharacter.TabIndex = 3;
            this.btnCharacter.Text = "Character";
            this.btnCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCharacter.UseVisualStyleBackColor = false;
            this.btnCharacter.Click += new System.EventHandler(this.btnCharacter_Click);
            this.btnCharacter.MouseEnter += new System.EventHandler(this.btnCharacter_MouseEnter);
            this.btnCharacter.MouseLeave += new System.EventHandler(this.btnCharacter_MouseLeave);
            // 
            // pbCharacter
            // 
            this.pbCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.pbCharacter.Image = global::Plight_of_the_Programmer.Properties.Resources.jordanRun;
            this.pbCharacter.Location = new System.Drawing.Point(115, 348);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(154, 252);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter.TabIndex = 4;
            this.pbCharacter.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.btnCharacter);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 628);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(806, 628);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plight of the Programmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.PictureBox pbCharacter;
    }
}

