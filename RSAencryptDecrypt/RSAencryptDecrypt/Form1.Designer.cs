namespace RSAencryptDecrypt
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.MsgToEncrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generateNewRandomPrivateAndPublicKeyBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customPassPhraseTB = new System.Windows.Forms.TextBox();
            this.customPassPhraseRB = new System.Windows.Forms.RadioButton();
            this.randomPassPhraseTB = new System.Windows.Forms.TextBox();
            this.randomPassPhraseRB = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(224, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA Encrypt / Decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private Key";
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(8, 108);
            this.privateKey.Multiline = true;
            this.privateKey.Name = "privateKey";
            this.privateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.privateKey.Size = new System.Drawing.Size(660, 52);
            this.privateKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Public Key";
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(8, 182);
            this.publicKey.Multiline = true;
            this.publicKey.Name = "publicKey";
            this.publicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.publicKey.Size = new System.Drawing.Size(661, 50);
            this.publicKey.TabIndex = 4;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(153, 382);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(168, 29);
            this.encryptBtn.TabIndex = 5;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(346, 382);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(183, 29);
            this.DecryptBtn.TabIndex = 6;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 413);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(663, 102);
            this.result.TabIndex = 7;
            // 
            // MsgToEncrypt
            // 
            this.MsgToEncrypt.Location = new System.Drawing.Point(12, 306);
            this.MsgToEncrypt.Multiline = true;
            this.MsgToEncrypt.Name = "MsgToEncrypt";
            this.MsgToEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MsgToEncrypt.Size = new System.Drawing.Size(662, 71);
            this.MsgToEncrypt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message to encrypt or decrypt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Output";
            // 
            // generateNewRandomPrivateAndPublicKeyBtn
            // 
            this.generateNewRandomPrivateAndPublicKeyBtn.Location = new System.Drawing.Point(8, 49);
            this.generateNewRandomPrivateAndPublicKeyBtn.Name = "generateNewRandomPrivateAndPublicKeyBtn";
            this.generateNewRandomPrivateAndPublicKeyBtn.Size = new System.Drawing.Size(661, 40);
            this.generateNewRandomPrivateAndPublicKeyBtn.TabIndex = 11;
            this.generateNewRandomPrivateAndPublicKeyBtn.Text = "Generate New Private and Public Key";
            this.generateNewRandomPrivateAndPublicKeyBtn.UseVisualStyleBackColor = true;
            this.generateNewRandomPrivateAndPublicKeyBtn.Click += new System.EventHandler(this.generateNewRandomPrivateAndPublicKeyBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.customPassPhraseTB);
            this.groupBox1.Controls.Add(this.customPassPhraseRB);
            this.groupBox1.Controls.Add(this.randomPassPhraseTB);
            this.groupBox1.Controls.Add(this.randomPassPhraseRB);
            this.groupBox1.Controls.Add(this.generateNewRandomPrivateAndPublicKeyBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.privateKey);
            this.groupBox1.Controls.Add(this.publicKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 253);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generating Option";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(76, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(76, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // customPassPhraseTB
            // 
            this.customPassPhraseTB.Enabled = false;
            this.customPassPhraseTB.Location = new System.Drawing.Point(468, 22);
            this.customPassPhraseTB.Name = "customPassPhraseTB";
            this.customPassPhraseTB.Size = new System.Drawing.Size(200, 20);
            this.customPassPhraseTB.TabIndex = 15;
            // 
            // customPassPhraseRB
            // 
            this.customPassPhraseRB.AutoSize = true;
            this.customPassPhraseRB.Location = new System.Drawing.Point(327, 24);
            this.customPassPhraseRB.Name = "customPassPhraseRB";
            this.customPassPhraseRB.Size = new System.Drawing.Size(141, 17);
            this.customPassPhraseRB.TabIndex = 14;
            this.customPassPhraseRB.Text = "Use random PassPhrase";
            this.customPassPhraseRB.UseVisualStyleBackColor = true;
            // 
            // randomPassPhraseTB
            // 
            this.randomPassPhraseTB.Location = new System.Drawing.Point(153, 22);
            this.randomPassPhraseTB.Name = "randomPassPhraseTB";
            this.randomPassPhraseTB.ReadOnly = true;
            this.randomPassPhraseTB.Size = new System.Drawing.Size(164, 20);
            this.randomPassPhraseTB.TabIndex = 13;
            // 
            // randomPassPhraseRB
            // 
            this.randomPassPhraseRB.AutoSize = true;
            this.randomPassPhraseRB.Checked = true;
            this.randomPassPhraseRB.Location = new System.Drawing.Point(8, 23);
            this.randomPassPhraseRB.Name = "randomPassPhraseRB";
            this.randomPassPhraseRB.Size = new System.Drawing.Size(141, 17);
            this.randomPassPhraseRB.TabIndex = 12;
            this.randomPassPhraseRB.TabStop = true;
            this.randomPassPhraseRB.Text = "Use random PassPhrase";
            this.randomPassPhraseRB.UseVisualStyleBackColor = true;
            this.randomPassPhraseRB.CheckedChanged += new System.EventHandler(this.randomPassPhraseRB_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "By Mohssine EL HARFI";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(11, 522);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github Source Code";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 541);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MsgToEncrypt);
            this.Controls.Add(this.result);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA Encrypt Decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox MsgToEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateNewRandomPrivateAndPublicKeyBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox customPassPhraseTB;
        private System.Windows.Forms.RadioButton customPassPhraseRB;
        private System.Windows.Forms.TextBox randomPassPhraseTB;
        private System.Windows.Forms.RadioButton randomPassPhraseRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

