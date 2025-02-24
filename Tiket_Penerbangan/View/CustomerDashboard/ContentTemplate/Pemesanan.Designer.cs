namespace Tiket_Penerbangan.CustomerDashboard.ContentTemplate
{
    partial class Pemesanan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pemesanan));
            this.Card = new Guna.UI2.WinForms.Guna2Panel();
            this.BuyCard = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalHargaCard = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TanggalCekinCard = new System.Windows.Forms.Label();
            this.TglBerangkatCard = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.namaCard = new System.Windows.Forms.Label();
            this.ImageCard = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Card.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.White;
            this.Card.Controls.Add(this.BuyCard);
            this.Card.Controls.Add(this.tableLayoutPanel5);
            this.Card.Controls.Add(this.tableLayoutPanel4);
            this.Card.Controls.Add(this.tableLayoutPanel3);
            this.Card.Location = new System.Drawing.Point(39, 41);
            this.Card.Margin = new System.Windows.Forms.Padding(4);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(1125, 128);
            this.Card.TabIndex = 8;
            // 
            // BuyCard
            // 
            this.BuyCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuyCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuyCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuyCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuyCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuyCard.ForeColor = System.Drawing.Color.White;
            this.BuyCard.Location = new System.Drawing.Point(881, 81);
            this.BuyCard.Margin = new System.Windows.Forms.Padding(4);
            this.BuyCard.Name = "BuyCard";
            this.BuyCard.Size = new System.Drawing.Size(220, 37);
            this.BuyCard.TabIndex = 6;
            this.BuyCard.Text = "Choose";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.61929F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.38071F));
            this.tableLayoutPanel5.Controls.Add(this.TotalHargaCard, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(843, 18);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.45455F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.54546F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(263, 54);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // TotalHargaCard
            // 
            this.TotalHargaCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalHargaCard.AutoSize = true;
            this.TotalHargaCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHargaCard.Location = new System.Drawing.Point(4, 15);
            this.TotalHargaCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalHargaCard.Name = "TotalHargaCard";
            this.TotalHargaCard.Size = new System.Drawing.Size(255, 23);
            this.TotalHargaCard.TabIndex = 2;
            this.TotalHargaCard.Text = "Rp 778.800/pax";
            this.TotalHargaCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.84848F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.15152F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.TanggalCekinCard, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TglBerangkatCard, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(440, 23);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(267, 49);
            this.tableLayoutPanel4.TabIndex = 4;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // TanggalCekinCard
            // 
            this.TanggalCekinCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TanggalCekinCard.AutoSize = true;
            this.TanggalCekinCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanggalCekinCard.Location = new System.Drawing.Point(4, 0);
            this.TanggalCekinCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TanggalCekinCard.Name = "TanggalCekinCard";
            this.TanggalCekinCard.Size = new System.Drawing.Size(91, 49);
            this.TanggalCekinCard.TabIndex = 2;
            this.TanggalCekinCard.Text = "19:10";
            this.TanggalCekinCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TglBerangkatCard
            // 
            this.TglBerangkatCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TglBerangkatCard.AutoSize = true;
            this.TglBerangkatCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglBerangkatCard.Location = new System.Drawing.Point(170, 0);
            this.TglBerangkatCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TglBerangkatCard.Name = "TglBerangkatCard";
            this.TglBerangkatCard.Size = new System.Drawing.Size(93, 49);
            this.TglBerangkatCard.TabIndex = 3;
            this.TglBerangkatCard.Text = "21:10";
            this.TglBerangkatCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.76025F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.23975F));
            this.tableLayoutPanel3.Controls.Add(this.namaCard, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ImageCard, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 18);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(263, 54);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // namaCard
            // 
            this.namaCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namaCard.AutoSize = true;
            this.namaCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaCard.Location = new System.Drawing.Point(77, 0);
            this.namaCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namaCard.Name = "namaCard";
            this.namaCard.Size = new System.Drawing.Size(182, 54);
            this.namaCard.TabIndex = 1;
            this.namaCard.Text = "Nama Penerbangan";
            this.namaCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageCard
            // 
            this.ImageCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCard.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageCard.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageCard.Image = ((System.Drawing.Image)(resources.GetObject("ImageCard.Image")));
            this.ImageCard.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageCard.ImageRotate = 0F;
            this.ImageCard.Location = new System.Drawing.Point(4, 4);
            this.ImageCard.Margin = new System.Windows.Forms.Padding(4);
            this.ImageCard.Name = "ImageCard";
            this.ImageCard.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageCard.Size = new System.Drawing.Size(65, 46);
            this.ImageCard.TabIndex = 0;
            // 
            // Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Card);
            this.Name = "Pemesanan";
            this.Size = new System.Drawing.Size(1188, 256);
            this.Card.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Card;
        private Guna.UI2.WinForms.Guna2Button BuyCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label TotalHargaCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label TanggalCekinCard;
        private System.Windows.Forms.Label TglBerangkatCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label namaCard;
        private Guna.UI2.WinForms.Guna2ImageButton ImageCard;
    }
}
