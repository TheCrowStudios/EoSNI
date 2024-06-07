namespace EoSNI
{
    partial class ShippingQuoteForm
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
            lblQuote = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblQuote
            // 
            lblQuote.AutoSize = true;
            lblQuote.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuote.Location = new Point(48, 45);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(68, 20);
            lblQuote.TabIndex = 0;
            lblQuote.Text = "<quote>";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(303, 458);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 30);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ShippingQuoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 500);
            Controls.Add(btnClose);
            Controls.Add(lblQuote);
            Name = "ShippingQuoteForm";
            Text = "EoSNI - Shipping quote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuote;
        private Button btnClose;
    }
}