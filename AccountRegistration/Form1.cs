namespace AccountRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Address = txtAddress.Text;
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.Age = long.Parse(txtAge.Text);        
            StudentInfoClass.ContactNo = long.Parse(txtContactNo.Text); 
            StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);

            Form2 frmConfirm = new Form2();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtMiddleName.Text = "";
                txtAddress.Text = "";
                cbProgram.SelectedIndex = -1; 
                txtAge.Text = "";
                txtContactNo.Text = "";
                txtStudentNo.Text = "";
            }
        }
    }
}

