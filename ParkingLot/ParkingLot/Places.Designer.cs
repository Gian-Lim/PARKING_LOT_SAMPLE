namespace ParkingLot
{
    partial class Places
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlacesDGV = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.EditBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.AddBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.DeleteBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.Status = new Siticone.UI.WinForms.SiticoneComboBox();
            this.PositionTb = new Siticone.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ParkingMenu = new System.Windows.Forms.PictureBox();
            this.CarsMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlacesDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(116, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Parking Lot Management System ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(104, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 22);
            this.panel3.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Places";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cars";
            // 
            // PlacesDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.PlacesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.PlacesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlacesDGV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.PlacesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlacesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PlacesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlacesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.PlacesDGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlacesDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.PlacesDGV.EnableHeadersVisualStyles = false;
            this.PlacesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PlacesDGV.Location = new System.Drawing.Point(93, 234);
            this.PlacesDGV.Name = "PlacesDGV";
            this.PlacesDGV.RowHeadersVisible = false;
            this.PlacesDGV.RowTemplate.Height = 28;
            this.PlacesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlacesDGV.Size = new System.Drawing.Size(798, 370);
            this.PlacesDGV.TabIndex = 26;
            this.PlacesDGV.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.PlacesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PlacesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PlacesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PlacesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PlacesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PlacesDGV.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.PlacesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PlacesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.HotPink;
            this.PlacesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PlacesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PlacesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PlacesDGV.ThemeStyle.HeaderStyle.Height = 32;
            this.PlacesDGV.ThemeStyle.ReadOnly = false;
            this.PlacesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PlacesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PlacesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PlacesDGV.ThemeStyle.RowsStyle.Height = 28;
            this.PlacesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PlacesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PlacesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlacesDGV_CellContentClick);
            // 
            // EditBtn
            // 
            this.EditBtn.BorderThickness = 1;
            this.EditBtn.CheckedState.Parent = this.EditBtn;
            this.EditBtn.CustomImages.Parent = this.EditBtn;
            this.EditBtn.FillColor = System.Drawing.Color.Plum;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.HoveredState.Parent = this.EditBtn;
            this.EditBtn.Location = new System.Drawing.Point(520, 152);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(151, 29);
            this.EditBtn.TabIndex = 25;
            this.EditBtn.Text = "Edit Place";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BorderThickness = 1;
            this.AddBtn.CheckedState.Parent = this.AddBtn;
            this.AddBtn.CustomImages.Parent = this.AddBtn;
            this.AddBtn.FillColor = System.Drawing.Color.Teal;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.HoveredState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(310, 152);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(151, 29);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add Place";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BorderThickness = 1;
            this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
            this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
            this.DeleteBtn.FillColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.HoveredState.Parent = this.DeleteBtn;
            this.DeleteBtn.Location = new System.Drawing.Point(104, 152);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(151, 29);
            this.DeleteBtn.TabIndex = 23;
            this.DeleteBtn.Text = "Delete Place";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Status.FormattingEnabled = true;
            this.Status.HoveredState.Parent = this.Status;
            this.Status.ItemHeight = 30;
            this.Status.Items.AddRange(new object[] {
            "Booked",
            "Free",
            "Maintenance"});
            this.Status.ItemsAppearance.Parent = this.Status;
            this.Status.Location = new System.Drawing.Point(447, 95);
            this.Status.Name = "Status";
            this.Status.ShadowDecoration.Parent = this.Status;
            this.Status.Size = new System.Drawing.Size(172, 36);
            this.Status.TabIndex = 20;
            // 
            // PositionTb
            // 
            this.PositionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PositionTb.DefaultText = "";
            this.PositionTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PositionTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PositionTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PositionTb.DisabledState.Parent = this.PositionTb;
            this.PositionTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PositionTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PositionTb.FocusedState.Parent = this.PositionTb;
            this.PositionTb.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PositionTb.HoveredState.Parent = this.PositionTb;
            this.PositionTb.Location = new System.Drawing.Point(104, 95);
            this.PositionTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PositionTb.Name = "PositionTb";
            this.PositionTb.PasswordChar = '\0';
            this.PositionTb.PlaceholderText = "Position";
            this.PositionTb.SelectedText = "";
            this.PositionTb.ShadowDecoration.Parent = this.PositionTb;
            this.PositionTb.Size = new System.Drawing.Size(234, 36);
            this.PositionTb.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(111, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Parking Lot System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ExitPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(911, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 674);
            this.panel2.TabIndex = 16;
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Image = global::ParkingLot.Properties.Resources.icons8_cancel_50;
            this.ExitPictureBox.Location = new System.Drawing.Point(232, 3);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(36, 34);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 12;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LogoutPictureBox);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.ParkingMenu);
            this.panel1.Controls.Add(this.CarsMenu);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 674);
            this.panel1.TabIndex = 15;
            // 
            // LogoutPictureBox
            // 
            this.LogoutPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoutPictureBox.Image = global::ParkingLot.Properties.Resources.icons8_logout_601;
            this.LogoutPictureBox.Location = new System.Drawing.Point(12, 611);
            this.LogoutPictureBox.Name = "LogoutPictureBox";
            this.LogoutPictureBox.Size = new System.Drawing.Size(51, 51);
            this.LogoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutPictureBox.TabIndex = 16;
            this.LogoutPictureBox.TabStop = false;
            this.LogoutPictureBox.Click += new System.EventHandler(this.LogoutPictureBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::ParkingLot.Properties.Resources.icons8_parking_64;
            this.pictureBox5.Location = new System.Drawing.Point(12, 393);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // ParkingMenu
            // 
            this.ParkingMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParkingMenu.Image = global::ParkingLot.Properties.Resources.icons8_parking_66;
            this.ParkingMenu.Location = new System.Drawing.Point(12, 292);
            this.ParkingMenu.Name = "ParkingMenu";
            this.ParkingMenu.Size = new System.Drawing.Size(51, 51);
            this.ParkingMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ParkingMenu.TabIndex = 13;
            this.ParkingMenu.TabStop = false;
            this.ParkingMenu.Click += new System.EventHandler(this.ParkingMenu_Click);
            // 
            // CarsMenu
            // 
            this.CarsMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarsMenu.Image = global::ParkingLot.Properties.Resources.icons8_indoor_parking_48;
            this.CarsMenu.Location = new System.Drawing.Point(12, 201);
            this.CarsMenu.Name = "CarsMenu";
            this.CarsMenu.Size = new System.Drawing.Size(51, 51);
            this.CarsMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarsMenu.TabIndex = 12;
            this.CarsMenu.TabStop = false;
            this.CarsMenu.Click += new System.EventHandler(this.CarsMenu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::ParkingLot.Properties.Resources.ParkingLot_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            // 
            // Places
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PlacesDGV);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.PositionTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Places";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Places";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlacesDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoutPictureBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox ParkingMenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneDataGridView PlacesDGV;
        private Siticone.UI.WinForms.SiticoneButton EditBtn;
        private Siticone.UI.WinForms.SiticoneButton AddBtn;
        private Siticone.UI.WinForms.SiticoneButton DeleteBtn;
        private Siticone.UI.WinForms.SiticoneComboBox Status;
        private Siticone.UI.WinForms.SiticoneTextBox PositionTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CarsMenu;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
    }
}