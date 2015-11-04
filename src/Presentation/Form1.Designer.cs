namespace Presentation
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnReverseArray = new System.Windows.Forms.Button();
            this.btnTwoPoints = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numTimesToRun = new System.Windows.Forms.NumericUpDown();
            this.lblTimesToRun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesToRun)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(12, 12);
            this.txtWord.MaxLength = 524288;
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWord.Size = new System.Drawing.Size(748, 266);
            this.txtWord.TabIndex = 0;
            // 
            // btnReverseArray
            // 
            this.btnReverseArray.Location = new System.Drawing.Point(12, 284);
            this.btnReverseArray.Name = "btnReverseArray";
            this.btnReverseArray.Size = new System.Drawing.Size(140, 23);
            this.btnReverseArray.TabIndex = 1;
            this.btnReverseArray.Text = "Reverse Array";
            this.btnReverseArray.UseVisualStyleBackColor = true;
            this.btnReverseArray.Click += new System.EventHandler(this.btnReverseArray_Click);
            // 
            // btnTwoPoints
            // 
            this.btnTwoPoints.Location = new System.Drawing.Point(158, 284);
            this.btnTwoPoints.Name = "btnTwoPoints";
            this.btnTwoPoints.Size = new System.Drawing.Size(140, 23);
            this.btnTwoPoints.TabIndex = 2;
            this.btnTwoPoints.Text = "Two points";
            this.btnTwoPoints.UseVisualStyleBackColor = true;
            this.btnTwoPoints.Click += new System.EventHandler(this.btnTwoPoints_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.CausesValidation = false;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(304, 287);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "lblResult";
            // 
            // numTimesToRun
            // 
            this.numTimesToRun.Location = new System.Drawing.Point(636, 284);
            this.numTimesToRun.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numTimesToRun.Name = "numTimesToRun";
            this.numTimesToRun.Size = new System.Drawing.Size(77, 22);
            this.numTimesToRun.TabIndex = 4;
            this.numTimesToRun.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblTimesToRun
            // 
            this.lblTimesToRun.AutoSize = true;
            this.lblTimesToRun.CausesValidation = false;
            this.lblTimesToRun.ForeColor = System.Drawing.Color.Black;
            this.lblTimesToRun.Location = new System.Drawing.Point(719, 287);
            this.lblTimesToRun.Name = "lblTimesToRun";
            this.lblTimesToRun.Size = new System.Drawing.Size(41, 17);
            this.lblTimesToRun.TabIndex = 5;
            this.lblTimesToRun.Text = "times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 319);
            this.Controls.Add(this.lblTimesToRun);
            this.Controls.Add(this.numTimesToRun);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnTwoPoints);
            this.Controls.Add(this.btnReverseArray);
            this.Controls.Add(this.txtWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTimesToRun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnReverseArray;
        private System.Windows.Forms.Button btnTwoPoints;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numTimesToRun;
        private System.Windows.Forms.Label lblTimesToRun;
    }
}

