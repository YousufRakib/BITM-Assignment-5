using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassEx
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            gpaTextBox.Minimum = 0;
            gpaTextBox.Maximum = 4;
        }
        List<string> ids = new List<string> { };
        List<string> names = new List<string> { };
        List<int> phones = new List<int> { };
        List<int> ages = new List<int> { };
        List<string> addresses = new List<string> { };
        List<float> gpas = new List<float> { };
        string maxValueName;
        string minValueName;
        float average;




        private void addButton_Click(object sender, EventArgs e)
        {
            string messege = "";
            if (!ids.Contains(idTextBox.Text) && idTextBox.Text.Length==4)
            {
                if (names != null)
                {
                    if (!phones.Contains(Convert.ToInt32(mobileTextBox.Text)) && mobileTextBox.Text.Length == 11)
                    {
                        if (ages != null)
                        {
                            infoRichBox.Clear();
                            ids.Add(idTextBox.Text);
                            names.Add(nameTextBox.Text);
                            phones.Add(Convert.ToInt32(mobileTextBox.Text));
                            ages.Add(Convert.ToInt32(ageTextBox.Text));
                            addresses.Add(addressTextBox.Text);
                            gpas.Add((float)Convert.ToDouble(gpaTextBox.Value));
                            messege = "Student Information: " + "\n Id: " + idTextBox.Text + "\n Name: " + nameTextBox.Text + "\n Contract No: " + mobileTextBox.Text + "\n Age: " + Convert.ToInt32(ageTextBox.Text) + "\n Address: " +
                                      addressTextBox.Text + "\n GPA Point: " + (float)Convert.ToDouble(gpaTextBox.Value) + "\n \n";
                            infoRichBox.AppendText(messege);
                            idTextBox.Clear();
                            nameTextBox.Clear();
                            mobileTextBox.Clear();
                            ageTextBox.Clear();
                            addressTextBox.Clear();
                            maxShowTextBox.Clear();
                            maxNameShowTextBox.Clear();
                            minShowTextBox.Clear();
                            minNameShowTextBox.Clear();
                            avgShowTextBox.Clear();
                            totalShowTextBox.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Please enter your age");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("This number is already used or Please enter 11 degits phone number");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your name");
                    return;
                }
            }
            else
            {
                MessageBox.Show("This id already used or Please enter 4 degits id");
                return;
            }
        }
        private void ShowData()
        {
            float maxGpa = 0;
            float minGpa=float.MaxValue;
            float sumGpa = 0;
            infoRichBox.Clear();
            for (int i = 0; i < names.Count(); i++)
            {
                infoRichBox.Text += "Student Information: " + "\n Id: " + ids[i] + "\n Name: " + names[i] + "\n Contract No: " + phones[i] + "\n Age: " + ages[i] + "\n Address: " +
                                      addresses[i] + "\n GPA Point: " + gpas[i] + "\n \n";
                sumGpa = sumGpa + gpas[i];
                if (gpas[i] > maxGpa)
                {
                    maxGpa = (float)Convert.ToDouble(gpas[i]);
                    maxValueName = names[i];
                }
                //gpas.Min();
                //gpas.Max();
                if (gpas[i] <=minGpa)
                {
                    minGpa = (float)Convert.ToDouble(gpas[i]);
                    minValueName = names[i];
                }
                average = gpas.Average();
            }
            maxShowTextBox.Text =Convert.ToString(maxGpa);
            maxNameShowTextBox.Text =maxValueName;
            minShowTextBox.Text = Convert.ToString(minGpa);
            minNameShowTextBox.Text = minValueName;
            avgShowTextBox.Text =Convert.ToString(average);
            totalShowTextBox.Text = Convert.ToString(sumGpa);

            idTextBox.Clear();
            nameTextBox.Clear();
            mobileTextBox.Clear();
            ageTextBox.Clear();
            addressTextBox.Clear();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        private void SearchInfo()
        {
            if (idRadioButton.Checked)
            {
                string idFind = idTextBox.Text;
                for (int i = 0; i < ids.Count(); i++)
                {
                    if (idFind == ids[i])
                    {
                        infoRichBox.Text += "Student Information: " + "\n Id: " + ids[i] + "\n Name: " + names[i] + "\n Contract No: " + phones[i] + "\n Age: " + ages[i] + "\n Address: " +
                                      addresses[i] + "\n GPA Point: " + gpas[i] + "\n \n";
                    }
                    idTextBox.Clear();
                    nameTextBox.Clear();
                    mobileTextBox.Clear();
                    ageTextBox.Clear();
                    addressTextBox.Clear();
                    maxShowTextBox.Clear();
                    maxNameShowTextBox.Clear();
                    minShowTextBox.Clear();
                    minNameShowTextBox.Clear();
                    avgShowTextBox.Clear();
                    totalShowTextBox.Clear();
                }
            }
            else if (nameRadioButton.Checked)
            {
                string nameFind = nameTextBox.Text;
                for (int i = 0; i < names.Count(); i++)
                {
                    if (nameFind == names[i])
                    {
                        infoRichBox.Text += "Student Information: " + "\n Id: " + ids[i] + "\n Name: " + names[i] + "\n Contract No: " + phones[i] + "\n Age: " + ages[i] + "\n Address: " +
                                      addresses[i] + "\n GPA Point: " + gpas[i] + "\n \n";
                    }
                    idTextBox.Clear();
                    nameTextBox.Clear();
                    mobileTextBox.Clear();
                    ageTextBox.Clear();
                    addressTextBox.Clear();
                    maxShowTextBox.Clear();
                    maxNameShowTextBox.Clear();
                    minShowTextBox.Clear();
                    minNameShowTextBox.Clear();
                    avgShowTextBox.Clear();
                    totalShowTextBox.Clear();
                }
            }
            else if (mobileRadioButton.Checked)
            {
                string mobileNumberFind = mobileTextBox.Text;
                for (int i = 0; i < phones.Count(); i++)
                {
                    if (mobileNumberFind ==Convert.ToString(phones[i]))
                    {
                        infoRichBox.Text += "Student Information: " + "\n Id: " + ids[i] + "\n Name: " + names[i] + "\n Contract No: " + phones[i] + "\n Age: " + ages[i] + "\n Address: " +
                                      addresses[i] + "\n GPA Point: " + gpas[i] + "\n \n";
                    }
                    idTextBox.Clear();
                    nameTextBox.Clear();
                    mobileTextBox.Clear();
                    ageTextBox.Clear();
                    addressTextBox.Clear();
                    maxShowTextBox.Clear();
                    maxNameShowTextBox.Clear();
                    minShowTextBox.Clear();
                    minNameShowTextBox.Clear();
                    avgShowTextBox.Clear();
                    totalShowTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Select One Please");
                return;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            infoRichBox.Clear();
            SearchInfo();
        }
    }
}
