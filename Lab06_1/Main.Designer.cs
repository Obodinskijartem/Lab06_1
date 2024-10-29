namespace Lab06_1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Очистка ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCubeEdge = new System.Windows.Forms.Label();
            this.txtCubeEdge = new System.Windows.Forms.TextBox();
            this.btnCalculateCubeArea = new System.Windows.Forms.Button();
            this.lblCubeAreaResult = new System.Windows.Forms.Label();
            this.txtCubeAreaResult = new System.Windows.Forms.TextBox();
            this.lblParallelepipedLength = new System.Windows.Forms.Label();
            this.txtParallelepipedLength = new System.Windows.Forms.TextBox();
            this.lblParallelepipedWidth = new System.Windows.Forms.Label();
            this.txtParallelepipedWidth = new System.Windows.Forms.TextBox();
            this.lblParallelepipedHeight = new System.Windows.Forms.Label();
            this.txtParallelepipedHeight = new System.Windows.Forms.TextBox();
            this.btnCalculateParallelepipedArea = new System.Windows.Forms.Button();
            this.lblParallelepipedAreaResult = new System.Windows.Forms.Label();
            this.txtParallelepipedAreaResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCubeEdge
            // 
            this.lblCubeEdge.AutoSize = true;
            this.lblCubeEdge.Location = new System.Drawing.Point(13, 108);
            this.lblCubeEdge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCubeEdge.Name = "lblCubeEdge";
            this.lblCubeEdge.Size = new System.Drawing.Size(165, 16);
            this.lblCubeEdge.TabIndex = 0;
            this.lblCubeEdge.Text = "Довжина ребра куба (A):";
            // 
            // txtCubeEdge
            // 
            this.txtCubeEdge.Location = new System.Drawing.Point(197, 105);
            this.txtCubeEdge.Margin = new System.Windows.Forms.Padding(4);
            this.txtCubeEdge.Name = "txtCubeEdge";
            this.txtCubeEdge.Size = new System.Drawing.Size(132, 22);
            this.txtCubeEdge.TabIndex = 1;
            // 
            // btnCalculateCubeArea
            // 
            this.btnCalculateCubeArea.Location = new System.Drawing.Point(84, 137);
            this.btnCalculateCubeArea.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateCubeArea.Name = "btnCalculateCubeArea";
            this.btnCalculateCubeArea.Size = new System.Drawing.Size(184, 28);
            this.btnCalculateCubeArea.TabIndex = 2;
            this.btnCalculateCubeArea.Text = "Обчислити площу куба";
            this.btnCalculateCubeArea.UseVisualStyleBackColor = true;
            this.btnCalculateCubeArea.Click += new System.EventHandler(this.btnCalculateCubeArea_Click);
            // 
            // lblCubeAreaResult
            // 
            this.lblCubeAreaResult.AutoSize = true;
            this.lblCubeAreaResult.Location = new System.Drawing.Point(13, 184);
            this.lblCubeAreaResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCubeAreaResult.Name = "lblCubeAreaResult";
            this.lblCubeAreaResult.Size = new System.Drawing.Size(147, 16);
            this.lblCubeAreaResult.TabIndex = 3;
            this.lblCubeAreaResult.Text = "Площа поверхні куба:";
            // 
            // txtCubeAreaResult
            // 
            this.txtCubeAreaResult.Location = new System.Drawing.Point(197, 181);
            this.txtCubeAreaResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtCubeAreaResult.Name = "txtCubeAreaResult";
            this.txtCubeAreaResult.ReadOnly = true;
            this.txtCubeAreaResult.Size = new System.Drawing.Size(132, 22);
            this.txtCubeAreaResult.TabIndex = 4;
            // 
            // lblParallelepipedLength
            // 
            this.lblParallelepipedLength.AutoSize = true;
            this.lblParallelepipedLength.Location = new System.Drawing.Point(435, 76);
            this.lblParallelepipedLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParallelepipedLength.Name = "lblParallelepipedLength";
            this.lblParallelepipedLength.Size = new System.Drawing.Size(248, 16);
            this.lblParallelepipedLength.TabIndex = 5;
            this.lblParallelepipedLength.Text = "Довжина основи паралелепіпеда (C):";
            // 
            // txtParallelepipedLength
            // 
            this.txtParallelepipedLength.Location = new System.Drawing.Point(691, 73);
            this.txtParallelepipedLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtParallelepipedLength.Name = "txtParallelepipedLength";
            this.txtParallelepipedLength.Size = new System.Drawing.Size(132, 22);
            this.txtParallelepipedLength.TabIndex = 6;
            // 
            // lblParallelepipedWidth
            // 
            this.lblParallelepipedWidth.AutoSize = true;
            this.lblParallelepipedWidth.Location = new System.Drawing.Point(435, 111);
            this.lblParallelepipedWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParallelepipedWidth.Name = "lblParallelepipedWidth";
            this.lblParallelepipedWidth.Size = new System.Drawing.Size(242, 16);
            this.lblParallelepipedWidth.TabIndex = 7;
            this.lblParallelepipedWidth.Text = "Ширина основи паралелепіпеда (D):";
            // 
            // txtParallelepipedWidth
            // 
            this.txtParallelepipedWidth.Location = new System.Drawing.Point(691, 105);
            this.txtParallelepipedWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtParallelepipedWidth.Name = "txtParallelepipedWidth";
            this.txtParallelepipedWidth.Size = new System.Drawing.Size(132, 22);
            this.txtParallelepipedWidth.TabIndex = 8;
            // 
            // lblParallelepipedHeight
            // 
            this.lblParallelepipedHeight.AutoSize = true;
            this.lblParallelepipedHeight.Location = new System.Drawing.Point(435, 140);
            this.lblParallelepipedHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParallelepipedHeight.Name = "lblParallelepipedHeight";
            this.lblParallelepipedHeight.Size = new System.Drawing.Size(188, 16);
            this.lblParallelepipedHeight.TabIndex = 9;
            this.lblParallelepipedHeight.Text = "Висота паралелепіпеда (H):";
            // 
            // txtParallelepipedHeight
            // 
            this.txtParallelepipedHeight.Location = new System.Drawing.Point(691, 137);
            this.txtParallelepipedHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtParallelepipedHeight.Name = "txtParallelepipedHeight";
            this.txtParallelepipedHeight.Size = new System.Drawing.Size(132, 22);
            this.txtParallelepipedHeight.TabIndex = 10;
            // 
            // btnCalculateParallelepipedArea
            // 
            this.btnCalculateParallelepipedArea.Location = new System.Drawing.Point(512, 169);
            this.btnCalculateParallelepipedArea.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateParallelepipedArea.Name = "btnCalculateParallelepipedArea";
            this.btnCalculateParallelepipedArea.Size = new System.Drawing.Size(256, 46);
            this.btnCalculateParallelepipedArea.TabIndex = 11;
            this.btnCalculateParallelepipedArea.Text = "Обчислити площу паралелепіпеда";
            this.btnCalculateParallelepipedArea.UseVisualStyleBackColor = true;
            this.btnCalculateParallelepipedArea.Click += new System.EventHandler(this.btnCalculateParallelepipedArea_Click);
            // 
            // lblParallelepipedAreaResult
            // 
            this.lblParallelepipedAreaResult.AutoSize = true;
            this.lblParallelepipedAreaResult.Location = new System.Drawing.Point(435, 223);
            this.lblParallelepipedAreaResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParallelepipedAreaResult.Name = "lblParallelepipedAreaResult";
            this.lblParallelepipedAreaResult.Size = new System.Drawing.Size(223, 16);
            this.lblParallelepipedAreaResult.TabIndex = 12;
            this.lblParallelepipedAreaResult.Text = "Площа поверхні паралелепіпеда:";
            // 
            // txtParallelepipedAreaResult
            // 
            this.txtParallelepipedAreaResult.Location = new System.Drawing.Point(691, 223);
            this.txtParallelepipedAreaResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtParallelepipedAreaResult.Name = "txtParallelepipedAreaResult";
            this.txtParallelepipedAreaResult.ReadOnly = true;
            this.txtParallelepipedAreaResult.Size = new System.Drawing.Size(132, 22);
            this.txtParallelepipedAreaResult.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 486);
            this.Controls.Add(this.txtParallelepipedAreaResult);
            this.Controls.Add(this.lblParallelepipedAreaResult);
            this.Controls.Add(this.btnCalculateParallelepipedArea);
            this.Controls.Add(this.txtParallelepipedHeight);
            this.Controls.Add(this.lblParallelepipedHeight);
            this.Controls.Add(this.txtParallelepipedWidth);
            this.Controls.Add(this.lblParallelepipedWidth);
            this.Controls.Add(this.txtParallelepipedLength);
            this.Controls.Add(this.lblParallelepipedLength);
            this.Controls.Add(this.txtCubeAreaResult);
            this.Controls.Add(this.lblCubeAreaResult);
            this.Controls.Add(this.btnCalculateCubeArea);
            this.Controls.Add(this.txtCubeEdge);
            this.Controls.Add(this.lblCubeEdge);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Лабораторна робота №6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCubeEdge;
        private System.Windows.Forms.TextBox txtCubeEdge;
        private System.Windows.Forms.Button btnCalculateCubeArea;
        private System.Windows.Forms.Label lblCubeAreaResult;
        private System.Windows.Forms.TextBox txtCubeAreaResult;
        private System.Windows.Forms.Label lblParallelepipedLength;
        private System.Windows.Forms.TextBox txtParallelepipedLength;
        private System.Windows.Forms.Label lblParallelepipedWidth;
        private System.Windows.Forms.TextBox txtParallelepipedWidth;
        private System.Windows.Forms.Label lblParallelepipedHeight;
        private System.Windows.Forms.TextBox txtParallelepipedHeight;
        private System.Windows.Forms.Button btnCalculateParallelepipedArea;
        private System.Windows.Forms.Label lblParallelepipedAreaResult;
        private System.Windows.Forms.TextBox txtParallelepipedAreaResult;
    }
}