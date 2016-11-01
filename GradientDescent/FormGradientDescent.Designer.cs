namespace GradientDescent
{
    partial class FormGradientDescent
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGradientDescent));
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxValidCharacters = new System.Windows.Forms.GroupBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelCharacters = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelFunc = new System.Windows.Forms.Label();
            this.labelApproximation = new System.Windows.Forms.Label();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxValidCharacters.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFunction.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxFunction.Location = new System.Drawing.Point(56, 12);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(224, 20);
            this.textBoxFunction.TabIndex = 0;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(109, 78);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 107);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(268, 56);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 16);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "lable1";
            // 
            // groupBoxValidCharacters
            // 
            this.groupBoxValidCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxValidCharacters.Controls.Add(this.labelValue);
            this.groupBoxValidCharacters.Controls.Add(this.labelCharacters);
            this.groupBoxValidCharacters.Location = new System.Drawing.Point(12, 169);
            this.groupBoxValidCharacters.Name = "groupBoxValidCharacters";
            this.groupBoxValidCharacters.Size = new System.Drawing.Size(267, 292);
            this.groupBoxValidCharacters.TabIndex = 3;
            this.groupBoxValidCharacters.TabStop = false;
            this.groupBoxValidCharacters.Text = "Valid characters";
            // 
            // labelValue
            // 
            this.labelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(128, 20);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(133, 260);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = resources.GetString("labelValue.Text");
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.Location = new System.Drawing.Point(7, 20);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(77, 260);
            this.labelCharacters.TabIndex = 0;
            this.labelCharacters.Text = "+\r\n-\r\n*\r\n/\r\n^\r\nsqrt (arg)\r\nsin (arg)\r\ncos (arg)\r\ntg (arg)\r\nsh (arg)\r\nch (arg)\r\nth" +
    " (arg)\r\nln (arg)\r\n(base) log (arg)\r\nexp (arg)\r\ne\r\npi\r\n,\r\nx1\r\nx2";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(56, 52);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(90, 20);
            this.textBoxX1.TabIndex = 1;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX2.Location = new System.Drawing.Point(190, 52);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(90, 20);
            this.textBoxX2.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(166, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(18, 13);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "x2";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(32, 52);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(18, 13);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "x1";
            // 
            // labelFunc
            // 
            this.labelFunc.AutoSize = true;
            this.labelFunc.Location = new System.Drawing.Point(9, 15);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(41, 13);
            this.labelFunc.TabIndex = 8;
            this.labelFunc.Text = "f(x1,x2)";
            // 
            // labelApproximation
            // 
            this.labelApproximation.AutoSize = true;
            this.labelApproximation.Location = new System.Drawing.Point(78, 36);
            this.labelApproximation.Name = "labelApproximation";
            this.labelApproximation.Size = new System.Drawing.Size(145, 13);
            this.labelApproximation.TabIndex = 9;
            this.labelApproximation.Text = "Initial approximation (optional)";
            // 
            // FormGradientDescent
            // 
            this.AcceptButton = this.buttonResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 473);
            this.Controls.Add(this.labelApproximation);
            this.Controls.Add(this.labelFunc);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.groupBoxValidCharacters);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxFunction);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "FormGradientDescent";
            this.ShowIcon = false;
            this.Text = "Gradient descent";
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxValidCharacters.ResumeLayout(false);
            this.groupBoxValidCharacters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBoxValidCharacters;
        private System.Windows.Forms.Label labelCharacters;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelFunc;
        private System.Windows.Forms.Label labelApproximation;
    }
}

