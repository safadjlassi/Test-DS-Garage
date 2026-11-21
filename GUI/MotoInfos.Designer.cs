namespace GUI
{
    partial class MotoInfos
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
            this.lblImmat = new System.Windows.Forms.Label();
            this.lvInfos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblImmat
            // 
            this.lblImmat.AutoSize = true;
            this.lblImmat.Location = new System.Drawing.Point(289, 151);
            this.lblImmat.Name = "lblImmat";
            this.lblImmat.Size = new System.Drawing.Size(44, 16);
            this.lblImmat.TabIndex = 0;
            this.lblImmat.Text = "label1";
            
            // 
            // lvInfos
            // 
            this.lvInfos.HideSelection = false;
            this.lvInfos.Location = new System.Drawing.Point(249, 237);
            this.lvInfos.Name = "lvInfos";
            this.lvInfos.Size = new System.Drawing.Size(121, 97);
            this.lvInfos.TabIndex = 1;
            this.lvInfos.UseCompatibleStateImageBehavior = false;
            // 
            // MotoInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvInfos);
            this.Controls.Add(this.lblImmat);
            this.Name = "MotoInfos";
            this.Text = "MotoInfos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImmat;
        private System.Windows.Forms.ListView lvInfos;
    }
}