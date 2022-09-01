
namespace NumberGuessingGame
{
    partial class FormOpening
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 54);
            this.label3.TabIndex = 9;
            this.label3.Text = "And";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtSon_MouseMove);
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLast.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLast.Location = new System.Drawing.Point(290, 145);
            this.txtLast.MaxLength = 3;
            this.txtLast.Multiline = true;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(82, 54);
            this.txtLast.TabIndex = 1;
            this.txtLast.TextChanged += new System.EventHandler(this.AllTextBoxesTextChanged);
            this.txtLast.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtSon_MouseMove);
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFirst.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirst.Location = new System.Drawing.Point(12, 149);
            this.txtFirst.MaxLength = 3;
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(82, 50);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.TextChanged += new System.EventHandler(this.AllTextBoxesTextChanged);
            this.txtFirst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtSon_MouseMove);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number Guessing Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TxtSon_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "Let the numbers be between";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FormOpening";
            this.Text = "Opening";
            this.Load += new System.EventHandler(this.FormOpening_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOpening_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
    }
}