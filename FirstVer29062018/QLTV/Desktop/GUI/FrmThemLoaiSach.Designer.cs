namespace Desktop.GUI
{
    partial class FrmThemLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemLoaiSach));
            this.groupControl_TTDG = new DevExpress.XtraEditors.GroupControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_CNDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).BeginInit();
            this.groupControl_TTDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl_TTDG
            // 
            this.groupControl_TTDG.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.Appearance.Options.UseFont = true;
            this.groupControl_TTDG.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.AppearanceCaption.Options.UseFont = true;
            this.groupControl_TTDG.AutoSize = true;
            this.groupControl_TTDG.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl_TTDG.CaptionImageOptions.Image")));
            this.groupControl_TTDG.Controls.Add(this.textBox1);
            this.groupControl_TTDG.Controls.Add(this.label2);
            this.groupControl_TTDG.Controls.Add(this.bt_CNDL);
            this.groupControl_TTDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_TTDG.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl_TTDG.Location = new System.Drawing.Point(0, 0);
            this.groupControl_TTDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl_TTDG.Name = "groupControl_TTDG";
            this.groupControl_TTDG.Size = new System.Drawing.Size(651, 301);
            this.groupControl_TTDG.TabIndex = 1;
            this.groupControl_TTDG.Text = "Thông tin thể loại";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 42);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể loại sách:";
            // 
            // bt_CNDL
            // 
            this.bt_CNDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CNDL.Image = ((System.Drawing.Image)(resources.GetObject("bt_CNDL.Image")));
            this.bt_CNDL.Location = new System.Drawing.Point(232, 205);
            this.bt_CNDL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_CNDL.Name = "bt_CNDL";
            this.bt_CNDL.Size = new System.Drawing.Size(213, 65);
            this.bt_CNDL.TabIndex = 14;
            this.bt_CNDL.Text = "Cập nhật dữ liệu";
            this.bt_CNDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CNDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CNDL.UseVisualStyleBackColor = true;
            this.bt_CNDL.Click += new System.EventHandler(this.bt_CNDL_Click);
            // 
            // FrmThemLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 301);
            this.Controls.Add(this.groupControl_TTDG);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmThemLoaiSach";
            this.Text = "FrmThemLoaiSach";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).EndInit();
            this.groupControl_TTDG.ResumeLayout(false);
            this.groupControl_TTDG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_TTDG;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_CNDL;
    }
}