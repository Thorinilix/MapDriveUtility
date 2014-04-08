namespace MapDriveUtility
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
            this.txtTransmit = new System.Windows.Forms.TextBox();
            this.txtDrive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPers = new System.Windows.Forms.CheckBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTransmit
            // 
            this.txtTransmit.Location = new System.Drawing.Point(130, 18);
            this.txtTransmit.Name = "txtTransmit";
            this.txtTransmit.Size = new System.Drawing.Size(142, 20);
            this.txtTransmit.TabIndex = 0;
            // 
            // txtDrive
            // 
            this.txtDrive.Location = new System.Drawing.Point(80, 60);
            this.txtDrive.Name = "txtDrive";
            this.txtDrive.Size = new System.Drawing.Size(44, 20);
            this.txtDrive.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transmitting Computer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drive Letter:";
            // 
            // chkPers
            // 
            this.chkPers.AutoSize = true;
            this.chkPers.Location = new System.Drawing.Point(12, 107);
            this.chkPers.Name = "chkPers";
            this.chkPers.Size = new System.Drawing.Size(116, 17);
            this.chkPers.TabIndex = 4;
            this.chkPers.Text = "Persistent Mapping";
            this.chkPers.UseVisualStyleBackColor = true;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(12, 159);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 5;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.chkPers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrive);
            this.Controls.Add(this.txtTransmit);
            this.Name = "Form1";
            this.Text = "Map Drive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransmit;
        private System.Windows.Forms.TextBox txtDrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPers;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnCancel;
    }
}

