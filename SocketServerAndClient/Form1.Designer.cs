namespace SocketServerAndClient
{
    partial class AnaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.BtnBaglan = new System.Windows.Forms.Button();
            this.BtnBaglantiKes = new System.Windows.Forms.Button();
            this.TxtDialog = new System.Windows.Forms.TextBox();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(91, 50);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(165, 22);
            this.TxtPort.TabIndex = 1;
            // 
            // BtnBaglan
            // 
            this.BtnBaglan.Location = new System.Drawing.Point(290, 33);
            this.BtnBaglan.Name = "BtnBaglan";
            this.BtnBaglan.Size = new System.Drawing.Size(120, 50);
            this.BtnBaglan.TabIndex = 2;
            this.BtnBaglan.Text = "Bağlan";
            this.BtnBaglan.UseVisualStyleBackColor = true;
            this.BtnBaglan.Click += new System.EventHandler(this.BtnBaglan_Click);
            // 
            // BtnBaglantiKes
            // 
            this.BtnBaglantiKes.Location = new System.Drawing.Point(430, 33);
            this.BtnBaglantiKes.Name = "BtnBaglantiKes";
            this.BtnBaglantiKes.Size = new System.Drawing.Size(120, 50);
            this.BtnBaglantiKes.TabIndex = 3;
            this.BtnBaglantiKes.Text = "Bağlantıyı Kes";
            this.BtnBaglantiKes.UseVisualStyleBackColor = true;
            this.BtnBaglantiKes.Click += new System.EventHandler(this.BtnBaglantiKes_Click);
            // 
            // TxtDialog
            // 
            this.TxtDialog.Location = new System.Drawing.Point(50, 103);
            this.TxtDialog.Multiline = true;
            this.TxtDialog.Name = "TxtDialog";
            this.TxtDialog.Size = new System.Drawing.Size(500, 200);
            this.TxtDialog.TabIndex = 4;
            // 
            // TxtMessage
            // 
            this.TxtMessage.Location = new System.Drawing.Point(50, 320);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(500, 60);
            this.TxtMessage.TabIndex = 5;
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(290, 421);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(120, 50);
            this.BtnGonder.TabIndex = 6;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.TxtDialog);
            this.Controls.Add(this.BtnBaglantiKes);
            this.Controls.Add(this.BtnBaglan);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.label1);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Uygulaması";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Button BtnBaglan;
        private System.Windows.Forms.Button BtnBaglantiKes;
        private System.Windows.Forms.TextBox TxtDialog;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BtnGonder;
    }
}

