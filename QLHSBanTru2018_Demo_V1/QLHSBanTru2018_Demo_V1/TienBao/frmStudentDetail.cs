using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataConnect.DAO.HungTD;
using DataConnect.DAO.TienBao;
using System.IO;
using System.Drawing.Imaging;

namespace QLHSBanTru2018_Demo_V1.TienBao
{
    public partial class frmStudentDetail : DevExpress.XtraEditors.XtraForm
    {
        public int iFunction;
        public DataConnect.Student Student;
        public DataConnect.StudentParent StudentParents;

        #region System
        public frmStudentDetail()
        {
            InitializeComponent();
        }

        #endregion

        #region LoadInfo
        private void LoadEthnicGroupInfor()
        {
            List<DataConnect.EthnicGroup> listEthnicGroup = new EthnicGroupDAO().ListAllEthnicGroup();
            cbbEthnicGroup.DataSource = listEthnicGroup;
            cbbEthnicGroup.DisplayMember = "Name";
            cbbEthnicGroup.ValueMember = "EthnicGroupID";
        }

        private void LoadReligionInfor()
        {
            List<DataConnect.Religion> listReligion = new ReligionDAO().ListAllReligion();
            cbbReligion.DataSource = listReligion;
            cbbReligion.DisplayMember = "Name";
            cbbReligion.ValueMember = "ReligionID";
        }

        private void LoadProvinceInfor()
        {
            List<DataConnect.Location> province = new LocationDAO().ListAllProvince();
            cbbProvince.DataSource = province;
            cbbProvince.DisplayMember = "LocationName";
            cbbProvince.ValueMember = "LocationID";
            cbbProvince.SelectedIndex = 0;

        }
        private void LoadDistrictInfor(int provinceID)
        {
            List<DataConnect.Location> district = new LocationDAO().ListLocationFromParent(provinceID);
            cbbDistrict.DataSource = district;
            cbbDistrict.DisplayMember = "LocationName";
            cbbDistrict.ValueMember = "LocationID";
        }

        private void LoadWardInfor(int districtID)
        {
            List<DataConnect.Location> ward = new LocationDAO().ListLocationFromParent(districtID);
            cbbWard.DataSource = ward;
            cbbWard.DisplayMember = "LocationName";
            cbbWard.ValueMember = "LocationID";
        }
        #endregion

        #region Load DAO

        private void ThemHocSinh()
        {
            if (txtStudentCode.Text != "" &&
             (txtStudentID.Text != "" || iFunction != 1) &&
             txtFirstName.Text != "" &&
             txtLastName.Text != "" &&
             txtHomeName.Text != "" &&
             dtBirthday.Text != "" &&
             txtHobby.Text != "" &&
             txtTalen.Text != "" &&
             txtAddressDetail.Text != "" &&
             txtFatherName.Text != "" &&
             dtFatherBirthday.Text != "" &&
             txtFatherPhone.Text != "" &&
             txtFatherJob.Text != "" &&
             txtMotherName.Text != "" &&
             txtMotherJob.Text != "" &&
             txtMotherPhone.Text != "" &&
             dtMotherBirthday.Text != "")
            {
                DataConnect.Student entity = new DataConnect.Student();
                DataConnect.StudentParent entity2 = new DataConnect.StudentParent();
                entity.StudentCode = txtStudentCode.Text;
                entity.FirstName = txtFirstName.Text;
                entity.LastName = txtLastName.Text;
                entity.HomeName = txtHomeName.Text;
                entity.Birthday = DateTime.Parse(dtBirthday.EditValue.ToString());
                entity.Gender = cbbGender.Text == "Nữ" ? false : true;
                entity.Hobby = txtHobby.Text;
                entity.Talent = txtTalen.Text;
                if (Stream() != null)
                {
                    entity.Image = Stream().ToArray();
                }
                entity.EthnicGroupID = int.Parse(cbbEthnicGroup.SelectedValue.ToString());
                entity.ReligionID = int.Parse(cbbReligion.SelectedValue.ToString());
                entity.LocationID = int.Parse(cbbWard.SelectedValue.ToString());
                entity.AdressDetail = txtAddressDetail.Text;
                entity.Note = txtNote.Text;
                entity.Status = chbStatus.Checked ? true : false;

                entity2.FatherName = txtFatherName.Text;
                entity2.FatherBirthday = DateTime.Parse(dtFatherBirthday.EditValue.ToString());
                entity2.FatherJob = txtFatherJob.Text;
                entity2.FatherPhone = txtFatherPhone.Text;
                entity2.MotherName = txtMotherName.Text;
                entity2.MotherBirthday = DateTime.Parse(dtMotherBirthday.EditValue.ToString());
                entity2.MotherJob = txtMotherJob.Text;
                entity2.MotherPhone = txtMotherPhone.Text;
                entity2.StudentID = int.Parse(txtStudentID.Text);


                StudentDAO m_StudentDAO = new StudentDAO();
                StudentParentsDAO m_StudentParentsDAO = new StudentParentsDAO();

                if (iFunction == 1)
                {
                    entity2.Password = MD5Hash.PasswordEncryptor.MD5Hash("12345");
                    if (m_StudentDAO.StudentInsert(entity) == true && m_StudentParentsDAO.ParentsInsert(entity2) == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông Báo");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hệ thống đã xảy ra lỗi", "Thông Báo");
                    }
                }
                else if (iFunction == 2)
                {
                    entity.StudentID = Student.StudentID;
                    if (m_StudentDAO.StudentUpdate(entity) == true && m_StudentParentsDAO.ParentsUpdate(entity2) == true)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông Báo");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hệ thống đã xảy ra lỗi", "Thông Báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!");
            }
        }

