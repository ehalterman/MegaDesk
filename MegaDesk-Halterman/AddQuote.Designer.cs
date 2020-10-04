namespace MegaDesk_Halterman
{
    partial class AddQuote
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.desktopInput = new System.Windows.Forms.ComboBox();
            this.shippingInput = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(214, 37);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(200, 22);
            this.nameInput.TabIndex = 0;
            this.nameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desk Width:";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(214, 76);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(200, 22);
            this.widthInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desk Depth:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(214, 118);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(200, 22);
            this.depthInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Drawers:";
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(214, 169);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(200, 22);
            this.drawersInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desktop Material:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shipping Time:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // desktopInput
            // 
            this.desktopInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desktopInput.FormattingEnabled = true;
            this.desktopInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.desktopInput.Location = new System.Drawing.Point(293, 212);
            this.desktopInput.Name = "desktopInput";
            this.desktopInput.Size = new System.Drawing.Size(121, 24);
            this.desktopInput.TabIndex = 12;
            // 
            // shippingInput
            // 
            this.shippingInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shippingInput.FormattingEnabled = true;
            this.shippingInput.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "no rush"});
            this.shippingInput.Location = new System.Drawing.Point(293, 273);
            this.shippingInput.Name = "shippingInput";
            this.shippingInput.Size = new System.Drawing.Size(121, 24);
            this.shippingInput.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Get Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shippingInput);
            this.Controls.Add(this.desktopInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Name = "AddQuote";
            this.Text = "New Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drawersInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox desktopInput;
        private System.Windows.Forms.ComboBox shippingInput;
        private System.Windows.Forms.Button button1;
    }
}