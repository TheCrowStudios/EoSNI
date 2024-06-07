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
            btnClose = new Button();
            txtQuote = new RichTextBox();
            SuspendLayout();
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
            // txtQuote
            // 
            txtQuote.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuote.Location = new Point(12, 12);
            txtQuote.Name = "txtQuote";
            txtQuote.ReadOnly = true;
            txtQuote.Size = new Size(678, 440);
            txtQuote.TabIndex = 15;
            txtQuote.Text = "";
            txtQuote.WordWrap = false;
            // 
            // ShippingQuoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 500);
            Controls.Add(txtQuote);
            Controls.Add(btnClose);
            Name = "ShippingQuoteForm";
            Text = "EoSNI - Shipping quote";
            ResumeLayout(false);
        }

        #endregion
        private Button btnClose;
        private RichTextBox txtQuote;
    }
}