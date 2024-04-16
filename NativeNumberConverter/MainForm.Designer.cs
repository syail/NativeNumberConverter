namespace NativeNumberConverter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rdoFromFloat32 = new RadioButton();
            rdoFromUint32 = new RadioButton();
            groupBox2 = new GroupBox();
            rdoToFloat32 = new RadioButton();
            rdoToUint32 = new RadioButton();
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOutput = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoFromFloat32);
            groupBox1.Controls.Add(rdoFromUint32);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(84, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "from type";
            // 
            // rdoFromFloat32
            // 
            rdoFromFloat32.AutoSize = true;
            rdoFromFloat32.Location = new Point(6, 47);
            rdoFromFloat32.Name = "rdoFromFloat32";
            rdoFromFloat32.Size = new Size(63, 19);
            rdoFromFloat32.TabIndex = 2;
            rdoFromFloat32.Text = "float32";
            rdoFromFloat32.UseVisualStyleBackColor = true;
            rdoFromFloat32.CheckedChanged += OnChanged;
            // 
            // rdoFromUint32
            // 
            rdoFromUint32.AutoSize = true;
            rdoFromUint32.Checked = true;
            rdoFromUint32.Location = new Point(6, 22);
            rdoFromUint32.Name = "rdoFromUint32";
            rdoFromUint32.Size = new Size(60, 19);
            rdoFromUint32.TabIndex = 0;
            rdoFromUint32.TabStop = true;
            rdoFromUint32.Text = "uint32";
            rdoFromUint32.UseVisualStyleBackColor = true;
            rdoFromUint32.CheckedChanged += OnChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoToFloat32);
            groupBox2.Controls.Add(rdoToUint32);
            groupBox2.Location = new Point(102, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(84, 74);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "to type";
            // 
            // rdoToFloat32
            // 
            rdoToFloat32.AutoSize = true;
            rdoToFloat32.Checked = true;
            rdoToFloat32.Location = new Point(6, 47);
            rdoToFloat32.Name = "rdoToFloat32";
            rdoToFloat32.Size = new Size(63, 19);
            rdoToFloat32.TabIndex = 2;
            rdoToFloat32.TabStop = true;
            rdoToFloat32.Text = "float32";
            rdoToFloat32.UseVisualStyleBackColor = true;
            rdoToFloat32.CheckedChanged += OnChanged;
            // 
            // rdoToUint32
            // 
            rdoToUint32.AutoSize = true;
            rdoToUint32.Location = new Point(6, 22);
            rdoToUint32.Name = "rdoToUint32";
            rdoToUint32.Size = new Size(60, 19);
            rdoToUint32.TabIndex = 0;
            rdoToUint32.Text = "uint32";
            rdoToUint32.UseVisualStyleBackColor = true;
            rdoToUint32.CheckedChanged += OnChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 116);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(174, 23);
            txtInput.TabIndex = 4;
            txtInput.TextChanged += OnChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "output";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 166);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(174, 23);
            txtOutput.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 210);
            Controls.Add(label2);
            Controls.Add(txtOutput);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Native Number Converter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoFromFloat32;
        private RadioButton rdoFromUint32;
        private GroupBox groupBox2;
        private RadioButton rdoToFloat32;
        private RadioButton rdoToUint32;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private TextBox txtOutput;
    }
}
