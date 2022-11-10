
namespace MusicStore.WinForms
{
    partial class MyOrdersForm
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
            this.dtOrders = new System.Windows.Forms.DataGridView();
            this.bsOrders = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOrders
            // 
            this.dtOrders.AllowUserToAddRows = false;
            this.dtOrders.AllowUserToDeleteRows = false;
            this.dtOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOrders.Location = new System.Drawing.Point(13, 13);
            this.dtOrders.Name = "dtOrders";
            this.dtOrders.ReadOnly = true;
            this.dtOrders.RowHeadersWidth = 102;
            this.dtOrders.RowTemplate.Height = 49;
            this.dtOrders.Size = new System.Drawing.Size(1161, 614);
            this.dtOrders.TabIndex = 0;
            // 
            // MyOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 639);
            this.Controls.Add(this.dtOrders);
            this.Name = "MyOrdersForm";
            this.Text = "MyOrdersForm";
            this.Load += new System.EventHandler(this.MyOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtOrders;
        private System.Windows.Forms.BindingSource bsOrders;
    }
}