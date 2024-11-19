namespace _12_Student_Grading_System_With_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int id = 0;
        string state = "0";
        static double avg, midterm, midtermPercentage, final, finalPercentage, project1, p1Percentage, project2,
            p2Percentage;

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (TxtMidterm.Text != "" && TxtFinal.Text != "" && CmbMidterm.Text != "" && CmbFinal.Text != "")
            {
                midterm = Convert.ToDouble(TxtMidterm.Text);
                midtermPercentage = Convert.ToDouble(CmbMidterm.Text);

                final = Convert.ToDouble(TxtFinal.Text);
                finalPercentage = Convert.ToDouble(CmbFinal.Text);

                if (TxtProject1.Text != "" && CmbProject1.Text != "")
                {
                    state = "1";
                    project1 = Convert.ToDouble(TxtProject1.Text);
                    p1Percentage = Convert.ToDouble(CmbProject1.Text);

                    if (TxtProject2.Text != "" && CmbProject2.Text != "")
                    {
                        state = "2";
                        project2 = Convert.ToDouble(TxtProject2.Text);
                        p2Percentage = Convert.ToDouble(CmbProject2.Text);
                    }
                }

                if (state == "0")
                {
                    avg = ((midterm * midtermPercentage) / 100) + ((final * finalPercentage) / 100);
                }
                else if (state == "1")
                {
                    avg = ((midterm * midtermPercentage) / 100) + ((final * finalPercentage) / 100) + ((project1 * p1Percentage) / 100);
                }
                else
                {
                    avg = ((midterm * midtermPercentage) / 100) + ((final * finalPercentage) / 100) + ((project1 * p1Percentage) / 100) + ((project2 * p2Percentage) / 100);
                }

                TxtAvarage.Text = avg.ToString();

                if (avg <= 50)
                {
                    TxtState.Text = "Kaldý";
                }
                else
                {
                    TxtState.Text = "Geçti";
                }
            }
            else
            {
                MessageBox.Show("Zorunlu bilgiler girilmeden hesaplama yapýlamamaktadýr.", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNameSurname.Clear();
            MTxtNumber.Clear();
            CmbLesson.SelectedIndex = -1;
            CmbDepartment.SelectedIndex = -1;
            TxtState.Text = "";
            TxtAvarage.Text = "";
            TxtMidterm.Text = "";
            TxtFinal.Text = "";
            TxtProject1.Text = "";
            TxtProject2.Text = "";
            CmbMidterm.SelectedIndex = -1;
            CmbFinal.SelectedIndex = -1;
            CmbProject1.SelectedIndex = -1;
            CmbProject2.SelectedIndex = -1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            id++;
            ListStudent.Items.Add(id + "- " + MTxtNumber.Text + "\t" + TxtNameSurname.Text + "\t" + CmbDepartment.Text + "\t" + CmbLesson.Text + "\t" + TxtAvarage.Text + "\t" + TxtState.Text);
        }
    }
}