        #endregion


        #region Event

        private void frmStudentDetail_Load(object sender, EventArgs e)
        {
            LoadEthnicGroupInfor();
            LoadReligionInfor();
            LoadProvinceInfor();
            cbbProvince_SelectedIndexChanged(sender, e);
            cbbDistrict_SelectedIndexChanged(sender, e);
            if (iFunction == 1)
            {
                this.Text = "Thêm mới học sinh";
            }
            else if (iFunction == 2)
            {
                this.Text = "Chỉnh sửa thông tin học sinh";
                txtStudentCode.Text = Student.StudentCode;
                txtFirstName.Text = Student.FirstName;
                txtLastName.Text = Student.LastName;
                txtHomeName.Text = Student.HomeName;
                dtBirthday.EditValue = Student.Birthday;
                cbbGender.SelectedIndex = Student.Gender == true ? 0 : 1;
                txtHobby.Text = Student.Hobby;
                txtTalen.Text = Student.Talent;
              

                cbbProvince.SelectedValue = new LocationDAO().GetLocationParent(new LocationDAO().GetLocationParent(Student.LocationID));
                cbbDistrict.SelectedValue = new LocationDAO().GetLocationParent(Student.LocationID);
                cbbWard.SelectedValue = Student.LocationID;

                txtNote.Text = Student.Note;
                chbStatus.Checked = Student.Status;
                try
                {
                    picImage.Image = ToImage(Student.Image.ToArray());
                }
                catch
                {

                }
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThemHocSinh();
        }

        private void btnThayAnh_Click(object sender, EventArgs e)
        {
            LoadImage();
        }
        
        private void MenuThayAnh_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void cbbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDistrictInfor(int.Parse(cbbProvince.SelectedValue.ToString()));
                cbbDistrict.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadWardInfor(int.Parse(cbbDistrict.SelectedValue.ToString()));
                cbbWard.SelectedIndex = 0;
            }
            catch
            {

            }
        }
        #endregion


        #region Image

        private void LoadImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh đại diện";
            ofd.Filter = "Image|*.jpg; *.jpeg; *.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(ofd.FileName);
            }
        }
        private Bitmap ToImage(byte[] img)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] image = img;
            mStream.Write(image, 0, Convert.ToInt32(image.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private MemoryStream Stream()
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                picImage.Image.Save(stream, ImageFormat.Jpeg);
                return stream;
            }
            catch
            {
                return null;
            }
        }

        #endregion


    }
}