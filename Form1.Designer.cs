namespace calcaulator_c_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMultiply = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnsubstract = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnEqualation = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnResetOrClear = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btndotforfloat = new System.Windows.Forms.Button();
            this.btnsqrtoperator = new System.Windows.Forms.Button();
            this.btnexponentoperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(414, 203);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 63);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.LightYellow;
            this.textBox.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(21, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(498, 169);
            this.textBox.TabIndex = 14;
            this.textBox.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(414, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 63);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnsubstract
            // 
            this.btnsubstract.BackColor = System.Drawing.Color.Transparent;
            this.btnsubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubstract.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubstract.ForeColor = System.Drawing.Color.Black;
            this.btnsubstract.Location = new System.Drawing.Point(414, 399);
            this.btnsubstract.Name = "btnsubstract";
            this.btnsubstract.Size = new System.Drawing.Size(74, 63);
            this.btnsubstract.TabIndex = 16;
            this.btnsubstract.Text = "-";
            this.btnsubstract.UseVisualStyleBackColor = false;
            this.btnsubstract.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Transparent;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.Black;
            this.btnDivision.Location = new System.Drawing.Point(414, 497);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(74, 63);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnEqualation
            // 
            this.btnEqualation.BackColor = System.Drawing.Color.Transparent;
            this.btnEqualation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualation.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqualation.ForeColor = System.Drawing.Color.Black;
            this.btnEqualation.Location = new System.Drawing.Point(211, 497);
            this.btnEqualation.Name = "btnEqualation";
            this.btnEqualation.Size = new System.Drawing.Size(74, 63);
            this.btnEqualation.TabIndex = 21;
            this.btnEqualation.Text = "=";
            this.btnEqualation.UseVisualStyleBackColor = false;
            this.btnEqualation.Click += new System.EventHandler(this.btnEqualation_Click);
            // 
            // btnNumber9
            // 
            this.btnNumber9.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber9.ForeColor = System.Drawing.Color.Black;
            this.btnNumber9.Location = new System.Drawing.Point(211, 399);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(74, 63);
            this.btnNumber9.TabIndex = 20;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = false;
            this.btnNumber9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber6
            // 
            this.btnNumber6.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber6.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber6.ForeColor = System.Drawing.Color.Black;
            this.btnNumber6.Location = new System.Drawing.Point(211, 301);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(74, 63);
            this.btnNumber6.TabIndex = 19;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = false;
            this.btnNumber6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber3
            // 
            this.btnNumber3.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber3.ForeColor = System.Drawing.Color.Black;
            this.btnNumber3.Location = new System.Drawing.Point(211, 203);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(74, 63);
            this.btnNumber3.TabIndex = 18;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = false;
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnResetOrClear
            // 
            this.btnResetOrClear.BackColor = System.Drawing.Color.Transparent;
            this.btnResetOrClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrClear.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrClear.ForeColor = System.Drawing.Color.Black;
            this.btnResetOrClear.Location = new System.Drawing.Point(314, 497);
            this.btnResetOrClear.Name = "btnResetOrClear";
            this.btnResetOrClear.Size = new System.Drawing.Size(74, 63);
            this.btnResetOrClear.TabIndex = 25;
            this.btnResetOrClear.Text = "C";
            this.btnResetOrClear.UseVisualStyleBackColor = false;
            this.btnResetOrClear.Click += new System.EventHandler(this.btnResetOrClear_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber8.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber8.ForeColor = System.Drawing.Color.Black;
            this.btnNumber8.Location = new System.Drawing.Point(115, 399);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(74, 63);
            this.btnNumber8.TabIndex = 24;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = false;
            this.btnNumber8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber5
            // 
            this.btnNumber5.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber5.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber5.ForeColor = System.Drawing.Color.Black;
            this.btnNumber5.Location = new System.Drawing.Point(115, 301);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(74, 63);
            this.btnNumber5.TabIndex = 23;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = false;
            this.btnNumber5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber2.ForeColor = System.Drawing.Color.Black;
            this.btnNumber2.Location = new System.Drawing.Point(115, 203);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(74, 63);
            this.btnNumber2.TabIndex = 22;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = false;
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Transparent;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.Location = new System.Drawing.Point(21, 497);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(74, 63);
            this.btnZero.TabIndex = 29;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber7
            // 
            this.btnNumber7.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber7.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber7.ForeColor = System.Drawing.Color.Black;
            this.btnNumber7.Location = new System.Drawing.Point(21, 399);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(74, 63);
            this.btnNumber7.TabIndex = 28;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = false;
            this.btnNumber7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber4
            // 
            this.btnNumber4.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber4.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber4.ForeColor = System.Drawing.Color.Black;
            this.btnNumber4.Location = new System.Drawing.Point(21, 301);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(74, 63);
            this.btnNumber4.TabIndex = 27;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = false;
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.BackColor = System.Drawing.Color.Transparent;
            this.btnNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber1.ForeColor = System.Drawing.Color.Black;
            this.btnNumber1.Location = new System.Drawing.Point(21, 203);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(74, 63);
            this.btnNumber1.TabIndex = 26;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = false;
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::calcaulator_c_.Properties.Resources.backspace_icon_151584;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(314, 203);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 63);
            this.btnBack.TabIndex = 30;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btndotforfloat
            // 
            this.btndotforfloat.BackColor = System.Drawing.Color.Transparent;
            this.btndotforfloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndotforfloat.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndotforfloat.ForeColor = System.Drawing.Color.Black;
            this.btndotforfloat.Location = new System.Drawing.Point(115, 497);
            this.btndotforfloat.Name = "btndotforfloat";
            this.btndotforfloat.Size = new System.Drawing.Size(74, 63);
            this.btndotforfloat.TabIndex = 31;
            this.btndotforfloat.Text = ".";
            this.btndotforfloat.UseVisualStyleBackColor = false;
            this.btndotforfloat.Click += new System.EventHandler(this.btndotforfloat_Click);
            // 
            // btnsqrtoperator
            // 
            this.btnsqrtoperator.BackColor = System.Drawing.Color.Transparent;
            this.btnsqrtoperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsqrtoperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsqrtoperator.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsqrtoperator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsqrtoperator.Location = new System.Drawing.Point(314, 399);
            this.btnsqrtoperator.Name = "btnsqrtoperator";
            this.btnsqrtoperator.Size = new System.Drawing.Size(74, 63);
            this.btnsqrtoperator.TabIndex = 32;
            this.btnsqrtoperator.Text = "√";
            this.btnsqrtoperator.UseVisualStyleBackColor = false;
            this.btnsqrtoperator.Click += new System.EventHandler(this.btnsqrtoperator_Click);
            // 
            // btnexponentoperator
            // 
            this.btnexponentoperator.BackColor = System.Drawing.Color.Transparent;
            this.btnexponentoperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexponentoperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexponentoperator.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexponentoperator.ForeColor = System.Drawing.Color.Black;
            this.btnexponentoperator.Location = new System.Drawing.Point(314, 301);
            this.btnexponentoperator.Name = "btnexponentoperator";
            this.btnexponentoperator.Size = new System.Drawing.Size(74, 63);
            this.btnexponentoperator.TabIndex = 33;
            this.btnexponentoperator.Text = "^";
            this.btnexponentoperator.UseVisualStyleBackColor = false;
            this.btnexponentoperator.Click += new System.EventHandler(this.btnexponentoperator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::calcaulator_c_.Properties.Resources.top_view_notebooks_calculator;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(798, 579);
            this.Controls.Add(this.btnexponentoperator);
            this.Controls.Add(this.btnsqrtoperator);
            this.Controls.Add(this.btndotforfloat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.btnResetOrClear);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnNumber5);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnEqualation);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnsubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMultiply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnsubstract;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnEqualation;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnResetOrClear;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btndotforfloat;
        private System.Windows.Forms.Button btnsqrtoperator;
        private System.Windows.Forms.Button btnexponentoperator;
    }
}

