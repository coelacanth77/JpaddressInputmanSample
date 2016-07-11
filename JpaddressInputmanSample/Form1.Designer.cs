namespace JpaddressInputmanSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.gcPostal1 = new GrapeCity.Win.Editors.GcPostal(this.components);
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            this.gcJPAddress1 = new GrapeCity.Win.JPAddress.GcJPAddress();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcPostal1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPostal1
            // 
            this.gcPostal1.AddressOutput = this.label1;
            this.gcPostal1.Fields.ZipCodeSeparator.Text = "-";
            this.gcPostal1.Location = new System.Drawing.Point(13, 28);
            this.gcPostal1.Name = "gcPostal1";
            this.gcShortcut1.SetShortcuts(this.gcPostal1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcPostal1)),
                ((object)(this.gcPostal1))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
            this.gcPostal1.Size = new System.Drawing.Size(120, 20);
            this.gcPostal1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcPostal1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gcPostal1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GrapeCity.Win.Editors.GcPostal gcPostal1;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private GrapeCity.Win.JPAddress.GcJPAddress gcJPAddress1;
        private System.Windows.Forms.Label label1;
    }
}

