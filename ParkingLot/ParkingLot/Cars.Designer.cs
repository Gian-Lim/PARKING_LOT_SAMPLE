namespace ParkingLot
{
    partial class Cars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.CarsDGV = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.EditBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.AddBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.DeleteBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.ColorTb = new Siticone.UI.WinForms.SiticoneTextBox();
            this.CarType = new Siticone.UI.WinForms.SiticoneTextBox();
            this.GenCb = new Siticone.UI.WinForms.SiticoneComboBox();
            this.DriverTb = new Siticone.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutPictureBox = new System.Windows.Forms.PictureBox();
            this.PlacesMenu = new System.Windows.Forms.PictureBox();
            this.ParkingMenu = new System.Windows.Forms.PictureBox();
            this.CarsMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PNumberTb = new Siticone.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlacesMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            // 
            // CarsDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CarsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CarsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsDGV.BackgroundColor = System.Drawing.Color.MintCream;
            this.CarsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CarsDGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CarsDGV.EnableHeadersVisualStyles = false;
            this.CarsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsDGV.Location = new System.Drawing.Point(93, 292);
            this.CarsDGV.Name = "CarsDGV";
            this.CarsDGV.RowHeadersVisible = false;
            this.CarsDGV.RowTemplate.Height = 28;
            this.CarsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarsDGV.Size = new System.Drawing.Size(802, 370);
            this.CarsDGV.TabIndex = 39;
            this.CarsDGV.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CarsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CarsDGV.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.CarsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.HotPink;
            this.CarsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CarsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CarsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CarsDGV.ThemeStyle.HeaderStyle.Height = 32;
            this.CarsDGV.ThemeStyle.ReadOnly = false;
            this.CarsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CarsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarsDGV.ThemeStyle.RowsStyle.Height = 28;
            this.CarsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsDGV_CellContentClick);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(104, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 22);
            this.panel3.TabIndex = 40;
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
            // EditBtn
            // 
            this.EditBtn.BorderThickness = 1;
            this.EditBtn.CheckedState.Parent = this.EditBtn;
            this.EditBtn.CustomImages.Parent = this.EditBtn;
            this.EditBtn.FillColor = System.Drawing.Color.Plum;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.HoveredState.Parent = this.EditBtn;
            this.EditBtn.Location = new System.Drawing.Point(671, 232);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(151, 29);
            this.EditBtn.TabIndex = 38;
            this.EditBtn.Text = "Edit Car";
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
            this.AddBtn.Location = new System.Drawing.Point(456, 232);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(151, 29);
            this.AddBtn.TabIndex = 37;
            this.AddBtn.Text = "Add Car";
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
            this.DeleteBtn.Location = new System.Drawing.Point(241, 232);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(151, 29);
            this.DeleteBtn.TabIndex = 36;
            this.DeleteBtn.Text = "Delete Car";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ColorTb
            // 
            this.ColorTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ColorTb.DefaultText = "";
            this.ColorTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ColorTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ColorTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ColorTb.DisabledState.Parent = this.ColorTb;
            this.ColorTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ColorTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ColorTb.FocusedState.Parent = this.ColorTb;
            this.ColorTb.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ColorTb.HoveredState.Parent = this.ColorTb;
            this.ColorTb.Location = new System.Drawing.Point(528, 170);
            this.ColorTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ColorTb.Name = "ColorTb";
            this.ColorTb.PasswordChar = '\0';
            this.ColorTb.PlaceholderText = "Color";
            this.ColorTb.SelectedText = "";
            this.ColorTb.ShadowDecoration.Parent = this.ColorTb;
            this.ColorTb.Size = new System.Drawing.Size(255, 36);
            this.ColorTb.TabIndex = 35;
            // 
            // CarType
            // 
            this.CarType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CarType.DefaultText = "";
            this.CarType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CarType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CarType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CarType.DisabledState.Parent = this.CarType;
            this.CarType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CarType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CarType.FocusedState.Parent = this.CarType;
            this.CarType.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CarType.HoveredState.Parent = this.CarType;
            this.CarType.Location = new System.Drawing.Point(241, 170);
            this.CarType.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CarType.Name = "CarType";
            this.CarType.PasswordChar = '\0';
            this.CarType.PlaceholderText = "Car Type";
            this.CarType.SelectedText = "";
            this.CarType.ShadowDecoration.Parent = this.CarType;
            this.CarType.Size = new System.Drawing.Size(231, 36);
            this.CarType.TabIndex = 34;
            // 
            // GenCb
            // 
            this.GenCb.BackColor = System.Drawing.Color.Transparent;
            this.GenCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenCb.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GenCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenCb.FormattingEnabled = true;
            this.GenCb.HoveredState.Parent = this.GenCb;
            this.GenCb.ItemHeight = 30;
            this.GenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenCb.ItemsAppearance.Parent = this.GenCb;
            this.GenCb.Location = new System.Drawing.Point(650, 109);
            this.GenCb.Name = "GenCb";
            this.GenCb.ShadowDecoration.Parent = this.GenCb;
            this.GenCb.Size = new System.Drawing.Size(172, 36);
            this.GenCb.TabIndex = 33;
            // 
            // DriverTb
            // 
            this.DriverTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DriverTb.DefaultText = "";
            this.DriverTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DriverTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DriverTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DriverTb.DisabledState.Parent = this.DriverTb;
            this.DriverTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DriverTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DriverTb.FocusedState.Parent = this.DriverTb;
            this.DriverTb.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DriverTb.HoveredState.Parent = this.DriverTb;
            this.DriverTb.Location = new System.Drawing.Point(376, 108);
            this.DriverTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DriverTb.Name = "DriverTb";
            this.DriverTb.PasswordChar = '\0';
            this.DriverTb.PlaceholderText = "Driver";
            this.DriverTb.SelectedText = "";
            this.DriverTb.ShadowDecoration.Parent = this.DriverTb;
            this.DriverTb.Size = new System.Drawing.Size(231, 36);
            this.DriverTb.TabIndex = 32;
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
            this.label1.TabIndex = 30;
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
            this.panel2.TabIndex = 29;
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
            this.panel1.Controls.Add(this.PlacesMenu);
            this.panel1.Controls.Add(this.ParkingMenu);
            this.panel1.Controls.Add(this.CarsMenu);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 674);
            this.panel1.TabIndex = 28;
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
            // PlacesMenu
            // 
            this.PlacesMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlacesMenu.Image = global::ParkingLot.Properties.Resources.icons8_parking_64;
            this.PlacesMenu.Location = new System.Drawing.Point(12, 393);
            this.PlacesMenu.Name = "PlacesMenu";
            this.PlacesMenu.Size = new System.Drawing.Size(51, 51);
            this.PlacesMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlacesMenu.TabIndex = 14;
            this.PlacesMenu.TabStop = false;
            this.PlacesMenu.Click += new System.EventHandler(this.PlacesMenu_Click);
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
            // PNumberTb
            // 
            this.PNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNumberTb.DefaultText = "";
            this.PNumberTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNumberTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNumberTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNumberTb.DisabledState.Parent = this.PNumberTb;
            this.PNumberTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNumberTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNumberTb.FocusedState.Parent = this.PNumberTb;
            this.PNumberTb.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNumberTb.HoveredState.Parent = this.PNumberTb;
            this.PNumberTb.Location = new System.Drawing.Point(98, 108);
            this.PNumberTb.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.PNumberTb.Name = "PNumberTb";
            this.PNumberTb.PasswordChar = '\0';
            this.PNumberTb.PlaceholderText = "Plate Number";
            this.PNumberTb.SelectedText = "";
            this.PNumberTb.ShadowDecoration.Parent = this.PNumberTb;
            this.PNumberTb.Size = new System.Drawing.Size(234, 36);
            this.PNumberTb.TabIndex = 41;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 674);
            this.Controls.Add(this.PNumberTb);
            this.Controls.Add(this.CarsDGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ColorTb);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.GenCb);
            this.Controls.Add(this.DriverTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlacesMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.PictureBox CarsMenu;
        private Siticone.UI.WinForms.SiticoneDataGridView CarsDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneButton EditBtn;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox PlacesMenu;
        private System.Windows.Forms.PictureBox ParkingMenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Siticone.UI.WinForms.SiticoneButton AddBtn;
        private Siticone.UI.WinForms.SiticoneButton DeleteBtn;
        private Siticone.UI.WinForms.SiticoneTextBox ColorTb;
        private Siticone.UI.WinForms.SiticoneTextBox CarType;
        private Siticone.UI.WinForms.SiticoneComboBox GenCb;
        private Siticone.UI.WinForms.SiticoneTextBox DriverTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LogoutPictureBox;
        private Siticone.UI.WinForms.SiticoneTextBox PNumberTb;
    }
}