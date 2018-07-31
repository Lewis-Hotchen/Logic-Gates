namespace BoolGate {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.chkInputX = new System.Windows.Forms.CheckBox();
            this.Output = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chkInputY = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkBoxZ = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGate2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkInputX
            // 
            this.chkInputX.AutoSize = true;
            this.chkInputX.Location = new System.Drawing.Point(57, 9);
            this.chkInputX.Name = "chkInputX";
            this.chkInputX.Size = new System.Drawing.Size(157, 17);
            this.chkInputX.TabIndex = 1;
            this.chkInputX.Text = "Tick for true, empty for false";
            this.chkInputX.UseVisualStyleBackColor = true;
            this.chkInputX.CheckedChanged += new System.EventHandler(this.chkInputX_CheckedChanged);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(13, 193);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(35, 13);
            this.Output.TabIndex = 2;
            this.Output.Text = "label2";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(57, 137);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // chkInputY
            // 
            this.chkInputY.AutoSize = true;
            this.chkInputY.Location = new System.Drawing.Point(57, 32);
            this.chkInputY.Name = "chkInputY";
            this.chkInputY.Size = new System.Drawing.Size(157, 17);
            this.chkInputY.TabIndex = 6;
            this.chkInputY.Text = "Tick for true, empty for false";
            this.chkInputY.UseVisualStyleBackColor = true;
            this.chkInputY.CheckedChanged += new System.EventHandler(this.chkInputY_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input y";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOR",
            "XOR",
            "NAND",
            "XNOR",
            "NOT"});
            this.comboBox1.Location = new System.Drawing.Point(86, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose gate";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 153);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Output";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkBoxZ
            // 
            this.chkBoxZ.AutoSize = true;
            this.chkBoxZ.Location = new System.Drawing.Point(57, 50);
            this.chkBoxZ.Name = "chkBoxZ";
            this.chkBoxZ.Size = new System.Drawing.Size(157, 17);
            this.chkBoxZ.TabIndex = 11;
            this.chkBoxZ.Text = "Tick for true, empty for false";
            this.chkBoxZ.UseVisualStyleBackColor = true;
            this.chkBoxZ.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Choose gate";
            // 
            // cmbGate2
            // 
            this.cmbGate2.FormattingEnabled = true;
            this.cmbGate2.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOR",
            "XOR",
            "NAND",
            "XNOR",
            "NOT"});
            this.cmbGate2.Location = new System.Drawing.Point(86, 100);
            this.cmbGate2.Name = "cmbGate2";
            this.cmbGate2.Size = new System.Drawing.Size(121, 21);
            this.cmbGate2.TabIndex = 12;
            this.cmbGate2.SelectedIndexChanged += new System.EventHandler(this.cmbGate2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 299);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGate2);
            this.Controls.Add(this.chkBoxZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkInputY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.chkInputX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkInputX;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox chkInputY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkBoxZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGate2;
    }
}

