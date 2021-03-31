
namespace SuperheroSecretImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BatmenButton = new System.Windows.Forms.Button();
            this.CatwomenButton = new System.Windows.Forms.Button();
            this.SpiderButton = new System.Windows.Forms.Button();
            this.WolverineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BatmenButton
            // 
            this.BatmenButton.BackColor = System.Drawing.Color.Lime;
            this.BatmenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BatmenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BatmenButton.FlatAppearance.BorderSize = 0;
            this.BatmenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatmenButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BatmenButton.Location = new System.Drawing.Point(277, 489);
            this.BatmenButton.Name = "BatmenButton";
            this.BatmenButton.Size = new System.Drawing.Size(144, 49);
            this.BatmenButton.TabIndex = 0;
            this.BatmenButton.Text = "Batmen";
            this.BatmenButton.UseVisualStyleBackColor = false;
            this.BatmenButton.Click += new System.EventHandler(this.BatmenButton_Click);
            // 
            // CatwomenButton
            // 
            this.CatwomenButton.BackColor = System.Drawing.Color.Lime;
            this.CatwomenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatwomenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CatwomenButton.FlatAppearance.BorderSize = 0;
            this.CatwomenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatwomenButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatwomenButton.Location = new System.Drawing.Point(743, 434);
            this.CatwomenButton.Name = "CatwomenButton";
            this.CatwomenButton.Size = new System.Drawing.Size(144, 49);
            this.CatwomenButton.TabIndex = 1;
            this.CatwomenButton.Text = "Catwomen";
            this.CatwomenButton.UseVisualStyleBackColor = false;
            this.CatwomenButton.Click += new System.EventHandler(this.CatwomenButton_Click);
            // 
            // SpiderButton
            // 
            this.SpiderButton.BackColor = System.Drawing.Color.Lime;
            this.SpiderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpiderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SpiderButton.FlatAppearance.BorderSize = 0;
            this.SpiderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpiderButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpiderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SpiderButton.Location = new System.Drawing.Point(277, 434);
            this.SpiderButton.Name = "SpiderButton";
            this.SpiderButton.Size = new System.Drawing.Size(144, 49);
            this.SpiderButton.TabIndex = 2;
            this.SpiderButton.Text = "Spider-Man";
            this.SpiderButton.UseVisualStyleBackColor = false;
            this.SpiderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WolverineButton
            // 
            this.WolverineButton.BackColor = System.Drawing.Color.Lime;
            this.WolverineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WolverineButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WolverineButton.FlatAppearance.BorderSize = 0;
            this.WolverineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WolverineButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WolverineButton.Location = new System.Drawing.Point(743, 489);
            this.WolverineButton.Name = "WolverineButton";
            this.WolverineButton.Size = new System.Drawing.Size(144, 49);
            this.WolverineButton.TabIndex = 3;
            this.WolverineButton.Text = "Wolverine";
            this.WolverineButton.UseVisualStyleBackColor = false;
            this.WolverineButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperheroSecretImage.Properties.Resources.MarvelDC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 753);
            this.Controls.Add(this.WolverineButton);
            this.Controls.Add(this.SpiderButton);
            this.Controls.Add(this.CatwomenButton);
            this.Controls.Add(this.BatmenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Who are your hero?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BatmenButton;
        private System.Windows.Forms.Button CatwomenButton;
        private System.Windows.Forms.Button SpiderButton;
        private System.Windows.Forms.Button WolverineButton;
    }
}

