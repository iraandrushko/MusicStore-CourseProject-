
namespace MusicStore.WinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dtAlbums = new System.Windows.Forms.DataGridView();
            this.bsAlbums = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAlbums
            // 
            this.dtAlbums.AllowUserToOrderColumns = true;
            this.dtAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlbums.Location = new System.Drawing.Point(13, 13);
            this.dtAlbums.Name = "dtAlbums";
            this.dtAlbums.RowHeadersWidth = 102;
            this.dtAlbums.RowTemplate.Height = 49;
            this.dtAlbums.Size = new System.Drawing.Size(1265, 802);
            this.dtAlbums.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1300, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "My Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SHowMyOrdersButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1300, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buy Selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 827);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtAlbums);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtAlbums;
        private System.Windows.Forms.BindingSource bsAlbums;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}