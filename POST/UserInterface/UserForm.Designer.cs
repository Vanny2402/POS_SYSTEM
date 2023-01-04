
namespace POST.UserInterface
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.use_Picturebox = new System.Windows.Forms.PictureBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.is_active = new System.Windows.Forms.CheckBox();
            this.Gridcontroll = new DevExpress.XtraGrid.GridControl();
            this.tBLUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSSQ9_DBDataSet = new POST.POSSQ9_DBDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Photo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tBL_USERTableAdapter = new POST.POSSQ9_DBDataSetTableAdapters.TBL_USERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.use_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridcontroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSSQ9_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "DateOfBirth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Discription:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Photo";
            // 
            // use_Picturebox
            // 
            this.use_Picturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.use_Picturebox.Location = new System.Drawing.Point(380, 23);
            this.use_Picturebox.Name = "use_Picturebox";
            this.use_Picturebox.Size = new System.Drawing.Size(145, 137);
            this.use_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.use_Picturebox.TabIndex = 2;
            this.use_Picturebox.TabStop = false;
            this.use_Picturebox.Click += new System.EventHandler(this.use_Picturebox_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(141, 226);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(384, 97);
            this.txt_description.TabIndex = 7;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(142, 21);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(219, 26);
            this.txt_userName.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(141, 118);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(219, 26);
            this.txt_password.TabIndex = 4;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(143, 152);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(219, 26);
            this.txt_salary.TabIndex = 5;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(142, 184);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(219, 26);
            this.txt_phone.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(420, 348);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 33);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(309, 348);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 33);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ComboGender
            // 
            this.ComboGender.FormattingEnabled = true;
            this.ComboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboGender.Location = new System.Drawing.Point(142, 51);
            this.ComboGender.Name = "ComboGender";
            this.ComboGender.Size = new System.Drawing.Size(217, 28);
            this.ComboGender.TabIndex = 2;
            // 
            // dtDob
            // 
            this.dtDob.Location = new System.Drawing.Point(143, 85);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(200, 26);
            this.dtDob.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Active:";
            // 
            // is_active
            // 
            this.is_active.AutoSize = true;
            this.is_active.Checked = true;
            this.is_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_active.Location = new System.Drawing.Point(141, 348);
            this.is_active.Name = "is_active";
            this.is_active.Size = new System.Drawing.Size(71, 24);
            this.is_active.TabIndex = 11;
            this.is_active.Text = "Active";
            this.is_active.UseVisualStyleBackColor = true;
            // 
            // Gridcontroll
            // 
            this.Gridcontroll.DataSource = this.tBLUSERBindingSource;
            this.Gridcontroll.Location = new System.Drawing.Point(544, 16);
            this.Gridcontroll.MainView = this.gridView1;
            this.Gridcontroll.Name = "Gridcontroll";
            this.Gridcontroll.Size = new System.Drawing.Size(606, 365);
            this.Gridcontroll.TabIndex = 12;
            this.Gridcontroll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLUSERBindingSource
            // 
            this.tBLUSERBindingSource.DataMember = "TBL_USER";
            this.tBLUSERBindingSource.DataSource = this.pOSSQ9_DBDataSet;
            // 
            // pOSSQ9_DBDataSet
            // 
            this.pOSSQ9_DBDataSet.DataSetName = "POSSQ9_DBDataSet";
            this.pOSSQ9_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserName,
            this.Gender,
            this.DateOfBirth,
            this.Discription,
            this.Salary,
            this.Phone,
            this.Photo,
            this.Active});
            this.gridView1.GridControl = this.Gridcontroll;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // UserName
            // 
            this.UserName.Caption = "UserName";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 0;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 3;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Caption = "DateOfBirth";
            this.DateOfBirth.FieldName = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Visible = true;
            this.DateOfBirth.VisibleIndex = 1;
            // 
            // Discription
            // 
            this.Discription.Caption = "Discription";
            this.Discription.FieldName = "Discription";
            this.Discription.Name = "Discription";
            this.Discription.Visible = true;
            this.Discription.VisibleIndex = 2;
            // 
            // Salary
            // 
            this.Salary.Caption = "Salary";
            this.Salary.FieldName = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.Visible = true;
            this.Salary.VisibleIndex = 4;
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone";
            this.Phone.FieldName = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 5;
            // 
            // Photo
            // 
            this.Photo.Caption = "Photo";
            this.Photo.FieldName = "Photo";
            this.Photo.Name = "Photo";
            this.Photo.Visible = true;
            this.Photo.VisibleIndex = 6;
            // 
            // Active
            // 
            this.Active.Caption = "Active";
            this.Active.FieldName = "Active";
            this.Active.Name = "Active";
            this.Active.Visible = true;
            this.Active.VisibleIndex = 7;
            // 
            // tBL_USERTableAdapter
            // 
            this.tBL_USERTableAdapter.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 400);
            this.Controls.Add(this.Gridcontroll);
            this.Controls.Add(this.is_active);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.ComboGender);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.use_Picturebox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserForm";
            this.Text = "USER";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.use_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridcontroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSSQ9_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox use_Picturebox;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox ComboGender;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox is_active;
        private DevExpress.XtraGrid.GridControl Gridcontroll;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn DateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn Discription;
        private DevExpress.XtraGrid.Columns.GridColumn Salary;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Photo;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
        private POSSQ9_DBDataSet pOSSQ9_DBDataSet;
        private System.Windows.Forms.BindingSource tBLUSERBindingSource;
        private POSSQ9_DBDataSetTableAdapters.TBL_USERTableAdapter tBL_USERTableAdapter;
    }
}