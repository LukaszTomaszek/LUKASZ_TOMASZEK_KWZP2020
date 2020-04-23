namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkButton = new System.Windows.Forms.CheckBox();
            this.txtB_1 = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkButton
            // 
            this.chkButton.AutoSize = true;
            this.chkButton.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkButton.Location = new System.Drawing.Point(63, 183);
            this.chkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkButton.Name = "chkButton";
            this.chkButton.Size = new System.Drawing.Size(176, 20);
            this.chkButton.TabIndex = 0;
            this.chkButton.Text = "Włącz / Wyłącz przycisk";
            this.chkButton.UseVisualStyleBackColor = true;
            this.chkButton.Click += new System.EventHandler(this.chkButtonEnabled_Click);
            // 
            // txtB_1
            // 
            this.txtB_1.Location = new System.Drawing.Point(63, 119);
            this.txtB_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtB_1.Name = "txtB_1";
            this.txtB_1.Size = new System.Drawing.Size(313, 22);
            this.txtB_1.TabIndex = 1;
            this.txtB_1.TextChanged += new System.EventHandler(this.tb_1_TextChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Title.Location = new System.Drawing.Point(55, 37);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(325, 33);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Laboratoria KWZP 2020";
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(63, 251);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(315, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CHANGE ME";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 351);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtB_1);
            this.Controls.Add(this.chkButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkButton;
        private System.Windows.Forms.TextBox txtB_1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btnClose;
    }
}

