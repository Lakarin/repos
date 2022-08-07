
namespace LineChartApp
{
    partial class FormZero
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
            this.button_zero_control = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.label_instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_zero_control
            // 
            this.button_zero_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zero_control.Location = new System.Drawing.Point(171, 136);
            this.button_zero_control.Name = "button_zero_control";
            this.button_zero_control.Size = new System.Drawing.Size(160, 80);
            this.button_zero_control.TabIndex = 0;
            this.button_zero_control.Text = "NEXT";
            this.button_zero_control.UseVisualStyleBackColor = true;
            this.button_zero_control.Click += new System.EventHandler(this.button_zero_control_Click);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Location = new System.Drawing.Point(166, 18);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(165, 28);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "The 1st Reading";
            // 
            // label_instruction
            // 
            this.label_instruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_instruction.AutoSize = true;
            this.label_instruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instruction.Location = new System.Drawing.Point(53, 67);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(105, 28);
            this.label_instruction.TabIndex = 2;
            this.label_instruction.Text = "Instruction";
            // 
            // FormZero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 228);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.button_zero_control);
            this.Name = "FormZero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeroing";
            this.Load += new System.EventHandler(this.FormZero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_zero_control;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_instruction;
    }
}