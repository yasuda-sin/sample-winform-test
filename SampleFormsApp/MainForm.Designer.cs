namespace SampleFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.XY = new System.Windows.Forms.Label();
            this.txtXY = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(93, 46);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 19);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(241, 46);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 19);
            this.txtY.TabIndex = 1;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(75, 49);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(12, 12);
            this.X.TabIndex = 2;
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(223, 49);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(12, 12);
            this.Y.TabIndex = 3;
            this.Y.Text = "Y";
            // 
            // XY
            // 
            this.XY.AutoSize = true;
            this.XY.Location = new System.Drawing.Point(392, 49);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(25, 12);
            this.XY.TabIndex = 5;
            this.XY.Text = "X+Y";
            // 
            // txtXY
            // 
            this.txtXY.Enabled = false;
            this.txtXY.Location = new System.Drawing.Point(423, 46);
            this.txtXY.Name = "txtXY";
            this.txtXY.Size = new System.Drawing.Size(100, 19);
            this.txtXY.TabIndex = 4;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(539, 44);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "計算";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(91, 78);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(0, 12);
            this.warn.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.XY);
            this.Controls.Add(this.txtXY);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label XY;
        private System.Windows.Forms.TextBox txtXY;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label warn;
    }
}

