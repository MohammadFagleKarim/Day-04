namespace Coffee_Shop
{
    partial class ArrayTest
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
            this.showBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeTB = new System.Windows.Forms.TextBox();
            this.addSizeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.elementTB = new System.Windows.Forms.TextBox();
            this.addElementBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(389, 202);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 0;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // sizeTB
            // 
            this.sizeTB.Location = new System.Drawing.Point(264, 56);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(100, 20);
            this.sizeTB.TabIndex = 2;
            // 
            // addSizeBtn
            // 
            this.addSizeBtn.Location = new System.Drawing.Point(435, 56);
            this.addSizeBtn.Name = "addSizeBtn";
            this.addSizeBtn.Size = new System.Drawing.Size(75, 23);
            this.addSizeBtn.TabIndex = 3;
            this.addSizeBtn.Text = "Add Size";
            this.addSizeBtn.UseVisualStyleBackColor = true;
            this.addSizeBtn.Click += new System.EventHandler(this.addSizeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Element";
            // 
            // elementTB
            // 
            this.elementTB.Location = new System.Drawing.Point(264, 100);
            this.elementTB.Name = "elementTB";
            this.elementTB.Size = new System.Drawing.Size(100, 20);
            this.elementTB.TabIndex = 2;
            // 
            // addElementBtn
            // 
            this.addElementBtn.Location = new System.Drawing.Point(435, 100);
            this.addElementBtn.Name = "addElementBtn";
            this.addElementBtn.Size = new System.Drawing.Size(75, 23);
            this.addElementBtn.TabIndex = 3;
            this.addElementBtn.Text = "Add Element";
            this.addElementBtn.UseVisualStyleBackColor = true;
            this.addElementBtn.Click += new System.EventHandler(this.addElementBtn_Click);
            // 
            // ArrayTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addElementBtn);
            this.Controls.Add(this.addSizeBtn);
            this.Controls.Add(this.elementTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showBtn);
            this.Name = "ArrayTest";
            this.Text = "ArrayTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeTB;
        private System.Windows.Forms.Button addSizeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox elementTB;
        private System.Windows.Forms.Button addElementBtn;
    }
}