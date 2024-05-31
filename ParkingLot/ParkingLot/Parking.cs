using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ParkingLot
{
    public partial class Parking : Form
    {

        Functions Con;

        public Parking()
        {
            InitializeComponent();
            Con = new Functions();
            GetCars();
            GetPlaces();
            ShowBooking();

            ForLabel();

        }

        private void GetCars()
        {
            string Query = "SELECT * FROM CarsTbl";
            CarsCb.ValueMember = Con.GetData(Query).Columns["CNum"].ToString();
            CarsCb.DisplayMember = Con.GetData(Query).Columns["PNumber"].ToString();
            CarsCb.DataSource = Con.GetData(Query);
        }

        private void GetPlaces()
        {
            string PSt = "Free";
            string Query = "SELECT * FROM PlaceTbl WHERE PStatus = '{0}'";
            Query = string.Format(Query, PSt);

            PlaceCb.ValueMember = Con.GetData(Query).Columns["PlNum"].ToString();
            PlaceCb.DisplayMember = Con.GetData(Query).Columns["Pposition"].ToString();
            PlaceCb.DataSource = Con.GetData(Query);
        }


        private void ShowBooking()
        {
            string Query = "SELECT * FROM ParkingTbl";
            ParkingDGV.DataSource = Con.GetData(Query);
        }

        private void UpdatedStatus()
        {
            try
            {
                string PSt = "Booked";
                string Place = PlaceCb.SelectedValue.ToString();
                string Query = "UPDATE PlaceTbl SET PStatus = '{0}' WHERE PlNum = {1}";
                Query = string.Format(Query, PSt, Place);
                Con.SetData(Query);
                MessageBox.Show("Place Updated!!!");
               /* ShowPlaces();*/
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CarsMenu_Click(object sender, EventArgs e)
        {
            Cars Obj = new Cars();
            Obj.Show();
            this.Hide();
        }



        private void PlacesMenu_Click(object sender, EventArgs e)
        {
            Places Obj = new Places();
            Obj.Show();
            this.Hide();
        }

       


        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (CarsCb.SelectedIndex == -1 || PlaceCb.SelectedIndex == -1 || AmountTb.Text == "" || DurationTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Car = CarsCb.SelectedValue.ToString();
                    string Duration = DurationTb.Text;
                    int Amount = Convert.ToInt32(AmountTb.Text);
                    string Place = PlaceCb.SelectedValue.ToString();

                    string Query = "INSERT INTO ParkingTbl VALUES('{0}', '{1}', {2}, {3}, '{4}')";
                    Query = string.Format(Query, Car, System.DateTime.Today.ToString(), Duration, Amount, Place);
                    Con.SetData(Query);
                    MessageBox.Show("Place Booked!!!");
                    UpdatedStatus();
                    ShowBooking();
                    ForLabel();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutPictureBox_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        private void ForLabel()
        {
            try
            {
                string[] positions = { "L1R1", "L2R1", "L3R1", "L1R2", "L2R2", "L3R2", "L1R3", "L2R3", "L3R3", "L1R4", "L2R4", "L3R4" };

                foreach (string position in positions)
                {
                    string query = "SELECT PStatus FROM PlaceTbl WHERE Pposition = '{0}'";

                    query = string.Format(query, position);

                    DataTable resultTable = Con.GetData(query);

                    if (resultTable.Rows.Count > 0)
                    {
                        UpdateLabel(position, resultTable.Rows[0]["PStatus"].ToString());
                    }
                    else
                    {
                        UpdateLabel(position, "Not Found");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateLabel(string position, string value)
        {
            switch (position)
            {
                case "L1R1":
                    l1r1lbl.Text = value;
                    break;

                case "L2R1":
                    l2r1lbl.Text = value;
                    break;

                case "L3R1":
                    l3r1lbl.Text = value;
                    break;

                case "L1R2":
                    l1r2lbl.Text = value;
                    break;

                case "L2R2":
                    l2r2lbl.Text = value;
                    break;

                case "L3R2":
                    l3r2lbl.Text = value;
                    break;

                case "L1R3":
                    l1r3lbl.Text = value;
                    break;

                case "L2R3":
                    l2r3lbl.Text = value;
                    break;

                case "L3R3":
                    l3r3lbl.Text = value;
                    break;

                case "L1R4":
                    l1r4lbl.Text = value;
                    break;

                case "L2R4":
                    l2r4lbl.Text = value;
                    break;

                case "L3R4":
                    l3r4lbl.Text = value; 
                    break;

                default:
                    break;
            }
        }




    }
}
