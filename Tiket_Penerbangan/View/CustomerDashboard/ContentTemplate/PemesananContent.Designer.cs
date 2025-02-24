namespace Tiket_Penerbangan.View.CustomerDashboard.ContentTemplate
{
    partial class PemesananContent
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.containerPanel = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiketPenerbanganDataSet1 = new Tiket_Penerbangan.tiketPenerbanganDataSet1();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reverseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tiketPenerbanganDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new Tiket_Penerbangan.tiketPenerbanganDataSet1TableAdapters.BookingTableAdapter();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiketPenerbanganDataSet1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiketPenerbanganDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.containerPanel);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1050, 524);
            this.guna2Panel2.TabIndex = 1;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.Location = new System.Drawing.Point(0, 122);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1050, 399);
            this.containerPanel.TabIndex = 2;
            this.containerPanel.Text = "guna2ContainerControl1";
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.tiketPenerbanganDataSet1;
            // 
            // tiketPenerbanganDataSet1
            // 
            this.tiketPenerbanganDataSet1.DataSetName = "tiketPenerbanganDataSet1";
            this.tiketPenerbanganDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2ComboBox3);
            this.guna2Panel1.Controls.Add(this.searchBtn);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Location = new System.Drawing.Point(89, 25);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(25);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(890, 69);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.Location = new System.Drawing.Point(451, 14);
            this.guna2ComboBox3.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.Size = new System.Drawing.Size(164, 36);
            this.guna2ComboBox3.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.BorderRadius = 4;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.searchBtn.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(88)))), ((int)(((byte)(243)))));
            this.searchBtn.Location = new System.Drawing.Point(710, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(168, 39);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.guna2ComboBox1);
            this.flowLayoutPanel1.Controls.Add(this.reverseButton);
            this.flowLayoutPanel1.Controls.Add(this.guna2ComboBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 94);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(15, 14);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 0;
            // 
            // reverseButton
            // 
            this.reverseButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.reverseButton.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.reverseButton.Image = global::Tiket_Penerbangan.Properties.Resources.icons8_reverse_arrow_50;
            this.reverseButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.reverseButton.ImageRotate = 0F;
            this.reverseButton.ImageSize = new System.Drawing.Size(34, 34);
            this.reverseButton.Location = new System.Drawing.Point(173, 5);
            this.reverseButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.reverseButton.Size = new System.Drawing.Size(64, 53);
            this.reverseButton.TabIndex = 1;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(255, 14);
            this.guna2ComboBox2.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox2.TabIndex = 2;
            // 
            // tiketPenerbanganDataSet1BindingSource
            // 
            this.tiketPenerbanganDataSet1BindingSource.DataSource = this.tiketPenerbanganDataSet1;
            this.tiketPenerbanganDataSet1BindingSource.Position = 0;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.tiketPenerbanganDataSet1BindingSource;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // PemesananContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Roboto Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PemesananContent";
            this.Size = new System.Drawing.Size(1050, 524);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiketPenerbanganDataSet1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tiketPenerbanganDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ImageButton reverseButton;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ContainerControl containerPanel;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private tiketPenerbanganDataSet1 tiketPenerbanganDataSet1;
        private System.Windows.Forms.BindingSource tiketPenerbanganDataSet1BindingSource;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private tiketPenerbanganDataSet1TableAdapters.BookingTableAdapter bookingTableAdapter;
    }
}
