
namespace quiz1
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
            this.btn = new System.Windows.Forms.Button();
            this.SPM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.INP = new System.Windows.Forms.TextBox();
            this.prog = new System.Windows.Forms.ProgressBar();
            this.POENG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(169, 233);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(107, 38);
            this.btn.TabIndex = 0;
            this.btn.Text = "Click!";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // SPM
            // 
            this.SPM.AutoSize = true;
            this.SPM.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPM.Location = new System.Drawing.Point(17, 112);
            this.SPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SPM.Name = "SPM";
            this.SPM.Size = new System.Drawing.Size(353, 38);
            this.SPM.TabIndex = 1;
            this.SPM.Text = "SKRIV INN SPØRSMÅL HER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(168, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADVARSEL: BARE SKRIV MED SMÅ BOKSTAVER";
            // 
            // INP
            // 
            this.INP.Location = new System.Drawing.Point(17, 233);
            this.INP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.INP.Name = "INP";
            this.INP.Size = new System.Drawing.Size(141, 31);
            this.INP.TabIndex = 3;
            // 
            // prog
            // 
            this.prog.Location = new System.Drawing.Point(17, 20);
            this.prog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(143, 38);
            this.prog.TabIndex = 4;
            // 
            // POENG
            // 
            this.POENG.AutoSize = true;
            this.POENG.Location = new System.Drawing.Point(17, 283);
            this.POENG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.POENG.Name = "POENG";
            this.POENG.Size = new System.Drawing.Size(73, 25);
            this.POENG.TabIndex = 5;
            this.POENG.Text = "poeng: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 398);
            this.Controls.Add(this.POENG);
            this.Controls.Add(this.prog);
            this.Controls.Add(this.INP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SPM);
            this.Controls.Add(this.btn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label SPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INP;
        private System.Windows.Forms.ProgressBar prog;
        private System.Windows.Forms.Label POENG;
    }
}

