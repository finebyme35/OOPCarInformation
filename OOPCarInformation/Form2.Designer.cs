
namespace OOPCarInformation
{
    partial class Form2
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
            this.lResult = new System.Windows.Forms.Label();
            this.bGöster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lResult
            // 
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lResult.Location = new System.Drawing.Point(12, 9);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(333, 362);
            this.lResult.TabIndex = 0;
            this.lResult.Text = "Result";
            // 
            // bGöster
            // 
            this.bGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGöster.Location = new System.Drawing.Point(113, 374);
            this.bGöster.Name = "bGöster";
            this.bGöster.Size = new System.Drawing.Size(137, 64);
            this.bGöster.TabIndex = 1;
            this.bGöster.Text = "Göster";
            this.bGöster.UseVisualStyleBackColor = true;
            this.bGöster.Click += new System.EventHandler(this.bGöster_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.bGöster);
            this.Controls.Add(this.lResult);
            this.Name = "Form2";
            this.Text = "OOPCarİnformationShow";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Button bGöster;
    }
}