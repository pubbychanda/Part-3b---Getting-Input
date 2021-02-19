
namespace Getting_Input
{
    partial class MainForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Location = new System.Drawing.Point(15, 49);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "click me ";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(12, 18);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(125, 13);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please Enter your name: ";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(109, 54);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(143, 15);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(87, 20);
            this.txtInput.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 82);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Getting Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtInput;
    }
}

