namespace lab_01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputInput = new System.Windows.Forms.TextBox();
            this.nullButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.andButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.orButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.binButton = new System.Windows.Forms.Button();
            this.octButton = new System.Windows.Forms.Button();
            this.hexButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.backspcButton = new System.Windows.Forms.Button();
            this.ACButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputInput
            // 
            this.outputInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputInput.Location = new System.Drawing.Point(55, 35);
            this.outputInput.Multiline = true;
            this.outputInput.Name = "outputInput";
            this.outputInput.ReadOnly = true;
            this.outputInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outputInput.Size = new System.Drawing.Size(360, 50);
            this.outputInput.TabIndex = 0;
            this.outputInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outputInput.TextChanged += new System.EventHandler(this.outputInput_TextChanged);
            // 
            // nullButton
            // 
            this.nullButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nullButton.Location = new System.Drawing.Point(55, 115);
            this.nullButton.Name = "nullButton";
            this.nullButton.Size = new System.Drawing.Size(60, 60);
            this.nullButton.TabIndex = 1;
            this.nullButton.Text = "0";
            this.nullButton.UseVisualStyleBackColor = true;
            this.nullButton.Click += new System.EventHandler(this.nullButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(121, 115);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(60, 60);
            this.oneButton.TabIndex = 2;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsButton.Location = new System.Drawing.Point(462, 35);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(126, 50);
            this.equalsButton.TabIndex = 3;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // andButton
            // 
            this.andButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.andButton.Location = new System.Drawing.Point(462, 115);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(60, 60);
            this.andButton.TabIndex = 4;
            this.andButton.Text = "AND";
            this.andButton.UseVisualStyleBackColor = true;
            this.andButton.Click += new System.EventHandler(this.andButton_Click);
            // 
            // notButton
            // 
            this.notButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notButton.Location = new System.Drawing.Point(528, 115);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(60, 60);
            this.notButton.TabIndex = 5;
            this.notButton.Text = "NOT";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // orButton
            // 
            this.orButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orButton.Location = new System.Drawing.Point(462, 181);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(60, 60);
            this.orButton.TabIndex = 6;
            this.orButton.Text = "OR";
            this.orButton.UseVisualStyleBackColor = true;
            this.orButton.Click += new System.EventHandler(this.orButton_Click);
            // 
            // xorButton
            // 
            this.xorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xorButton.Location = new System.Drawing.Point(528, 181);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(60, 60);
            this.xorButton.TabIndex = 7;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // binButton
            // 
            this.binButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binButton.Location = new System.Drawing.Point(200, 115);
            this.binButton.Name = "binButton";
            this.binButton.Size = new System.Drawing.Size(100, 60);
            this.binButton.TabIndex = 8;
            this.binButton.Text = "BIN";
            this.binButton.UseVisualStyleBackColor = true;
            this.binButton.Click += new System.EventHandler(this.binButton_Click);
            // 
            // octButton
            // 
            this.octButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.octButton.Location = new System.Drawing.Point(315, 115);
            this.octButton.Name = "octButton";
            this.octButton.Size = new System.Drawing.Size(100, 60);
            this.octButton.TabIndex = 9;
            this.octButton.Text = "OCT";
            this.octButton.UseVisualStyleBackColor = true;
            this.octButton.Click += new System.EventHandler(this.octButton_Click);
            // 
            // hexButton
            // 
            this.hexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexButton.Location = new System.Drawing.Point(315, 181);
            this.hexButton.Name = "hexButton";
            this.hexButton.Size = new System.Drawing.Size(100, 60);
            this.hexButton.TabIndex = 10;
            this.hexButton.Text = "HEX";
            this.hexButton.UseVisualStyleBackColor = true;
            this.hexButton.Click += new System.EventHandler(this.hexButton_Click);
            // 
            // decButton
            // 
            this.decButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decButton.Location = new System.Drawing.Point(200, 181);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(100, 60);
            this.decButton.TabIndex = 11;
            this.decButton.Text = "DEC";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // backspcButton
            // 
            this.backspcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspcButton.Location = new System.Drawing.Point(55, 181);
            this.backspcButton.Name = "backspcButton";
            this.backspcButton.Size = new System.Drawing.Size(60, 60);
            this.backspcButton.TabIndex = 12;
            this.backspcButton.Text = "<-";
            this.backspcButton.UseVisualStyleBackColor = true;
            this.backspcButton.Click += new System.EventHandler(this.backspcButton_Click);
            // 
            // ACButton
            // 
            this.ACButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ACButton.Location = new System.Drawing.Point(121, 181);
            this.ACButton.Name = "ACButton";
            this.ACButton.Size = new System.Drawing.Size(60, 60);
            this.ACButton.TabIndex = 13;
            this.ACButton.Text = "AC";
            this.ACButton.UseVisualStyleBackColor = true;
            this.ACButton.Click += new System.EventHandler(this.ACButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 335);
            this.Controls.Add(this.ACButton);
            this.Controls.Add(this.backspcButton);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.hexButton);
            this.Controls.Add(this.octButton);
            this.Controls.Add(this.binButton);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.orButton);
            this.Controls.Add(this.notButton);
            this.Controls.Add(this.andButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.nullButton);
            this.Controls.Add(this.outputInput);
            this.Name = "Form1";
            this.Text = "BinCalculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputInput;
        private System.Windows.Forms.Button nullButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button andButton;
        private System.Windows.Forms.Button notButton;
        private System.Windows.Forms.Button orButton;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Button binButton;
        private System.Windows.Forms.Button octButton;
        private System.Windows.Forms.Button hexButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Button backspcButton;
        private System.Windows.Forms.Button ACButton;
    }
}

